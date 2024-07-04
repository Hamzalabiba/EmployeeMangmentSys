using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositroy
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(Guid Id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}

