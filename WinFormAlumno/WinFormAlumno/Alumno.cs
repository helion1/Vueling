using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormAlumno {
    public class Alumno{
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Dni { get; set; }

        public Alumno(int id, string nombre, string apellidos, string dni) {
            this.Id = id;
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.Dni = dni;
        }

        public Alumno() {
        }

        public override bool Equals(object obj) {
            Alumno a = (Alumno)obj;
            return this.Nombre == a.Nombre
                && this.Apellidos == a.Apellidos
                && this.Dni == a.Dni;
        }

        public override int GetHashCode() {
            var hashCode = -2093283606;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Nombre);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Apellidos);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Dni);
            return hashCode;
        }

        public override string ToString() {
            return  this.Id.ToString()+
                    this.Nombre+
                    this.Apellidos+
                    this.Dni;
        }

        public string ToJson() {
            return JsonConvert.SerializeObject(this);
        }

    }
}
