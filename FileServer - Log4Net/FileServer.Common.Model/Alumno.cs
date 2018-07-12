using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileServer.Common.Model {
    public class Alumno {

        #region Atributos
        public int IdAlumno { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Dni { get; set; }
        #endregion

        #region Constructores
        public Alumno() {

        }

        public Alumno(int idAlumno, string nombre, string apellidos, string dni) {
            IdAlumno = idAlumno;
            Nombre = nombre;
            Apellidos = apellidos;
            Dni = dni;
        }
        #endregion

        #region Métodos
        public override bool Equals(object obj) {
            Alumno a = (Alumno)obj;
            return this.Nombre == a.Nombre
                && this.Apellidos == a.Apellidos
                && this.Dni == a.Dni;
        }

        public override int GetHashCode() {
            var hashCode = -2093283606;
            hashCode = hashCode * -1521134295 + IdAlumno.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Nombre);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Apellidos);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Dni);
            return hashCode;
        }
        #endregion



    }
}
