using Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts;
using TestRepository;


namespace TestProvider
{
    public class ServiceProvider<T> : IProvider<T> where T: class 
    {
        public List<T> GetListOfItems()
        {
            var repository = new SQLRepository<T>().GetAll();
            return repository.ToList();
        }

    }
}
