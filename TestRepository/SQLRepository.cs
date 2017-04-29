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
        public SQLRepository()
        {
           

        }

        public IEnumerable<T> GetAll()
        {
            using (var db = new SqlConnection(ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString))
            {
               return  db.Query<T>("Select * From Employee").ToList();
            }
        }

        public T Get(int Id)
        {
            using (var db = new SqlConnection(ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString))
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
