using System.Threading.Tasks;
using eShop.Core.Models;

namespace eShop.UseCases.Contracts
{
    public interface IShoppingCart
    {
        Task AddItem(Product product, int quantity);
        int? GetProductQuantity(int productId);
    }
}