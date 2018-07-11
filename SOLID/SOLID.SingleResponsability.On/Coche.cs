using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SingleResponsability.Off {
    public class Coche {
        public Coche() {
            this.DepositoLleno = false;
        }

        public int Id { get; set; }
        public bool DepositoLleno { get; set; }
        
        public bool HayGasolina(int Id) {
            return this.DepositoLleno;
        }

        public bool LlenarDeposito(int Id) {
            if (this.DepositoLleno == false) {
                this.DepositoLleno = true;
                return true;
            }
            return false;
        }

    }
}
