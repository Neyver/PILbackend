using PILBackend.Collection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace PILBackend.Controllers
{
    [Authorize]
    [RoutePrefix("api/product")]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ProductController : ApiController
    {
        [HttpGet]
        public IHttpActionResult GetId(int id)
        {
            var customerFake = "customer-fake";
            return Ok(customerFake);
        }

        [HttpGet]
        public IHttpActionResult GetAll()
        {
            ProductCollection productCollection = new ProductCollection();
            productCollection.updateList();

            var customersFake = productCollection.products;
            return Ok(customersFake);
        }
    }
}
