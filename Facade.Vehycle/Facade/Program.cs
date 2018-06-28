using Facade.Vehiculos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade {
    class Program {
        static void Main(string[] args) {
            FacadeV facade = new FacadeV();

            facade.ShowCars();
            facade.ShowVehicles();

        }
    }
}
