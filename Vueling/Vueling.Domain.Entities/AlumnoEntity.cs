using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Vueling.Domain.Entities {
    public class AlumnoEntity : DbContext {
        public AlumnoEntity() {
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Dni { get; set; }
        public int Edad { get; set; }
        public DateTime FechaNacimiento { get; set; }

    }
}
