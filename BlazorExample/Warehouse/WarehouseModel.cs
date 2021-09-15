using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorExample.Warehouse
{
    public class WarehouseModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }

        public WarehouseModel(int id, string name)
        {
            Id = id;
            Name = name;
            Quantity = 5;
        }
    }
}
