using Model.Repository;
using Moq;
using Ninject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Model.Entity;
using Model.Concrete;


namespace Web.Infrastructure
{
    public class NinjectControllerFactory : DefaultControllerFactory
    {
        private IKernel ninjectKernel;
        public NinjectControllerFactory() { ninjectKernel = new StandardKernel(); AddBindings(); }
        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            return controllerType == null ? null : (IController)ninjectKernel.Get(controllerType);
        }
        private void AddBindings()
        {
            var mock = new Mock<IProductRepository>();
            mock.Setup(m => m.GetAll()).Returns(new List<Product>
            {
                new Product { Id = 1,Name = "Rice",Price = 25.00,Description = "Thailand people eat rice berry",Thumbnail = "12345",Tags = new List<string> {"EatType"}, Amount = 10},
                new Product { Id = 2,Name = "Shampoo",Price = 50.00,Description = "Washing Hair",Thumbnail = "5463",Tags = new List<string> {"Usetype"},Amount = 19},
                new Product { Id = 3,Name = "Coffee",Price = 1500.00,Description = "Drink for Energy",Thumbnail = "1777",Tags = new List<string> {"EatType"},Amount = 30},
                new Product { Id = 4,Name = "KraTiam",Price = 60.00,Description = "Cooking Material",Thumbnail = "1788",Tags = new List<string> {"EatType"},Amount = 16},
                new Product { Id = 5,Name = "Bag",Price = 300.00,Description = "Keep everthing inside",Thumbnail = "1789",Tags = new List<string> {"Usetype"},Amount = 5}

            });
            
            ninjectKernel.Bind<IProductRepository>().ToConstant(mock.Object);

        }
    }
}