using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vueling.Common.Layer;
using VuelingExamen.Common.Layer.Models;
using VuelingExamen.Infrastructure.Repository.Utils;

namespace VuelingExamen.Infrastructure.Repository.Repositories {
    public class Model1Repository {
        public Model2 Add(Model2 model) {
            try {
                string path = ResourceRepository.pathModel1JSON;
                string stringResultJson = JsonConvert.SerializeObject(model);

                FileManager.CreateJsonToFile(stringResultJson, path);
                stringResultJson = FileManager.LoadJsonFile(path);

                return JsonConvert.DeserializeObject<Model2>(stringResultJson);

            } catch (NotSupportedException e) {
                //YOU MUST LOG
                //log.error(e.Message)
                //log.error(e.Data)
                //log.error(e.StackTrace)
                throw new VuelingException(ResourceRepository.NotSuportedError, e);
            } catch (ObjectDisposedException e) {
                //YOU MUST LOG
                throw new VuelingException(ResourceRepository.ObjectDisposedError, e);
            } catch (InvalidOperationException e) {
                //YOU MUST LOG
                throw new VuelingException(ResourceRepository.InvalidOperationError, e);
            }
        }

        public IQueryable<Model1> GetAll() {
            throw new NotImplementedException();
        }
    }
}
