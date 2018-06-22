using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormAlumno {
    public interface IHerramienta {
        string AddAlumno(Alumno alumno);
        Alumno LoadAlumno();
    }
}
