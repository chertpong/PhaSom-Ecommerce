using Model.Entity;
using System.Collections.Generic;
using System.Linq;

namespace Model.Repository
{
    public interface IProductRepository
    {
        IQueryable<Product> GetAll();
        Product Get(int productId);
        Product Add(Product products);
        void Remove(int productId);
        Product Update(Product products);


    }
}
