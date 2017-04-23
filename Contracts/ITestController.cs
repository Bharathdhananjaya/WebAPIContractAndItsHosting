using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Core;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Web;
using System.Web.Routing;
using System.Web.Http;
using System.Net;
using System.Net.Http;



namespace Contracts
{
    public interface ITestFrameworkService
    {
        /// <summary>
        /// Test Get method
        /// </summary>
        /// <param name="id">The id.</param>
        /// <param name="context">The context.</param>
        /// <returns>Test Entity</returns>
        [WebInvoke(Method = "GET")]
        [Route("get/{id}")]           
        [OperationContract]
        TestEntity[] TestGet(string id, CallContext context);

        /// <summary>
        /// Test Post Method
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <param name="context">The context.</param>
        /// <returns>Post Result</returns>
        [WebInvoke(Method = "POST")]
        [Route("post")]        
        [OperationContract]
        string TestPost(TestEntity[] entity, CallContext context);

        /// <summary>
        /// Test Put Method
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <param name="context">The context.</param>
        /// <returns>Put Result</returns>
        [WebInvoke(Method = "PUT")]
        [Route("put")]        
        [OperationContract]
        string TestPut(TestEntity entity, CallContext context);

        /// <summary>
        /// Test Delete Method
        /// </summary>
        /// <param name="id">The id.</param>
        /// <param name="context">The context.</param>
        /// <returns>Delete Test</returns>
        [WebInvoke(Method = "DELETE")]
        [Route("delete/{id}")]  
        [OperationContract]
        string TestDelete(string id, CallContext context);

    }
}
