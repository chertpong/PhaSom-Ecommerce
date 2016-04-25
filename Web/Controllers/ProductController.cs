﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Model.Repository;
using Model.Entity;
namespace Web.Controllers
{
    public class ProductController : ApiController
    {
        private IProductRepository _repository;

        public ProductController(IProductRepository repository)
        {
            this._repository = repository;
        }
        // GET: api/Product
        public IEnumerable<Product> Get()
        {
            return _repository.GetProducts();
        }

        // GET: api/Product/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Product
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Product/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Product/5
        public void Delete(int id)
        {
        }
    }
}
