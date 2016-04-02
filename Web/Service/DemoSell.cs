using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Service
{
    public class DemoSell
    {
        public double CalculateTax(double ProductPrice)
        {
            return ProductPrice*1.07;
        }
    }

}