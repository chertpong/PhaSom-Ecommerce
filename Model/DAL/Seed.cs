using Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DAL
{
    public class StoreInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<StoreContext>
    {
        protected override void Seed(StoreContext context)
        {
            var products = new List<Product>
            {
                new Product(1,"Rice",25.00,"Thailand people eat rice berry","12345",new List<string> {"EatType"}, 10),
                new Product(2,"Shampoo",50.00,"Washing Hair","5463",new List<string> {"Usetype"}, 19),
                new Product(3,"Coffee",1500.00,"Drink for Energy","1777",new List<string> {"EatType"}, 30),
                new Product(4,"KraTiam",60.00,"Cooking Material","1777",new List<string> {"EatType"}, 16),
                new Product(5,"Bag",300.00,"Keep everthing inside","1777",new List<string> {"Usetype"}, 5)

            };

            products.ForEach(s => context.Products.Add(s));
            context.SaveChanges();
            {
            }
        }

    }
}