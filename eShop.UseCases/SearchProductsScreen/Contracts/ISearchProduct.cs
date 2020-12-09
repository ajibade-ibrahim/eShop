using System.Collections.Generic;
using System.Threading.Tasks;
using eShop.Core.Models;

namespace eShop.UseCases.SearchProductsScreen.Contracts
{
    public interface ISearchProduct
    {
        Task<IEnumerable<Product>> Execute(string filter);
    }
}