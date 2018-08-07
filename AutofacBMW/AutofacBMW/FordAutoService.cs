using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AutofacBMW.Program;

namespace AutofacBMW {
    public class FordAutoService : IAutoService {
        public void GetService() {
            Console.WriteLine(ResourceAutofacBMW.FordAutoServiceGetService);
        }
    }
}
