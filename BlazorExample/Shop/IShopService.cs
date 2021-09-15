using System.Threading.Tasks;

namespace BlazorExample.Shop
{
    public interface IShopService
    {
        Task<ShopModel[]> GetItemsAsync();
    }
}