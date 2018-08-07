using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos {
    class Program {
        static void Main(string[] args) {

            Adder a = new Adder();

            a.OnMultipleOfFiveReached += a_MultipleOfFiveReached;
             int iAnswer = a.Add(4, 3);
            Console.WriteLine("iAnswer = {0}", iAnswer);

            iAnswer = a.Add(4, 6);
            Console.WriteLine("iAnswer = {0}", iAnswer);
            Console.ReadKey();
        }

        static void a_MultipleOfFiveReached(object sender, MultipleOfFiveEventArgs e) {
            Console.WriteLine("Multiple of five reached: ", e.Total);
        }
    }
}
