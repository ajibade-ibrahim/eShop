using System.Collections.Generic;
using System.Threading.Tasks;
using eShop.Core.Models;
using eShop.UseCases.Contracts.Data;
using eShop.UseCases.SearchProductsScreen.Contracts;

namespace eShop.UseCases.SearchProductsScreen
{
    public class SearchProduct : ISearchProduct
    {
        public SearchProduct(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        private readonly IProductRepository _productRepository;

        public async Task<IEnumerable<Product>> Execute(string filter)
        {
            return await _productRepository.GetProductsAsync(filter);
        }
    }
}