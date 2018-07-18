using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Vueling.Application.Dto;
using Vueling.Application.Services.Service;

namespace Vueling.Facade.Api.Controllers
{
    public class AlumnoApiController : ApiController
    {
        AlumnoService alumnoService = new AlumnoService();
        // GET: api/AlumnoApi
        public List<AlumnoDto> Get(){
            return alumnoService.GetAll();
        }

        // GET: api/AlumnoApi/5
        public AlumnoDto Get(int id){
            return alumnoService.GetById(id);
        }

        // POST: api/AlumnoApi
        public AlumnoDto Post(AlumnoDto alumnoDto) {
            return alumnoService.Add(alumnoDto);
        }

        // PUT: api/AlumnoApi/5
        public AlumnoDto Put(int id, AlumnoDto alumnoDto){
            return alumnoService.Update(alumnoDto);
        }

        // DELETE: api/AlumnoApi/5
        public void Delete(int id){
            alumnoService.Remove(id);
        }
    }
}
