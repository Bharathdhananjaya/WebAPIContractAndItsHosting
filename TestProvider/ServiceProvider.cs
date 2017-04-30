using Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts;
using TestRepository;
using MongoRepository;

namespace TestProvider
{
    public class ServiceProvider : IProvider  
    {
        public List<object> GetListOfItems()
        {
            var items = new SQLRepository<object>().GetAll();
            var MongoCollection = new MongoRepository<Object>().GetAll();
            return items.ToList();
        }


        public object Get(string Id)
        {
            var item = new SQLRepository<object>().Get(Id);
            return item;
        }

    }
}
