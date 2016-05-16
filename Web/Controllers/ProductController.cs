using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Filters;
using Model.Dto;
using Model.Repository;
using Model.Entity;
using Model.Service;
using Ninject.Infrastructure.Language;
using Web.Models;
using Web.Response;

namespace Web.Controllers
{
    [MyExceptionFilter]
    public class ProductController : ApiController
    {
        
        
        private readonly ProductService _productService;

        public ProductController(ProductService productService )
        {
            this._productService = productService;
        }
        // GET: api/Product
        public List<Product> GetAll()
        {
            
             return _productService.GetAll();
        }

        // GET: api/Product/5
        public Product Get(int id)
        {
            if (_productService.GetById(id) == null)
            {
                {
                    var message = string.Format("Product with id = {0} not found", id);
                    throw new HttpResponseException(
                        Request.CreateErrorResponse(HttpStatusCode.NotFound, message));
                }
            }
            return _productService.GetById(id);
        }

        // POST: api/Product
        [HttpPost]
        public dynamic Post(ProductDto product)
        {
            if (!ModelState.IsValid)
            {
                var allErrors = ModelState.Values.SelectMany(v => v.Errors);
                var error = new ErrorMessageResult {Field = "Name", Message = "Name is required"};
                var errorList = new List<ErrorMessageResult> {error};
                return Request.CreateResponse(HttpStatusCode.BadRequest, errorList);
            }
             _productService.Create(product.GetProduct());
            return Request.CreateResponse(HttpStatusCode.OK, new SuccessResponse {Message="Success"} );

        }

        // PUT: api/Product/5
        public void Put(int id, [FromBody]string value)
        {
            //TODO : implement
            throw new NotImplementedException();

        }

        // DELETE: api/Product/5
        public void Delete(int id)
        {
            _productService.Delete(id);
        }
    }
}
