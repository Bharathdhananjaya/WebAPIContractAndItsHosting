using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IProvider
    {
        List<object> GetListOfItems();

        object Get(string id);
    }
}
