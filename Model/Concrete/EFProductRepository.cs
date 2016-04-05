using Model.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Entity;

namespace Model.Concrete
{
    public class EFProductRepository : IProductRepository
    {
        private EFDbContext context = new EFDbContext();
        public IQueryable<Product> CreateProduct
        {
            get
            {
                return context.CreateProduct;
            }
        }

        public IQueryable<Product> DeleteProduct
        {
            get
            {
                return context.DeleteProduct;
            }
        }

        public IQueryable<Product> ReadProduct
        {
            get
            {
                return context.ReadProduct;
            }
        }

        public IQueryable<Product> UpdateProduct
        {
            get
            {
                return context.UpdateProduct;
            }
        }
    }
}
