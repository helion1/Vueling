using System;
using System.Collections.Generic;
using System.Text;
using Zara.Reto0.Common.Model;

namespace Zara.Reto0.Utils
{
    public interface ICotizationDayRepository {
        List<CotizationDay> GenerarListado();
        decimal Ganancia(decimal inversionInicial, decimal retencion, DateTime fechaVenta);
        DateTime UltimoDiaFichero();
    }
}
