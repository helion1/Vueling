using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vueling.Domain.Entities;
using Vueling.Infrastructure.Repository.Contracts;
using Vueling.Infrastructure.Repository.DataModel;

namespace Vueling.Infrastructure.Repository.Repository {
    public class AlumnoRepository : IRepository<AlumnoEntity> {
        public AlumnoEntity Add(AlumnoEntity model) {
            throw new NotImplementedException();
        }

        public List<AlumnoEntity> GetAll() {
            throw new NotImplementedException();
        }

        public AlumnoEntity GetById(int id) {
            throw new NotImplementedException();
        }

        public int Remove(int id) {
            throw new NotImplementedException();
        }

        public AlumnoEntity Update(AlumnoEntity model) {
            throw new NotImplementedException();
        }
    }
}
