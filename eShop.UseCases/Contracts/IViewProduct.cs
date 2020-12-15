using System.Threading.Tasks;
using eShop.Core.Models;

namespace eShop.UseCases.SearchProductsScreen.Contracts
{
    public interface IViewProduct
    {
        Task<Product> Execute(int productId);
    }
}