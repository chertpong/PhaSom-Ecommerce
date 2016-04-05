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
            Mock<IProductRepository> mock = new Mock<IProductRepository>();
            mock.Setup(m => m.ReadProduct).Returns(new List<Product>
            {
                new Product(1,"Rice",25.00,"Thailand people eat rice berry","12345",new List<string> {"EatType"}, 10),
                new Product(2,"Shampoo",50.00,"Washing Hair","5463",new List<string> {"Usetype"}, 19),
                new Product(3,"Coffee",1500.00,"Drink for Energy","1777",new List<string> {"EatType"}, 30),
                new Product(4,"KraTiam",60.00,"Cooking Material","1777",new List<string> {"EatType"}, 16),
                new Product(5,"Bag",300.00,"Keep everthing inside","1777",new List<string> {"Usetype"}, 5)
            }.AsQueryable());
            
            ninjectKernel.Bind<IProductRepository>().To<EFProductRepository>();

        }
    }
}