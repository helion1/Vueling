using AutoMapper;
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

        private CovalcoEntities db;

        public AlumnoRepository() : this(new CovalcoEntities()) {
        }

        public AlumnoRepository(CovalcoEntities covalcoEntities) {
            this.db = covalcoEntities;
        }

        public AlumnoEntity Add(AlumnoEntity model) {
            try {
                Alumno alumno = null;
                var config = new MapperConfiguration(cfg => cfg.CreateMap<AlumnoEntity, Alumno>()
                   .ForMember(dest => dest.Timestamp, opt => opt.MapFrom(entity => DateTime.Today))
                   .ReverseMap()
                   .ForSourceMember(dest => dest.Timestamp, opt => opt.Ignore()));

                IMapper iMapper = config.CreateMapper();
                alumno = iMapper.Map<AlumnoEntity, Alumno>(model);

                Alumno alumnoConId = db.Alumno.Add(alumno);
                db.SaveChanges();

                return iMapper.Map<Alumno, AlumnoEntity>(alumnoConId);

            } catch (DbUpdateConcurrencyException e) {
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
            List<AlumnoEntity> ListaAlumnoEntity;
            List<Alumno> ListaAlumno;

            try{
                ListaAlumno = db.Alumno.ToList();
            }
            catch(Exception e) {
                throw new VuelingException("Mensaje error", e.InnerException);
            }

            var config = new MapperConfiguration(cfg => cfg.CreateMap<Alumno, AlumnoEntity>()
                .ForSourceMember(dest => dest.Timestamp, opt => opt.Ignore()));

            IMapper iMapper = config.CreateMapper();

            ListaAlumnoEntity = iMapper.Map<List<Alumno>, List<AlumnoEntity>>(ListaAlumno);

            return ListaAlumnoEntity;
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
