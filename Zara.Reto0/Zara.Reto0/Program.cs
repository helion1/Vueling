using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zara.Reto0.Common.Model;
using Zara.Reto0.Utils;

namespace Zara.Reto0 {
    class Program {
        static void Main(string[] args) {
            string fichero = "stocks-ITX.csv";
            CotizationDayRepository rep = new CotizationDayRepository(fichero);

            rep.GenerarListado();
            Console.WriteLine(rep.ListadoFinal.Last().Fecha.DayOfWeek+1);
        }
        
           
    }
}
