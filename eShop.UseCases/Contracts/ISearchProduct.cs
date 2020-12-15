using System.Collections.Generic;
using System.Threading.Tasks;
using eShop.Core.Models;

namespace eShop.UseCases.Contracts
{
    public interface ISearchProduct
    {
        Task<IEnumerable<Product>> Execute(string filter);
    }
}