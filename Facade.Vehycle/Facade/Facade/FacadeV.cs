using Facade.Vehycle.SubClases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Vehiculos
{
    public class FacadeV{
        private LittleCar littleCar;
        private BigCar bigCar;
        private Minivan minivan;

        public FacadeV() {
            littleCar = new LittleCar(3, 4, 1200);
            bigCar = new BigCar(5, 5, 2000);
            minivan = new Minivan(5, 7, 3000);
        }

        public void ShowCars() {
            Console.WriteLine(String.Concat(
                    String.Concat("---Lista de coches---\nCoche 1: ",this.littleCar.Description()),
                    String.Concat("\nCoche 2: ", this.bigCar.Description())));
        }

        public void ShowVehicles() {
            Console.WriteLine(String.Concat(
                    String.Concat("---Lista de vehiculos---\nVehiculo 1: ", this.littleCar.Description()),
                    String.Concat(
                    String.Concat("\nVehiculo 2: ", this.bigCar.Description()),
                    String.Concat("\nVehiculo 3: ", this.minivan.Description()))));
        }
    }
}
