using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eShop.Core.Models;
using eShop.UseCases.Contracts;
using Blazored.LocalStorage;
using Newtonsoft.Json;

namespace eShop.ShoppingCart.LocalStorage
{
    public class ShoppingCart : IShoppingCart
    {
        private const string ShoppingCartKey = "eShop.ShoppingCart";
        private readonly ILocalStorageService _localStorage;

        public ShoppingCart(ILocalStorageService localStorage)
        {
            _localStorage = localStorage;
        }

        public List<OrderLineItem> OrderLineItems { get; set; } = new List<OrderLineItem>();

        public async Task AddItem(Product product, int quantity)
        {
            ValidateLineItem(product, quantity);

            var lineItem = OrderLineItems.FirstOrDefault(item => item.ProductId == product.Id);

            if (lineItem == null)
            {
                OrderLineItems.Add(
                    new OrderLineItem
                    {
                        Price = product.Price,
                        ProductId = product.Id,
                        Quantity = quantity
                    });
            }
            else
            {
                lineItem.Quantity = quantity;
            }

            await SaveLineItems();
        }

        private static void ValidateLineItem(Product product, int quantity)
        {
            if (product == null)
            {
                throw new ArgumentException("Product cannot be null.", nameof(product));
            }

            if (quantity < 1)
            {
                throw new ArgumentException("Quantity cannot be less than 1.", nameof(quantity));
            }
        }

        public int? GetProductQuantity(int productId)
        {
            return OrderLineItems.FirstOrDefault(item => item.ProductId == productId)?.Quantity;
        }

        public async Task SaveLineItems()
        {
            try
            {
                await _localStorage.SetItemAsync(ShoppingCartKey, JsonConvert.SerializeObject(OrderLineItems));
            }
            catch (Exception exception)
            {
                OrderLineItems = new List<OrderLineItem>();
            }
        }

        public async Task GetLineItems()
        {
            try
            {
                OrderLineItems = await _localStorage.ContainKeyAsync(ShoppingCartKey)
                    ? await _localStorage.GetItemAsync<List<OrderLineItem>>(ShoppingCartKey)
                    : new List<OrderLineItem>();
            }
            catch (Exception exception)
            {
                OrderLineItems = new List<OrderLineItem>();
            }
        }
    }
}
