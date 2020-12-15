using System.Threading.Tasks;
using eShop.Core.Models;

namespace eShop.UseCases.Contracts
{
    public interface IAddProductToShoppingCart
    {
        Task Execute(Product product, int quantity);
    }
}