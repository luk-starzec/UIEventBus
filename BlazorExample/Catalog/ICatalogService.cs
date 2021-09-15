using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorExample.Catalog
{
    public interface ICatalogService
    {
        Task<CatalogModel[]> GetItemsAsync();
    }
}