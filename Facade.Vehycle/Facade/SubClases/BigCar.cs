using Facade.Vehicle.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Vehycle.SubClases {
    class BigCar : IVehicle {
        public int Doors { get; set; }
        public int Seating { get; set; }
        public int Cc { get; set; }

        public BigCar() {

        }

        public BigCar(int doors, int seating, int cc) {
            this.Doors = doors;
            this.Seating = seating;
            this.Cc = cc;
        }

        public string Description() {
            return String.Concat(
                        String.Concat(
                            String.Concat(
                                String.Concat("Coche grande\nPuertas:", this.Doors),
                                String.Concat("\nAsientos: ", this.Seating)),
                                String.Concat("\nCilindrada: ", this.Cc), "\n\n\n"));
        }
    }
}
