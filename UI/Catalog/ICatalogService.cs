using System.Collections.Generic;
using System.Threading.Tasks;

namespace Catalog
{
    public interface ICatalogService
    {
        Task<CatalogModel[]> GetItemsAsync();
    }
}