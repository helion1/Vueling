using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos {
    public class Adder {

        public event EventHandler<MultipleOfFiveEventArgs> OnMultipleOfFiveReached;

        public int Add(int x, int y) {
            int iSum = x + y;

            if ((iSum % 5 == 0) && (OnMultipleOfFiveReached != null)) {

                OnMultipleOfFiveReached(this, new MultipleOfFiveEventArgs(iSum));
            }
            return iSum;
        }

    }
}
