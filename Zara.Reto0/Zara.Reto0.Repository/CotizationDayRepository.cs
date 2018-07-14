using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
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
                    Decimal Cierre = Convert.ToDecimal(column[1], nfi);
                    Decimal Apertura = Convert.ToDecimal(column[2], nfi);
                    ListadoFinal.Add(new CotizationDay(Fecha, Apertura, Cierre));
                } 
                else firstTimeEnter = false;
            }
            ListadoFinal.Reverse();
            return ListadoFinal;
        }

        
        public decimal Ganancia(decimal inversionInicial, decimal retencion, DateTime fechaVenta) {
            List<CotizationDay> ListadoDiasTransacciones = new List<CotizationDay>();
            List<DateTime> ListadoFechas = new List<DateTime>();
            
            foreach(CotizationDay cp in ListadoFinal) {
                ListadoFechas.Add(cp.Fecha);
            }

            
            DateTime diaDeCompra;
            int mesActual = 0;

            foreach (DateTime dt in ListadoFechas) {
                if (mesActual != dt.Month) {
                    mesActual = dt.Month;
                    diaDeCompra = DateTimeUtil.GetLastThursdayOfTheMonth(dt).AddDays(1);

                    Console.WriteLine($"\n-----------MES {dt.Month} AÑO {dt.Year}-------------------------");
                    Console.WriteLine($"Dia de compra {diaDeCompra}");

                    while (ListadoFechas.IndexOf(diaDeCompra) == -1 && 
                        DateTime.Compare(diaDeCompra, fechaVenta) < 0) {
                        diaDeCompra = diaDeCompra.AddDays(1);
                        Console.WriteLine($"No hay cotización ese día, siguiente día es {diaDeCompra}");
                    }
                    Console.WriteLine($"Dia {diaDeCompra} válido.");
                    Console.WriteLine($"\n------------------------------------");

                    foreach (CotizationDay cd in ListadoFinal) {
                        if(DateTime.Compare(cd.Fecha, diaDeCompra) == 0 
                            && DateTime.Compare(diaDeCompra,fechaVenta) <0) {
                            ListadoDiasTransacciones.Add(cd);
                            Console.WriteLine($"GUARDADO DÍA {diaDeCompra} EN LISTA DE DÍAS DE COMPRA.");
                        }
                    }
                }
            }

            decimal acciones = 0;
            decimal inversionFinal = inversionInicial - Decimal.Round((Decimal.Round(inversionInicial * retencion)/100), 3);
            decimal accCompradasMes = 0;
            decimal dineroGanadoAnual = 0;

            Console.WriteLine($"\n---------------MOMENTO DE INVERSION---------------------");
            Console.WriteLine($"Retención {retencion} e inversión inicial {inversionInicial}");
            Console.WriteLine($"Inversion final {inversionFinal}");
            int year = 2001;
            decimal total2 = 0;
            decimal dineroGanadoMes = 0;
            decimal accionesAnuales = 0;
            decimal dineroGanadoAnual2 = 0;

            foreach (CotizationDay cd in ListadoDiasTransacciones) {
                if (cd.Fecha.Year != year && !(cd.Fecha.Month == 1 && cd.Fecha.Day < 7)) {
                    dineroGanadoAnual2 = Decimal.Round(Decimal.Multiply(accionesAnuales, Convert.ToDecimal(29.17)), 3);
                    Console.WriteLine($"\n=======================================");
                    //Console.WriteLine($"Dinero sacado en {year}: {dineroGanadoAnual}");
                    Console.WriteLine($"Acciones totales en {year}: {accionesAnuales}");
                    Console.WriteLine($"Dinero ganado en {year}: {dineroGanadoAnual2}");
                    Console.WriteLine($"\n=======================================");
                    total2 = Decimal.Add(dineroGanadoAnual,total2);
                    dineroGanadoAnual = 0;
                    accionesAnuales = 0;
                    year = cd.Fecha.Year;
                }

                acciones = Decimal.Add(Decimal.Round(Decimal.Divide(inversionFinal, cd.Apertura), 3), acciones);
                accCompradasMes = Decimal.Round(Decimal.Divide(inversionFinal, cd.Apertura), 3);
                dineroGanadoAnual = Decimal.Add(Decimal.Round(Decimal.Multiply(accCompradasMes, Convert.ToDecimal(29.17)), 3), dineroGanadoAnual);
                dineroGanadoMes = Decimal.Round(Decimal.Multiply(accCompradasMes, Convert.ToDecimal(29.17)), 3);
                accionesAnuales = Decimal.Add(accCompradasMes, accionesAnuales);


                Console.WriteLine($"\n------------------------------------");
                Console.WriteLine($"Número de acciones Compradas: {accCompradasMes}");
                Console.WriteLine($"Dinero generado este mes a 29,17€: {dineroGanadoMes}");
                Console.WriteLine($"Número de acciones Totales acumuladas: {acciones}");
                Console.WriteLine($"Fecha {cd.Fecha} y precio de la acción de apertura: {cd.Apertura}");
            }

            dineroGanadoAnual2 = Decimal.Round(Decimal.Multiply(accionesAnuales, Convert.ToDecimal(29.17)), 3);
            Console.WriteLine($"\n=======================================");
            //Console.WriteLine($"Dinero sacado en {year}: {dineroGanadoAnual}");
            Console.WriteLine($"Acciones totales en {year}: {accionesAnuales}");
            Console.WriteLine($"Dinero ganado en {year}: {dineroGanadoAnual2}");
            Console.WriteLine($"\n=======================================");
            total2 = Decimal.Add(dineroGanadoAnual,total2);

            CotizationDay ultimoDiaCotizacion = new CotizationDay();

            foreach(CotizationDay cd in ListadoFinal) {
                if(DateTime.Compare(cd.Fecha, fechaVenta) == 0) {
                    ultimoDiaCotizacion = cd;
                    break;
                }
            }

            Console.WriteLine($"\n---------------MOMENTO DE VENTA FINAL---------------------");
            //Console.WriteLine($"Total acciones: {acciones}");
            Console.WriteLine($"Fecha de venta: {ultimoDiaCotizacion.Fecha}");
            Console.WriteLine($"Precio Cierre: {ultimoDiaCotizacion.Cierre}");
            Console.WriteLine($"TOTAL: {total2}");

            return Decimal.Round(Decimal.Multiply(acciones, ultimoDiaCotizacion.Cierre), 3);
        }
        
        public DateTime UltimoDiaFichero() {
            return ListadoFinal.Last().Fecha;
        }
        
    }
}
