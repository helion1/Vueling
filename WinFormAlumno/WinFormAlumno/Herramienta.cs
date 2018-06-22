using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormAlumno {
    public class Herramienta : IHerramienta {
        public Alumno alumno { get; set; }
        public string AddAlumno(Alumno alumno) {
            string strResultJson = JsonConvert.SerializeObject(alumno);
            File.WriteAllText(@"alumno.json", strResultJson);
            return strResultJson;
        }

        public Alumno LoadAlumno() {
            string strReadJson = File.ReadAllText(@"alumno.json");
            return JsonConvert.DeserializeObject<Alumno>(strReadJson);
        }
    }
}
