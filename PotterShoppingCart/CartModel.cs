using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PotterShoppingCart
{
    public class CartModel
    {
        public string BookName { get; set; }
        public int Quantity { get; set; }

        public int UnitPrice { get; set; }

        public int Discount { get; set; }
    }
}
