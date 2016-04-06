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
        private IProductRepository repository;

        public ProductController(IProductRepository repositoryProduct)
        {
            this.repository = repositoryProduct;
        }

        public IEnumerable<Product> GetAllProduct()
        {
            return repository.GetAll();
        }

        public Product GetProduct(int ProductID)
        {
            Product product = repository.Get(ProductID);
            if (product == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return product;
        }

        public Product PostProduct(Product products)
        {
            Product product = repository.Add(products);
            return product;
        }
    }
}