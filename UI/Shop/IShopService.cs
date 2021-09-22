using System.Threading.Tasks;

namespace Shop
{
    public interface IShopService
    {
        Task<ShopModel[]> GetItemsAsync();
    }
}