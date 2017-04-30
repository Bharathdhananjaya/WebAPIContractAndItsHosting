using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts;
using Dapper;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;

namespace TestRepository
{
    public class SQLRepository<T> : IRepository<T> where T : class
    {

        private readonly string connectionString;

        public SQLRepository()
        {
            connectionString = "Server=LENOVO-PC;Database=Test;Trusted_Connection=True;";
        }

        public IEnumerable<T> GetAll()
        {
            using (var db = new SqlConnection(connectionString))
            {
               return  db.Query<T>("Select * From Employee").ToList();
            }
        }

        public T Get(string Id)
        {
            using (var db = new SqlConnection(connectionString))
            {
                return db.Query<T>("Select * From Employee WHERE Id = @Id", new { Id }).SingleOrDefault();
            }
        }

        public void  Add(T entity)
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


        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
