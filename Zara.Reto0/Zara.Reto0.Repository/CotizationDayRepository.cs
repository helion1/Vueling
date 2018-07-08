using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Zara.Reto0.Common.Model;

namespace Zara.Reto0.Utils
{
    public class CotizationDayRepository : ICotizationDayRepository {
        public string Path { get; set; }
        public List<string[]> ListaString { get; private set; }
        public List<CotizationDay> ListadoFinal { get; private set; }


        public CotizationDayRepository() {
            ListadoFinal = new List<CotizationDay>();
            ListaString = new List<string[]>();
        }

        public CotizationDayRepository(string path) {
            this.Path = path;
            ListadoFinal = new List<CotizationDay>();
            ListaString = new List<string[]>();
        }

        public List<CotizationDay> GenerarListado() {
            ListaString = FileManager.OpenCSV(Path);
            //bool firstTimeEnter = true;
            CotizationDay cotDay = new CotizationDay();
            NumberFormatInfo nfi = new NumberFormatInfo();
            nfi.NumberDecimalSeparator = (".");

            foreach (string[] line in ListaString) {
                try{
                    string[] column = line[0].Split(';');
                    cotDay.Fecha = DateTime.ParseExact(column[0], "dd-MMM-yyyy",
                                                       CultureInfo.CreateSpecificCulture("es-US"));
                    cotDay.Apertura = Convert.ToDouble(column[1], nfi);
                    cotDay.Cierre = Convert.ToDouble(column[2], nfi);
                    ListadoFinal.Add(cotDay);
                } catch(Exception) {

                }                 
            }
            return ListadoFinal;
        }

        /*public double sumaCierres() {
            double res = 0;
            foreach(CotizationDay cd in ListadoFinal) {
                res += cd.Cierre;
            }
            return res;
        }*/
    }
}
