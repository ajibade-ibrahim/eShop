using System;
using System.Threading.Tasks;
using eShop.Core.Models;
using eShop.UseCases.SearchProductsScreen.Contracts;
using Microsoft.AspNetCore.Components;

namespace eShop.Blazor.Server.Pages
{
    public class ProductDetailBase : ComponentBase
    {
        [Parameter]
        public int Id { get; set; }
        public Product Product { get; set; }
        [Inject]
        public IViewProduct ViewProductService { get; set; }

        protected override async Task OnParametersSetAsync()
        {
            try
            {
                Product = await ViewProductService.Execute(Id);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
        }
    }
}