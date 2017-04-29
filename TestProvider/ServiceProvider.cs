using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProvider
{
    public class ServiceProvider<T> where T : class
    {
        public List<T> GetListOfItems()
        {
            return new List<T>();
        }

    }
}
