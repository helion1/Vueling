using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vueling.Common.Layer;
using VuelingExamen.Common.Layer.Models;
using VuelingExamen.Infrastructure.Repository;
using VuelingExamen.Infrastructure.Repository.Repositories;

namespace VuelingExamen.Application.Services {
    public class Model2Service {
        public Model2 Add(Model2 model2) {
            try {
                Model2 model2Insertado = Infrastructure.Repository.Repositories.Model1Repository.Add(model2);

                return model2Insertado;

            } catch (NotSupportedException e) {
                //YOU MUST LOG
                throw new VuelingException(ResourceServices.NotSuportedError, e);

            } catch (ObjectDisposedException e) {
                //YOU MUST LOG
                throw new VuelingException(ResourceServices.ObjectDisposedError, e);

            } catch (InvalidOperationException e) {
                //YOU MUST LOG
                throw new VuelingException(ResourceServices.InvalidOperationError, e);

            }
        }

        public IEnumerable<Model2> Get() {
            IEnumerable<Model2> ListaModel2;

            try {
                ListaModel2 = Infrastructure.Repository.Repositories.Model1Repository.GetAll();
                return ListaModel2;

            } catch (NotSupportedException e) {
                //YOU MUST LOG
                throw new VuelingException(ResourceServices.NotSuportedError, e);

            } catch (ObjectDisposedException e) {
                //YOU MUST LOG
                throw new VuelingException(ResourceServices.ObjectDisposedError, e);

            } catch (InvalidOperationException e) {
                //YOU MUST LOG
                throw new VuelingException(ResourceServices.InvalidOperationError, e);

            }
        }
    }
}
