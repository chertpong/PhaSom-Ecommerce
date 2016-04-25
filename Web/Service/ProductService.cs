using Model.Entity;
using Model.Repository;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Service
{
    public class ProductService
    {
        IProductRepository Prepository;

        public ProductService(IProductRepository x)
        {
            this.Prepository = x;
        }
        public List<Product> SearchProductbyName(String ProductName) {

            List<Product> ProductList = Prepository.GetAll().Where(p => p.Name.Contains(ProductName)).ToList<Product>();

            return ProductList;
        }
        public List<Product> SearchProductByTag(String ProductTag)
        {

            List<Product> ProductList = Prepository.GetAll().Where(p => p.Tags.Contains(ProductTag)).ToList<Product>();

            return ProductList;
        }
    }
}