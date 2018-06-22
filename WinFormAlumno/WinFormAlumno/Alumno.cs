using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormAlumno {
    public class Alumno : IAlumno{
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string dni { get; set; }

        public Alumno(int id, string nombre, string apellidos, string dni) {
            this.id = id;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.dni = dni;
        }

        public Alumno() {

        }

        public override bool Equals(object obj) {
            Alumno a = (Alumno)obj;
            return this.id == a.id 
                && this.nombre == a.nombre
                && this.apellidos == a.apellidos
                && this.dni == a.dni;
        }
    }
}
