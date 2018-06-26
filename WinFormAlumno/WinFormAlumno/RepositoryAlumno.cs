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
            var path = Environment.GetEnvironmentVariable("ruta");

            string strResultJson = JsonConvert.SerializeObject(alumno);
            File.WriteAllText(@path, strResultJson);
            strResultJson = File.ReadAllText(@path);
            return JsonConvert.DeserializeObject<Alumno>(strResultJson);
        }

    }
}
