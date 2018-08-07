using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VuelingExamen.Infrastructure.Repository.Contracts;
using VuelingExamen.Infrastructure.Repository.Utils;
using System.IO;
using System.Reflection;
using VuelingExamen.Common.Layer.Models;
using Vueling.Common.Layer;
using VuelingExamen.Infrastructure.Repository.Repositories;

namespace VuelingExamen.Infrastructure.Repository {
    public class Model1Repository : IRepository<Model1> {
        public Model1Repository() {
        }

        public Model1 Add(Model1 model) {
            try {
                string path = ResourceRepository.pathModel1JSON;
                string stringResultJson = JsonConvert.SerializeObject(model);

                FileManager.CreateJsonToFile(stringResultJson, path);
                stringResultJson = FileManager.LoadJsonFile(path);

                return JsonConvert.DeserializeObject<Model1>(stringResultJson);

            } catch (NotSupportedException e) {
                //YOU MUST LOG
                //log.error(e.Message)
                //log.error(e.Data)
                //log.error(e.StackTrace)
                throw new VuelingException(ResourceRepository.NotSuportedError, e);
            } 
            catch (ObjectDisposedException e) {
                //YOU MUST LOG
                throw new VuelingException(ResourceRepository.ObjectDisposedError, e);
            }
            catch (InvalidOperationException e) {
                //YOU MUST LOG
                throw new VuelingException(ResourceRepository.InvalidOperationError, e);
            }
        }

        public IEnumerable<Model1> GetAll() {
            IEnumerable<Model1> ListaModel1;

            try {
                ListaModel1 = FileManager.LoadJsonFile
            } catch (Exception e) {
                throw new VuelingException("Mensaje error", e.InnerException);
            }

            var config = new MapperConfiguration(cfg => cfg.CreateMap<Alumno, AlumnoEntity>()
                .ForSourceMember(dest => dest.Timestamp, opt => opt.Ignore()));

            IMapper iMapper = config.CreateMapper();

            ListaAlumnoEntity = iMapper.Map<List<Alumno>, List<AlumnoEntity>>(ListaAlumno);

            return ListaAlumnoEntity;
        }
    }
}
