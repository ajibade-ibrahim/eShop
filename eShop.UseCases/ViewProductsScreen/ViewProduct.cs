using System.Threading.Tasks;
using eShop.Core.Models;
using eShop.UseCases.Contracts.Data;
using eShop.UseCases.SearchProductsScreen.Contracts;

namespace eShop.UseCases.ViewProductsScreen
{
    public class ViewProduct : IViewProduct
    {
        public ViewProduct(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        private readonly IProductRepository _productRepository;

        public async Task<Product> Execute(int productId)
        {
            return await _productRepository.GetProductById(productId);
        }
    }
}