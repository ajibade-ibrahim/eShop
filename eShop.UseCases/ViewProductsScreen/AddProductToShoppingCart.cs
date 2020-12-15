using System.Threading.Tasks;
using eShop.Core.Models;
using eShop.UseCases.Contracts;

namespace eShop.UseCases.ViewProductsScreen
{
    public class AddProductToShoppingCart : IAddProductToShoppingCart
    {
        private readonly IShoppingCart _shoppingCart;

        public AddProductToShoppingCart(IShoppingCart shoppingCart)
        {
            _shoppingCart = shoppingCart;
        }

        public async Task Execute(Product product, int quantity)
        {
            await _shoppingCart.AddItem(product, quantity);
        }

        public int? GetProductCount(int productId)
        {
            return _shoppingCart.GetProductQuantity(productId);
        }
    }
}