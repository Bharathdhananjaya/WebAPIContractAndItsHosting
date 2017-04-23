using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts;

namespace MongoRepository
{
    public class MongoRepository<T> :  IRepository<T> where T : class
    {
        IEnumerable<T> IRepository<T>.GetAll()
        {
            throw new NotImplementedException();
        }

        void IRepository<T>.Add(T entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<T>.Delete(T entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<T>.Update(T entity)
        {
            throw new NotImplementedException();
        }

        T IRepository<T>.Get(int Id)
        {
            throw new NotImplementedException();
        }

        void IDisposable.Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
