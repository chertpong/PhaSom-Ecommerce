using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model.Entity;
using Model.Repository;
using Model.Service;
using Moq;
using NUnit.Framework;
using Web.Controllers;
using CollectionAssert = Microsoft.VisualStudio.TestTools.UnitTesting.CollectionAssert;

namespace Web.Tests.Controllers
{
    [TestClass]
    public class ProductControllerTest
    {
        private Mock<ProductService> productService;
        private Product p1;
        private Product p2;
        private Product p3;
        private Product p4;
        private Product p5;

        [SetUp]
        public void SetupMock()
        {
            p1 = new Product { Id = 1, Name = "Rice", Price = 30.00, Description = "For Eat", Thumbnail = "Abc1234.com", Tags = new List<string> { "Edible" }, Amount = 60 };
            p2 = new Product { Id = 2, Name = "Shampoo", Price = 60.00, Description = "For Use", Thumbnail = "AAA.com", Tags = new List<string> { "Usable" }, Amount = 50 };
            p3 = new Product { Id = 3, Name = "Coffee Bean", Price = 500.00, Description = "For Eat", Thumbnail = "DDD.com", Tags = new List<string> { "Edible" }, Amount = 60 };
            p4 = new Product { Id = 4, Name = "Rice Berry", Price = 70.00, Description = "For Eat", Thumbnail = "AaAA564.com", Tags = new List<string> { "Edible" }, Amount = 40 };
            p5 = new Product { Id = 5, Name = "Pan", Price = 500.00, Description = "For Use", Thumbnail = "Pan.com", Tags = new List<string> { "Usable" }, Amount = 70 };
            productService = new Mock<ProductService>();
            productService.Setup(se => se.GetAll()).Returns(new List<Product> { p1, p2, p3, p4, p5 });
        }
        [Test]
        public void Test_GetAllProduct()
        {
            //Add Unit Test
            ProductController pc = new ProductController(productService.Object);
            CollectionAssert.AreEqual(new List<Product> {p1,p2,p3,p4,p5}, pc.GetAll());
        }
    }
}
