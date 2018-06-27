using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormAlumno.Contracts {
    interface IFileManager {
        bool createJsonToFile(string path, string json); 
    }
}
