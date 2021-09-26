using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Catalog
{
    public interface ICatalogService
    {
        Task<CatalogModel[]> GetItemsAsync();
    }

    public class CatalogService : ICatalogService
    {
        private readonly HttpClient httpClient;

        public CatalogService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<CatalogModel[]> GetItemsAsync()
        {
            return await httpClient.GetFromJsonAsync<CatalogModel[]>("sample-data/products.json");
        }
    }
}
