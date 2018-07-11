using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Liskov.Off {
    public abstract class Ferrari {
        public int Velocidad { get; set; }
        public virtual void AcelerarAlMaximo() {
            this.Velocidad = 200;
        }
    }

    public class Ferrari1 : Ferrari {

        public override void AcelerarAlMaximo() {
            this.Velocidad = 250;
        }
    }

    public class Ferrari2 : Ferrari {
        public override void AcelerarAlMaximo() {
            this.Velocidad = 225;
        }
    }
}
