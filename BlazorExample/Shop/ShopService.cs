using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BlazorExample.Shop
{
    public class ShopService : IShopService
    {
        private readonly HttpClient httpClient;

        public ShopService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<ShopModel[]> GetItemsAsync()
        {
            return await httpClient.GetFromJsonAsync<ShopModel[]>("sample-data/products.json");
        }
    }
}
