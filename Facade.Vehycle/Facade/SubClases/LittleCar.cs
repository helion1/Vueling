using Facade.Vehicle.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Vehycle.SubClases {
    [Serializable()]
    public class LittleCar : IVehicle, System.ComponentModel.INotifyPropertyChanged {
        public int Doors { get; set; }
        public int Seating { get; set; }
        public int Cc { get; set; }

        public LittleCar(){
        }

        public LittleCar(int doors, int seating, int cc) {
            this.Doors = doors;
            this.Seating = seating;
            this.Cc = cc;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public string Description() {
            return String.Concat(
                        String.Concat(
                            String.Concat(
                                String.Concat("Coche pequeño\nPuertas:", this.Doors),
                                String.Concat("\nAsientos: ", this.Seating)),
                                String.Concat("\nCilindrada: ", this.Cc),"\n\n\n" ));
        }
    }
}
