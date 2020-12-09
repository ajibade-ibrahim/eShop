using System.Collections.Generic;
using System.Threading.Tasks;
using eShop.Core.Models;

namespace eShop.UseCases.Contracts.Data
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetProductsAsync(string filter = null);
        Task<Product> GetProductById(int productId);
    }
}