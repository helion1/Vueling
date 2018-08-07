using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VuelingExamen.Infrastructure.Repository.Contracts {
    public interface IRepository<T> {
        T Add(T model);
        IEnumerable<T> GetAll();

    }
}
