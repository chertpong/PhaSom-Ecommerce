using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Model.Entity;
using Model.Service;

namespace Web.Controllers
{
    public class TagController : ApiController
    {
        private readonly TagService _tagService;
        public TagController(TagService tagService)
        {
            this._tagService = tagService;
        }
        // GET: api/Tag
        public List<Tag> Get()
        {
            return _tagService.GetAll();
        }

        // GET: api/Tag/5
        public Tag Get(int id)
        {
            return _tagService.GetById(id);
        }

        // POST: api/Tag
        public void Post(Tag tag)
        {
            _tagService.Create(tag);
        }

        // PUT: api/Tag/5
        public void Put(int id, [FromBody]string value)
        {

        }

        // DELETE: api/Tag/5
        public void Delete(int id)
        {
            _tagService.Delete(id);
        }
    }
}
