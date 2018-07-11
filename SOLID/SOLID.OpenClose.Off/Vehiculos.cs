using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OpenClose.Off {
    public class Camion {
        public int Ruedas { get; set; }
        public int Id { get; set; }
        public bool Encendido { get; set; }

        public void EncenderVehiculo() {
            this.Encendido = true;
        }
    }

    public class Coche {
        public int Ruedas { get; set; }
        public int Id { get; set; }
        public bool Encendido { get; set; }

        public void EncenderVehiculo() {
            this.Encendido = true;
        }
    }
}
