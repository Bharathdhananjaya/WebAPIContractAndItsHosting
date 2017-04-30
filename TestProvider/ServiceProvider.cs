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
    public class ServiceProvider : IProvider  
    {
        public List<object> GetListOfItems()
        {
            var repository = new SQLRepository<object>().GetAll();
            List<object> items = new List<object>();
            foreach(var item in repository)
            {
                items.Add(item[0]);
            }
            return items.ToList();
        }

    }
}
