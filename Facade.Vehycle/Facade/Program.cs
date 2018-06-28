using Facade.Vehiculos;
using Facade.Vehycle.SubClases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Facade {
    class Program {
        static void Main(string[] args) {
            FacadeV facade = new FacadeV();

            //facade.ShowCars();
            //facade.ShowVehicles();

            //Cargas assembly en mmeoria ram
            Assembly myAssembly = typeof(Program).Assembly;
            //Cargas clase en memoria ram
            Type littleCarType = myAssembly.GetType("Facade.LittleCar");

            //Creas objeto en la Ram
            object littleCar = Activator.CreateInstance(littleCarType, 3, 5, 1000);
            //Casteas de objeto a LittleCar en una variable
            LittleCar coche = (LittleCar)littleCar;
            Console.WriteLine(coche.cc);

        }
    }
}
