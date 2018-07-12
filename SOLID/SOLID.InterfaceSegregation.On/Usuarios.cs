using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.InterfaceSegregation.Off {
    public interface IUsuario {
        void Acceder();
    }

    public interface IModerador {
        void Acceder();
        void Moderar();
    }

    public interface INoRegistrado {
        void Registrarse(string datos);
    }


    public class Usuario : IUsuario {
        public string Nombre { get; set; }
        public void Acceder() {
        }
    }

    public class Moderador : IModerador, IUsuario {
        public string Nombre { get; set; }
        public void Acceder() { }
        public void Moderar() { }

    }

    public class NoRegistrado : INoRegistrado {
        public void Registrarse(string datos) { }
    }

}

    

