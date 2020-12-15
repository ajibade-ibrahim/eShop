using System.Collections.Generic;
using System.Threading.Tasks;
using eShop.Core.Models;
using eShop.UseCases.Contracts;
using eShop.UseCases.Contracts.Data;

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