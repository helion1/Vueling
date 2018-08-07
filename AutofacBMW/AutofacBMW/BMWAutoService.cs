using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AutofacBMW.Program;

namespace AutofacBMW {
    public class BMWAutoService : IAutoService {
        public void GetService() {
            Console.WriteLine(ResourceAutofacBMW.BMWAutoServiceGetService);
        }
    }
}
