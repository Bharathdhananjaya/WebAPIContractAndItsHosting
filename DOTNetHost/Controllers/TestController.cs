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
using TestRepository;


namespace DOTNetHost.Controllers
{
    [System.ServiceModel.ServiceContractAttribute(Name = "TestFrameworkService")]
    [RoutePrefix("api/v1")]
    public class TestController : ApiController
    {    
          /// <summary>
        /// The system identifier
        /// </summary>
        private const string SystemIdentifier = "(FW/ TestController)";

        private IRepository<object> repository;
        

        // GET: api/Test     
        
        
        [Route("test/items")]
        [HttpGet]
        public List<object> Get()
        {
            var items = new ServiceProvider(new SQLRepository<object>()).GetListOfItems();
            return items;        

        }
        
        [Route("test/{filter}/items")]
        [HttpGet]
        public object GetListOfItems(string filter)
        {
            var item = new ServiceProvider(new SQLRepository<object>()).Get(filter);
            return item;
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
