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

        
        public decimal Ganancia() {
            List<CotizationDay> ListadoDiasTransacciones = new List<CotizationDay>();
            List<DateTime> ListadoFechas = new List<DateTime>();

            foreach(CotizationDay cp in ListadoFinal) {
                ListadoFechas.Add(cp.Fecha);
            }

            DateTime diaSemanal = DateTime.Parse("Thursday");
            DateTime diaDeCompra;
            decimal res = 0;
            int mesActual = 0;

            foreach (DateTime dt in ListadoFechas) {
                if (mesActual != dt.Month) {
                    mesActual = dt.Month;
                    diaDeCompra = DateTimeUtil.GetLastThursdayOfTheMonth(dt).AddDays(1);

                    while (!ListadoFechas.Contains(diaDeCompra)) {
                        diaDeCompra = diaDeCompra.AddDays(1);
                    }

                    foreach(CotizationDay cd in ListadoFinal) {
                        if(DateTime.Compare(cd.Fecha, diaDeCompra) == 0) {
                            ListadoDiasTransacciones.Add(cd);
                        }
                    }
                }

                
            }

            

            return res;
        }
        
        
        
        public decimal SumaCierres() {
            decimal res = 0;
            foreach(CotizationDay cd in ListadoFinal) {
                res += cd.Cierre;
            }
            return res;
        }
    }
}
