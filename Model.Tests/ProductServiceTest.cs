// <copyright file="ProductServiceTest.cs">Copyright ©  2016</copyright>
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model.Entity;
using Model.Service;

namespace Model.Service.Tests
{
    /// <summary>This class contains parameterized unit tests for ProductService</summary>
    [PexClass(typeof(ProductService))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class ProductServiceTest
    {
        /// <summary>Test stub for Create(Product)</summary>
        [PexMethod]
        public void CreateTest([PexAssumeUnderTest]ProductService target, Product p)
        {
            target.Create(p);
            // TODO: add assertions to method ProductServiceTest.CreateTest(ProductService, Product)
        }
    }
}
