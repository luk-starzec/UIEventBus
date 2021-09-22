using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Threading.Tasks;

namespace Catalog
{
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
