using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooVueling{
     public interface ICalculadora{
        int Suma(int num1, int num2);
        int Resta(int num1, int num2);
        int Multiplicacion(int num1, int num2);
        int Division(int num1, int num2);
     }
}
