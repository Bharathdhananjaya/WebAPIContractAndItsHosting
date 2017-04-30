using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Contracts;
using TestProvider;
using Newtonsoft.Json.Serialization;
using System.Runtime.Serialization.Json;


namespace DOTNetHost.Controllers
{
    [System.ServiceModel.ServiceContractAttribute(Name = "TestFrameworkService")]
    public class TestController : ApiController
    {    
          /// <summary>
        /// The system identifier
        /// </summary>
        private const string SystemIdentifier = "(FW/ TestController)";      
        
        // GET: api/Test     
        public List<object> Get()
        {
            var provider = new ServiceProvider().GetListOfItems();
            return provider;         

        }

        // GET: api/Test/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Test
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Test/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Test/5
        public void Delete(int id)
        {
        }
    }
}
