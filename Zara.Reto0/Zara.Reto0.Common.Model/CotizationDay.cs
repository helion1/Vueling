using System;
using System.Collections.Generic;
using System.Text;

namespace Zara.Reto0.Common.Model
{
    public class CotizationDay{
        #region Constructors
        public CotizationDay(DateTime fecha, decimal apertura, decimal cierre) {
            Fecha = fecha;
            Apertura = apertura;
            Cierre = cierre;
        }

        public CotizationDay() {
        }
        #endregion

        #region Attributes
        public DateTime Fecha { get; set; }
        public decimal Apertura { get; set; }
        public decimal Cierre { get; set; }
        #endregion


        #region Common functions
        public override bool Equals(object obj) {
            var day = obj as CotizationDay;
            return day != null &&
                   Fecha == day.Fecha &&
                   Apertura == day.Apertura &&
                   Cierre == day.Cierre;
        }

        public override int GetHashCode() {
            var hashCode = 1333937782;
            hashCode = hashCode * -1521134295 + Fecha.GetHashCode();
            hashCode = hashCode * -1521134295 + Apertura.GetHashCode();
            hashCode = hashCode * -1521134295 + Cierre.GetHashCode();
            return hashCode;
        }
        #endregion
    }


}
