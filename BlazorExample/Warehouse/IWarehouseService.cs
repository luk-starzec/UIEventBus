using System.Threading.Tasks;

namespace BlazorExample.Warehouse
{
    public interface IWarehouseService
    {
        Task<WarehouseModel[]> GetItemsAsync();
    }
}