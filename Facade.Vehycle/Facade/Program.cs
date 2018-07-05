using Facade.Vehiculos;
using Facade.Vehycle.SubClases;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Xml.XPath;

namespace Facade {
    class Program {
        static void Main(string[] args) {
//-------------------------------------------------------------------------------------------
//                          PARTE FACADE
//-------------------------------------------------------------------------------------------
            FacadeV facade = new FacadeV();
            facade.ShowCars();
            facade.ShowVehicles();



//-------------------------------------------------------------------------------------------
//                          PARTE XML y REFLECTION
//-------------------------------------------------------------------------------------------
//                    ------> REFLECTION <-----


            XmlDocument doc = new XmlDocument();
            doc.Load("ReflectionConfiguration.xml");
            //--------------------  XML  OPCION 1 - Xpath -----------------------------------------------------------
            //Recogemos del XML el namespace y la clase
            
            XmlNodeList elemList = doc.GetElementsByTagName("Type");
            string ns = elemList[0].InnerText;


            XPathNavigator nav = doc.CreateNavigator();
            
            //XmlNode root2 = doc.DocumentElement;
            XPathNavigator node = nav.SelectSingleNode("/Types/Type[@id='LittleCar']");
            Console.WriteLine(node.ToString());
            

            //-------------------  XML  OPCION 2 LINQ-------------------------------------------------------
            XElement root = XElement.Load("ReflectionConfiguration.xml");
            IEnumerable<XElement> tests =
                from el in root.Elements("Type")
                where (string)el.Attribute("id") == "LittleCar"
                select el;

            string cadena = tests.First().Value;
            Console.WriteLine(cadena);
            //------------------------------------------------------------------------

            //Cargas assembly en mmeoria ram
            Assembly myAssembly = typeof(Program).Assembly;
            //Cargas clase en memoria ram
            Type littleCarType = myAssembly.GetType(node.ToString());

            //Creas objeto en la Ram
            object littleCar = Activator.CreateInstance(littleCarType, 3, 5, 1000);
            //Casteas de objeto a LittleCar en una variable
            LittleCar coche = (LittleCar)littleCar;
            Console.WriteLine("Tipo de coche: "+coche.GetType()+
                                "\nCilindrada: "+coche.Cc+
                                "\nPuertas: "+coche.Doors+
                                "\nAsientos: "+coche.Seating);
        }
    }
}
