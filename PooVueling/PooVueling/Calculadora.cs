using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooVueling{
    /// <summary>
    /// Calculadora con operaciones básicas
    /// </summary>
    /// <seealso cref="PooVueling.ICalculadora" />
    /// <seealso cref="System.ICloneable" />
    public class Calculadora : ICalculadora, ICloneable{
        public object Clone(){
            throw new NotImplementedException();
        }

        /// <summary>
        /// Divide 2 números
        /// </summary>
        /// <param name="num1">The num1.</param>
        /// <param name="num2">The num2.</param>
        /// <returns></returns>
        public int Division(int num1, int num2){
            return num1 / num2;
        }

        /// <summary>
        /// Multiplica 2 números.
        /// </summary>
        /// <param name="num1">The num1.</param>
        /// <param name="num2">The num2.</param>
        /// <returns></returns>
        public int Multiplicacion(int num1, int num2){
            return num1 * num2;
        }

        /// <summary>
        /// Resta 2 números.
        /// </summary>
        /// <param name="num1">The num1.</param>
        /// <param name="num2">The num2.</param>
        /// <returns></returns>
        public int Resta(int num1, int num2){
            return num1 - num2;
        }

        /// <summary>
        /// Suma 2 números.
        /// </summary>
        /// <param name="num1">The num1.</param>
        /// <param name="num2">The num2.</param>
        /// <returns></returns>
        public int Suma(int num1, int num2){
            return num1 + num2;
        }
    }
}
