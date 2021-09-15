using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BlazorExample.Warehouse
{
    public class WarehouseService : IWarehouseService
    {
        private readonly HttpClient httpClient;

        public WarehouseService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<WarehouseModel[]> GetItemsAsync()
        {
            return await httpClient.GetFromJsonAsync<WarehouseModel[]>("sample-data/products.json");
        }
    }
}
