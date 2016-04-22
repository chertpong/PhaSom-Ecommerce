using System.Collections.Generic;
using Model.Entity;
using Model.Repository;
using Moq;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(Web.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(Web.App_Start.NinjectWebCommon), "Stop")]

namespace Web.App_Start
{
    using System;
    using System.Web;

    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Web.Common;

    public static class NinjectWebCommon 
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }
        
        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }
        
        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
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

            kernel.Bind<IProductRepository>().ToConstant(mock.Object);
        }        
    }
}
