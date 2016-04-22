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
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string Thumbnail { get; set; }
        public List<string> Tags { get; set; }
        public int Amount { get; set; }

       /*public Product(long Id , string Name , double Price , string Description , string Thumbnail, List<string> Tags , int Amount)  //Constructor Method
       {
           this.Id = Id;
           this.Name = Name;
           this.Price = Price;
           this.Description = Description;
           this.Thumbnail = Thumbnail;
           this.Tags = Tags;
           this.Amount = Amount;
       }*/
    }
}
