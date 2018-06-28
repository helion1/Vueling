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

            facade.ShowCars();
            facade.ShowVehicles();

            Assembly myAssembly = typeof(Program).Assembly;
            Type littleCarType = myAssembly.GetType("Reflection.LittleCar");

            object littleCar = Activator.CreateInstance(littleCarType, 3, 5, 1000);
            Console.WriteLine(((LittleCar)littleCar).cc);




        }
    }
}
