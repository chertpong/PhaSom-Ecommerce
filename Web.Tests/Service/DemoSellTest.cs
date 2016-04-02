using System;
using System.Text;
using System.Collections.Generic;
using Web.Service;
using NUnit.Framework;

namespace Web.Tests.Service
{
    /// <summary>
    /// Summary description for DemoSellTest
    /// </summary>
    /// 
    public class DemoSellTest
    {
        public DemoSellTest()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        /*[TestMethod]
        public void CalculateTaxShouldPassWhenInputIsCorrect()
        {
            DemoSell d = new DemoSell();
            Assert.AreEqual(106.00, d.CalculateTax(100.00));
        }*/

        [TestCase()]
        public void ArrayTest()
        {
            int[] array = new int[] { 1, 2, 3 };
            Assert.That(array, Has.Exactly(1).EqualTo(3));
            Assert.That(array, Has.Exactly(2).GreaterThan(1));
            Assert.That(array, Has.Exactly(3).LessThan(100));
        }
    }
}
