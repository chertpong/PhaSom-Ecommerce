using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Web.Models;
using Microsoft.AspNet.Identity.Owin;
using Web.Infrastructure;

namespace Web.Controllers
{
    [Authorize(Roles = "Admin")]
    public class RoleController : ApiController
    {
        private readonly ApplicationDbContext _context;
        private ApplicationUserManager _userManager;
        private ApplicationRoleManager _roleManager;

        public ApplicationUserManager UserManager
        {
            get { return _userManager ?? Request.GetOwinContext().GetUserManager<ApplicationUserManager>(); }
            private set { _userManager = value; }
        }

        public ApplicationRoleManager RoleManager
        {
            get { return _roleManager ?? Request.GetOwinContext().GetUserManager<ApplicationRoleManager>(); }
            private set { _roleManager = value; }
        }

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
        public bool Post([FromBody]RoleViewModels.CreateRoleViewModel role)
        {
            // TODO : Add Exception handler
            _context.Roles.Add(new IdentityRole() {Name = role.Name});
            return _context.SaveChanges() > 0;
        }

        // PUT: api/Role/5
        public bool Put(string id, [FromBody]string name)
        {
            // TODO : Add Exception handler
            var role = _context.Roles.First(r => r.Id.Equals(id));
            role.Name = name;
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
        [Route("api/Role/AddRoleToUser")]
        [HttpPost]
        public async Task<bool> AddRoleToUser([FromBody]RoleViewModels.AddRoleToUserViewModel model)
        {
            var role = await this.RoleManager.FindByNameAsync(model.RoleName);
            var user = await this.UserManager.FindByEmailAsync(model.Username);
            System.Diagnostics.Debug.WriteLine(role.Name);
            var result = await this.UserManager.AddToRolesAsync(user.Id, new string[] { role.Name });
            return result.Succeeded;
        }
    }
}
