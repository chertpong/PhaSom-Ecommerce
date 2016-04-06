using Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Repository
{
    public interface IProductRepository
    {
        IQueryable<Product> Products { get; }
        IEnumerable<Product> GetAll();
        Product Get(int ProductID);
        Product Add(Product products);
        void Remove(int ProductID);
        bool Update(Product products);


    }
}
