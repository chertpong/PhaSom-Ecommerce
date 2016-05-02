using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Web.Controllers
{
    [Authorize(Roles = "Admin")]
    public class RoleController : ApiController
    {
        // GET: api/Role
        public IEnumerable<string> Get()
        {
            throw new NotImplementedException();
        }

        // GET: api/Role/5
        public string Get(int id)
        {
            throw new NotImplementedException();
        }

        // POST: api/Role
        public void Post([FromBody]string value)
        {
            throw new NotImplementedException();
        }

        // PUT: api/Role/5
        public void Put(int id, [FromBody]string value)
        {
            throw new NotImplementedException();
        }

        // DELETE: api/Role/5
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
