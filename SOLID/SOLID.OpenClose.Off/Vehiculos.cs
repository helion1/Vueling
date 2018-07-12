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

        public void EncenderCamion(Camion camion) {
            camion.Encendido = true;
        }
        public bool EsUnCamion() {
            return true;
        }
    }

    public class Coche {
        public int Ruedas { get; set; }
        public int Id { get; set; }
        public bool Encendido { get; set; }

        public void EncenderCoche(Coche coche) {
            coche.Encendido = true;
        }

        public bool EsUnCoche() {
            return true;
        }
    }

    class Program {
        static void Main(string[] args) {
            Coche vehiculo = new Coche();
            Camion vehiculo2 = new Camion();
            
            if(vehiculo.EsUnCoche() == true) {
                vehiculo.EncenderCoche(vehiculo);
            } else {
                vehiculo2.EncenderCamion(vehiculo2);
            }

            

        }
    }
}
