using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OpenClose.Off {
    public static class Gasolinera {
        public static void LavarVehiculos(List<Vehiculo> vehiculos) {
            foreach (var vehiculo in vehiculos) {
                Gasolinera.TunelLavado(vehiculo);
                }
            }

        public static bool TunelLavado(Vehiculo vehiculo) {
            return vehiculo.Limpio = true;
        }
    }

    public abstract class Vehiculo {
        public int ruedas { get; set; }
        public bool Limpio { get; set; }
    }

    public class Camion : Vehiculo{
        public int Carga { get; set; }
    }

    public class Coche : Vehiculo{}


    class Program {
        static void Main(string[] args) {
            Coche coche = new Coche();
            Camion camion = new Camion();
            List<Vehiculo> lista = new List<Vehiculo> {
                coche,
                camion
            };

            Gasolinera.LavarVehiculos(lista);
        }
    }
}
