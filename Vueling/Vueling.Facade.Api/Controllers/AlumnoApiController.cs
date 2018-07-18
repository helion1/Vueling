using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Vueling.Application.Dto;
using Vueling.Application.Services.Contracts;
using Vueling.Application.Services.Service;

namespace Vueling.Facade.Api.Controllers
{
    public class AlumnoApiController : ApiController{

        private readonly IService<AlumnoDto> alumnoService;

        public AlumnoApiController() : this(new AlumnoService()) { }

        public AlumnoApiController(AlumnoService alumnoService) {
            this.alumnoService = alumnoService;
        }


        // GET: api/AlumnoApi
        public IQueryable<AlumnoDto> Get(){
            return alumnoService.Get();
        }

        // GET: api/AlumnoApi/5
        public AlumnoDto Get(int id){
            return alumnoService.GetById(id);
        }

        // POST: api/AlumnoApi
        public int Post(AlumnoDto alumnoDto) {
            return alumnoService.Add(alumnoDto).Id;
        }

        // PUT: api/AlumnoApi/5
        public int Put(int id, AlumnoDto alumnoDto){
            return alumnoService.Update(alumnoDto).Id;
        }

        // DELETE: api/AlumnoApi/5
        public int Delete(int id){
            return alumnoService.Remove(id);
        }
    }
}
