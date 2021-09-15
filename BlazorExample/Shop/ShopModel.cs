using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorExample.Shop
{
    public class ShopModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool Available { get; set; }

        public ShopModel(int id, string name)
        {
            Id = id;
            Name = name;
            Price = 100;
            Available = true;
        }
    }
}
