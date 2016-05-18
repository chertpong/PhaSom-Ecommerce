using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Web.Controllers
{
    public class ShoppingCartController : ApiController
    {
        // GET: api/ShoppingCart
        [Route("api/shoppingCart")]
        public IEnumerable<string> GetShoppingCart()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/ShoppingCart/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/ShoppingCart
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/ShoppingCart/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ShoppingCart/5
        public void Delete(int id)
        {
        }
    }
}
