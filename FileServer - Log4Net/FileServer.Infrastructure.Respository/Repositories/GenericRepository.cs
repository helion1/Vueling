using FileServer.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileServer.Infrastructure.Respository.Repositories {
    public abstract class GenericRepository<T> where T : EntityModel {
        protected List<T> Entities { get; set; }
        public T Insert(T entity) {
            entity.Id = GetNewId();
            Entities.Add(entity);
            return entity;
        }
        public GenericRepository() {
            Entities = new List<T>();
        }

        protected int GetNewId() {
            int lastid = 0;
            foreach (var entity in Entities) {
                lastid = lastid > entity.Id > lastid.Id : entity.Id;
            }
            return ++lastid;
        }

    }
}
