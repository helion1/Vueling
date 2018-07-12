using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormAlumno.Contracts {
    public interface IFileManager {
        void CreateJsonToFile(string path, string json);
        string LoadJsonFile(string path);
    }
}
