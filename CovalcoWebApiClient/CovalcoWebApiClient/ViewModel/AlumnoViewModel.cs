using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovalcoWebApiClient.ViewModel {
    public class AlumnoViewModel {
        public AlumnoViewModel() {
        }
        public AlumnoViewModel(string nombre, string apellidos, string dni) {
            Nombre = nombre;
            Apellidos = apellidos;
            Dni = dni;
        }

        public AlumnoViewModel(int id, string nombre, string apellidos, string dni) {
            Id = id;
            Nombre = nombre;
            Apellidos = apellidos;
            Dni = dni;
        }



        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Dni { get; set; }

    }
}
