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
        IRepository<object> _repository;
        public ServiceProvider(IRepository<object> repository)
        {
            _repository = repository;
        }

        public List<object> GetListOfItems()
        {
            var items = _repository.GetAll();            
            return items.ToList();
        }


        public object Get(string Id)
        {
            var item = _repository.Get(Id);
            return item;
        }

    }
}
