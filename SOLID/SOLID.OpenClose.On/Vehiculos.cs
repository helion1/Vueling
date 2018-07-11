using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OpenClose.Off {
    public abstract class Vehiculo {
        public int Ruedas { get; set; }
        public int Id { get; set; }
        public bool Encendido { get; set; }

        public void EncenderVehiculo(Vehiculo vehiculo) {
            vehiculo.Encendido = true;
        }
    }

    public class Camion : Vehiculo{}

    public class Coche : Vehiculo {}
}
