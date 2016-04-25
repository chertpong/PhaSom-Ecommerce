using System;
using Model.Entity;
using System.Collections.Generic;
using System.Linq;

namespace Model.Repository
{
    public interface IProductRepository : IDisposable
    {
        IEnumerable<Product> GetProducts();
        Product GetProductByID(int productId);
        void InsertProduct(Product product);
        void DeleteProduct(int productID);
        void UpdateProduct(Product product);
        void Save();


    }
}
