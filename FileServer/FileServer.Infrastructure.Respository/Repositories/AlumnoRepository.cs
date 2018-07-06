
using FileServer.Common.Model;
using FileServer.Infrastructure.Respository.Contracts;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormAlumno.Utils;

namespace FileServer.Infrastructure.Respository.Repositories {
    public class AlumnoRepository : IAlumnoRepository {
        public Alumno Alumno { get; set; }

        public Alumno Add(Alumno alumno, string path) {
            if (alumno == null || path == null) throw new ArgumentNullException();

            string strResultJson = JsonConvert.SerializeObject(alumno);
            FileManager fm = new FileManager();
            fm.CreateJsonToFile(path, strResultJson);
            strResultJson = fm.LoadJsonFile(path);
            return JsonConvert.DeserializeObject<Alumno>(strResultJson);
        }
    
    }
}
