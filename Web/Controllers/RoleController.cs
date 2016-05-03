using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.AspNet.Identity.EntityFramework;
using Web.Models;

namespace Web.Controllers
{
    [Authorize(Roles = "Admin")]
    public class RoleController : ApiController
    {
        private readonly ApplicationDbContext _context;

        public RoleController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Role
        public List<IdentityRole> Get()
        {
            return _context.Roles.ToList();
        }

        // GET: api/Role/5
        public IdentityRole Get(string id)
        {
            // TODO : Add NotFoundException annotation handler
            return _context.Roles.Find(id);
        }

        // POST: api/Role
        public bool Post([FromBody]string name)
        {
            // TODO : Add Exception handler
            _context.Roles.Add(new IdentityRole() {Name = name});
            return _context.SaveChanges() > 0;
        }

        // PUT: api/Role/5
        public bool Put(string id, [FromBody]IdentityRole role)
        {
            // TODO : Add Exception handler
            _context.Entry(role).State = EntityState.Modified;
            return _context.SaveChanges() > 0;
        }

        // DELETE: api/Role/5
        public void Delete(string id)
        {
            // TODO : Add Exception annotation handler
            var role = _context.Roles.First(r => r.Id.Equals(id));
            _context.Roles.Remove(role);
        }
    }
}
