using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorExample.Catalog
{
    public class CatalogModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool ForSale { get; set; }

        public CatalogModel(int id, string name)
        {
            Id = id;
            Name = name;
            ForSale = true;
        }
    }
}
