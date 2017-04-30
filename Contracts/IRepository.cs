using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IRepository<T> : IDisposable where T : class
    {
        IEnumerable<T> GetAll();
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        T Get(string Id);
    }
}
