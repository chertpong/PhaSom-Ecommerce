using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Dto;
using Model.Entity;
using Model.Repository;

namespace Model.Service
{
   public class OrderService
   {
       private readonly IOrderRepository _orderRepository;

       public OrderService(IOrderRepository orderRepository)
       {
           this._orderRepository = orderRepository;
       }

        public void Create(Order o)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
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

       public List<Order> GetAllFrom(DateTime startDate)
       {
            throw new NotImplementedException();
        }

       public List<Order> GetAllWithin(DateTime startDate, DateTime endDate)
       {
            throw new NotImplementedException();
        }

       public Order MakeOrder(ShoppingCart shoppingCart,string userId,TransportationType transportationType,Payment payment,string note)
       {
            throw new NotImplementedException();
        }

    }
}
