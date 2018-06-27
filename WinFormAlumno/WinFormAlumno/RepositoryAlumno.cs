using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormAlumno.Utils;

namespace WinFormAlumno {
    public class RepositoryAlumno : IRepositoryAlumno {
        public Alumno Alumno { get; set; }
        public Alumno AddAlumno(Alumno alumno, string path) {
            string strResultJson = JsonConvert.SerializeObject(alumno);
            FileManager fm = new FileManager();
            fm.CreateJsonToFile(strResultJson, path);
            strResultJson = fm.LoadJsonFile(path);
            return JsonConvert.DeserializeObject<Alumno>(strResultJson);
        }

    }
}
