using FileServer.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileServer.Infrastructure.Respository.Contracts {
    public interface IAlumnoRepository {
        Alumno Add(Alumno alumno);
    }
}
