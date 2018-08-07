using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AutofacBMW.Program;

namespace AutofacBMW {
    public class HondaAutoService : IAutoService {
        public void GetService() {
            Console.WriteLine(ResourceAutofacBMW.HondaAutoServiceGetService);
        }
    }
}
