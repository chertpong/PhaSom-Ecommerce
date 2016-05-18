using System;
using System.Collections.Generic;
using Model.Entity;

namespace Model.Dto
{
    public class ShoppingCart
    {
        public DateTime Updated { get; set; }
        public List<SelectedProduct> SelectedProducts { get; set; } 
    }
}