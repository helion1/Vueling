using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vueling.Application.Services.Contracts {
    public interface IService<T> {
        T Add(T model);
        T Update(T model);
        IQueryable<T> Get();
        int Remove(int id);
        T GetById(int id);

    }
}
