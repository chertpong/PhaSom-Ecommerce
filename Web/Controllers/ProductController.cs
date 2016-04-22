using Model.Entity;
using Model.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;
using System.Web.Http.Results;
using System.Web.Mvc;

namespace Web.Controllers
{
    public class ProductController : ApiController
    {
        private readonly IProductRepository _repository;

        public ProductController()
        {
        }

        public ProductController(IProductRepository repositoryProduct)
        {
            this._repository = repositoryProduct;
        }

        public IEnumerable<Product> GetAllProduct()
        {
            return _repository.GetAll();
        }

        public Product GetProduct(int productID)
        {
            var product = _repository.Get(productID);
            if (product == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return product;
        }

        public Product PostProduct(Product products)
        {
            var product = _repository.Add(products);
            return product;
        }
    }
}