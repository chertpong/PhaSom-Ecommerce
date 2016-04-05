using Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Repository
{
    interface IProductRepository
    {
        IQueryable<Product> Products { get; }

    }
}
