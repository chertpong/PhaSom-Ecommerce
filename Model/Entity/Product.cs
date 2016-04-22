using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entity
{
   public class Product
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string Thumbnail { get; set; }
        public List<string> Tags { get; set; }
        public int Amount { get; set; }

    }
}
