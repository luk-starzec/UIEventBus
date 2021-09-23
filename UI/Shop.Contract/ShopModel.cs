using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop
{
    public class ShopModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Color { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool ForSale { get; set; }
        public int Quantity { get; set; }

        public bool Available => ForSale && Quantity > 0;
    }
}
