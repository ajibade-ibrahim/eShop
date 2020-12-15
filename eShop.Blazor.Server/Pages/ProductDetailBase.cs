using System;
using System.Threading.Tasks;
using eShop.Core.Models;
using eShop.UseCases.Contracts;
using eShop.UseCases.SearchProductsScreen.Contracts;
using Microsoft.AspNetCore.Components;

namespace eShop.Blazor.Server.Pages
{
    public class ProductDetailBase : ComponentBase
    {
        [Parameter]
        public int ProductId { get; set; }
        public Product Product { get; set; }

        [Inject]
        public IViewProduct ViewProductService { get; set; }

        [Inject]
        public IAddProductToShoppingCart AddProductToShoppingCart { get; set; }
        protected int Quantity { get; set; }

        protected override async Task OnParametersSetAsync()
        {
            try
            {
                Product = await ViewProductService.Execute(ProductId);
                Quantity = 1;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
        }

        public async Task AddToShoppingCart()
        {
            Console.WriteLine("crap");
            await AddProductToShoppingCart.Execute(Product, Quantity);
        }
    }
}