using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Dynamic;

namespace MongoRepository
{
    public class MongoRepository<T> :  IRepository<T> where T : class
    {
        MongoServer server; 
        
        public MongoRepository()
        {
            server= MongoServer.Create("mongodb://localhost:27017");
            server.Connect();
           
        }

        public IEnumerable<T> GetAll()
        {
            List<object> items = new List<object>();
            var db = server.GetDatabase("Test");
            var collection = db.GetCollection<T>("Employee");

            return collection.FindAll().AsQueryable<T>();
        }

        public void Add(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }

        public T Get(string Id)
        {
            throw new NotImplementedException();
        }

        public T Get(int Id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
