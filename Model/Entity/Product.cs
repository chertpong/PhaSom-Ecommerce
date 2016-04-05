using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entity
{
   public class Product
    {
        private long Id { get; set; }
        private string Name { get; set; }
        private double Price { get; set; }
        private string Description { get; set; }
        private string Thumbnail { get; set; }
        private List<string> Tags { get; set; }
        private int Amount { get; set; }
    }
}
