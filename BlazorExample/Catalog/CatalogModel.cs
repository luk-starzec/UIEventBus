using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BlazorExample.Catalog
{
    public class CatalogModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        [JsonPropertyName("categoryId")]
        public CatalogCategoryEnum Category { get; set; }
        public string Color { get; set; }
        public bool ForSale { get; set; }

        //public CatalogModel(int id, string name)
        //{
        //    Id = id;
        //    Name = name;
        //    ForSale = true;
        //}
    }

    public enum CatalogCategoryEnum
    {
        [Description("T-shirt")]
        TShirt,
        [Description("Shirt")]
        Shirt,
        [Description("Pants")]
        Pants,
        [Description("Jacket")]
        Jacket,
        [Description("Hat")]
        Hat,
        [Description("Rain boots")]
        RainBoots,
    }

}
