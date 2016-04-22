using Model.Entity;
using System.Collections.Generic;

namespace Model.Repository
{
    public interface IProductRepository
    {
        List<Product> GetAll();
        Product Get(int productId);
        Product Add(Product products);
        void Remove(int productId);
        Product Update(Product products);


    }
}
