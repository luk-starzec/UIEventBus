using System.Threading.Tasks;

namespace Warehouse
{
    public interface IWarehouseService
    {
        Task<WarehouseModel[]> GetItemsAsync();
    }
}