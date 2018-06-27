using Calculator.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Model {
    public class Calculadora : ICalculadora {
        public int Division(int num1, int num2) {
            return num1 / num2;
        }

        public int Multiplicacion(int num1, int num2) {
            return num1 * num2;
        }

        public int Resta(int num1, int num2) {
            return num1 - num2;
        }

        public int Suma(int num1, int num2) {
            return num1 + num2;
        }
    }
}
