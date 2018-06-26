using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormAlumno {
    public class RepositoryAlumno : IRepositoryAlumno {
        public Alumno Alumno { get; set; }
        public Alumno AddAlumno(Alumno alumno) {
            string strResultJson = JsonConvert.SerializeObject(alumno);
            File.WriteAllText(@"alumno.json", strResultJson);
            strResultJson = File.ReadAllText(@"alumno.json");
            return JsonConvert.DeserializeObject<Alumno>(strResultJson);
        }

    }
}
