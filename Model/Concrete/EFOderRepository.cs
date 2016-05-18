using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Entity;
using Model.Repository;

namespace Model.Concrete
{
   public  class EFOderRepository : IOrderRepository,IDisposable
    {
        private readonly EFDbContext _context;
        private bool _disposed;

        public EFOderRepository(EFDbContext context)
        {
            this._context = context;
            this._disposed = false;
        }
        public void Create(Order o)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public List<Order> Find(Predicate<Order> function)
        {
            throw new NotImplementedException();
        }

        public List<Order> GetAll()
        {
            throw new NotImplementedException();
        }

        public Order GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Order o)
        {
            throw new NotImplementedException();
        }
    }
}
