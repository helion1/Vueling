﻿using System;
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
            string fichero = "..\\..\\stocks-ITX.csv";
            CotizationDayRepository rep = new CotizationDayRepository(fichero);

            try {
                rep.GenerarListado();
                DateTime Fecha = rep.UltimoDiaFichero();
                decimal total = rep.Ganancia(50, 2, Fecha);

                Console.WriteLine($"-------------------------------------------");
                Console.WriteLine($"-------------------------------------------");
                Console.WriteLine($"-------------------------------------------");
                Console.WriteLine($"PRECIO TOTAL DE LA VENTA: {total}");
            }catch (Exception e) {
                throw e;
            }
        }
        
           
    }
}
