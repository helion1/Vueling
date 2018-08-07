using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vueling.Common.Layer;
using VuelingExamen.Common.Layer.Models;
using VuelingExamen.Infrastructure.Repository;
using VuelingExamen.Infrastructure.Repository.Contracts;

namespace VuelingExamen.Application.Services {
    public class Model1Service {
        private readonly IRepository<Model1> model1Repository;

        public Model1Service() : this(new Model1Repository()) { }

        public Model1Service(Model1Repository model1Repository) {
            this.model1Repository = model1Repository;
        }


        public Model1 Add(Model1 model1) {
            try {
                Model1 model1Insertado = null;

                model1Insertado = model1Repository.Add(model1);

                return model1Insertado;

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

        public IEnumerable<Model1> Get() {
            IEnumerable<Model1> ListaModel1;
            
            try {
                ListaModel1 = model1Repository.GetAll();
                return ListaModel1;

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
