using SOLID.SingleResponsability.Off;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SingleResponsability.On {
    public static class Gasolinera {
        public static bool LlenarDeposito(bool DepositoLleno) {
            if (DepositoLleno == false) {
                DepositoLleno = true;
                return true;
            }
            return false;
        }
    }
}
