using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Entity;

namespace Model.Dto
{
    public class ProductDto
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string Thumbnail { get; set; }
        public List<string> Tags { get; set; }
        public int Amount { get; set; }

        public Product GetProduct()
        {
            return new Product {Id = Id, Name = Name, Price = Price, Description = Description, Thumbnail = Thumbnail, Tags = Tags, Amount = Amount};
        }
    }
}
