using Model.Entity;
using Model.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Model.Service
{
    public class ProductService
    {
       private IProductRepository _productRepository;


        public ProductService(IProductRepository productRepository)
        {
            this._productRepository = productRepository;
        }
        public List<Product> SearchProductbyName(String productName) {

            List<Product> productList = _productRepository.GetProducts().Where(p => p.Name.Contains(productName)).ToList<Product>();

            return productList;
        }
        public List<Product> SearchProductByTag(String productTag)
        {

            List<Product> productList = _productRepository.GetProducts().Where(p => p.Tags.Contains(productTag)).ToList<Product>();

            return productList;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _productRepository.GetProducts();
        }
    }
}