using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Model.Repository;
using Model.Entity;
using Model.Service;
namespace Web.Controllers
{
    public class ProductController : ApiController
    {
        
        
        private ProductService _productService;

        public ProductController(ProductService productService )
        {
            this._productService = productService;
        }
        // GET: api/Product
        public IEnumerable<Product> GetAll()
        {
           
            return _productService.GetAllProducts();
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
