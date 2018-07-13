using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OpenClose.Off {
    public static class Gasolinera {
        public static void LavarVehiculos(List<object> vehiculos) {
            foreach(var vehiculo in vehiculos) {
                if(vehiculo is Coche) {
                    Gasolinera.TunelPeque((Coche)vehiculo);
                } else {
                    Gasolinera.TunelGrande((Camion)vehiculo);
                }
            }
        }

        public static bool TunelPeque(Coche coche) {
            return coche.Limpio = true;
        }

        public static bool TunelGrande(Camion camion) {
            return camion.Limpio = true;
        }
    }

    public class Camion{
        public bool Limpio { get; set; }
        public int Carga { get; set; }
    }

    public class Coche {
        public bool Limpio { get; set; }
    }

    class Program {
        static void Main(string[] args) {
            Coche coche = new Coche();
            Camion camion = new Camion();
            List<object> lista = new List<object>();

            lista.Add(coche);
            lista.Add(camion);

            Gasolinera.LavarVehiculos(lista);
        }
    }
}
