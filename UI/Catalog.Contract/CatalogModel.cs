using System.ComponentModel;
using System.Text.Json.Serialization;

namespace Catalog
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
