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
            var items = new ServiceProvider().GetListOfItems();
            return items;        

        }

        // GET: api/Test/5
        public HttpResponseMessage Get(string id)
        {
            var item = new ServiceProvider().Get(id);

            if(item == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }
            return Request.CreateResponse(HttpStatusCode.OK, item); 
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
