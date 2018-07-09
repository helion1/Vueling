using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Zara.Reto0.Common.Model;

namespace Zara.Reto0.Utils
{
    public class CotizationDayRepository : ICotizationDayRepository {
        public string Path { get; set; }
        public List<string> ListaString { get; private set; }
        public List<CotizationDay> ListadoFinal { get; private set; }


        public CotizationDayRepository() {
            ListadoFinal = new List<CotizationDay>();
            ListaString = new List<string>();
        }

        public CotizationDayRepository(string path) {
            this.Path = path;
            ListadoFinal = new List<CotizationDay>();
            ListaString = new List<string>();
        }

        public List<CotizationDay> GenerarListado() {
            ListaString = FileManager.OpenCSV(Path);
            bool firstTimeEnter = true;
            CotizationDay cotDay = new CotizationDay();
            NumberFormatInfo nfi = new NumberFormatInfo();
            nfi.NumberDecimalSeparator = (".");

            foreach (string line in ListaString) {
                if (!firstTimeEnter) {
                    string[] column = line.Split(';');
                    DateTime Fecha = DateTime.ParseExact(column[0], "dd-MMM-yyyy", CultureInfo.CreateSpecificCulture("es-US"));
                    Decimal Apertura = Convert.ToDecimal(column[1], nfi);
                    Decimal Cierre = Convert.ToDecimal(column[2], nfi);
                    ListadoFinal.Add(new CotizationDay(Fecha, Apertura, Cierre));
                } 
                else firstTimeEnter = false;
            }

            return ListadoFinal;
        }

        /*
        public decimal Ganancia() {
            foreach(CotizationDay cp in ListadoFinal) {
                int mesActual = cp.Fecha.Month;

                DateTime UltimoJueves = DateTimeUtil.GetLastThursdayOfTheMonth(cp.Fecha);
            }
            
            return ;
        }*/

        
        public decimal SumaCierres() {
            decimal res = 0;
            foreach(CotizationDay cd in ListadoFinal) {
                res += cd.Cierre;
            }
            return res;
        }
    }
}
