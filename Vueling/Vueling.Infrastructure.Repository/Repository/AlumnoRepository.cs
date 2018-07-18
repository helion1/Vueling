using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vueling.Common.Layer;
using Vueling.Domain.Entities;
using Vueling.Infrastructure.Repository.Contracts;
using Vueling.Infrastructure.Repository.DataModel;

namespace Vueling.Infrastructure.Repository.Repository {
    public class AlumnoRepository : IRepository<AlumnoEntity> {

        public AlumnoEntity Add(AlumnoEntity model) {
            try {
                throw new NotImplementedException();
            }  catch (DbUpdateConcurrencyException e) {
                //YOU MUST LOG
                //log.error(e.Message)
                //log.error(e.Data)
                //log.error(e.StackTrace)
                throw new VuelingException("Error de concurrencia.", e);
            } catch (DbUpdateException e) {
                //YOU MUST LOG
                throw new VuelingException("Error en la actualización", e);
            } catch (DbEntityValidationException e) {
                //YOU MUST LOG
                throw new VuelingException("Error la validación", e);
            } catch (NotSupportedException e) {
                //YOU MUST LOG
                throw new VuelingException("Error de soporte", e);
            } catch (ObjectDisposedException e) {
                //YOU MUST LOG
                throw new VuelingException("Error. El contexto o la conexión han sido eliminados", e);
            } catch (InvalidOperationException e) {
                //YOU MUST LOG
                throw new VuelingException("Error operacional", e);
            }
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
