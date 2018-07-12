using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.InterfaceSegregation.Off {
    public interface IUsuario {
        void Acceder();
        void Moderar();
        void Registrarse(string datos);
    }


    public class Usuario : IUsuario {
        public string Nombre { get; set; }
        public void Acceder() {
        }
        public void Moderar() {
            throw new NotImplementedException();
        }
        public void Registrarse(string datos) {
            throw new NotImplementedException();
        }
    }

    public class Moderador : IUsuario {
        public string Nombre { get; set; }
        public void Acceder() { }
        public void Moderar() { }

        public void Registrarse(string datos) {
            throw new NotImplementedException();
        }
    }

    public class NoRegistrado : IUsuario {
        public void Acceder() {
            throw new NotImplementedException();
        }

        public void Moderar() {
            throw new NotImplementedException();
        }

        public void Registrarse(string datos) { }
    }

}

    

