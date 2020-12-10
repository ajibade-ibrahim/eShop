using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eShop.Core.Models;
using eShop.UseCases.SearchProductsScreen.Contracts;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace eShop.Blazor.Server.Pages
{
    public class SearchProductsComponentBase : ComponentBase
    {
        [Inject]
        public ISearchProduct SearchProductService { get; set; }
        [Inject]
        public IJSRuntime JsRuntime { get; set; }
        public List<Product> Products { get; set; }

        protected override async Task OnInitializedAsync()
        {
            try
            {
                var products = await SearchProductService.Execute(string.Empty);
                Products = products?.ToList() ?? new List<Product>();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
        }

        protected override Task OnAfterRenderAsync(bool firstRender)
        {
            JsRuntime.InvokeVoidAsync("initialize");
            return base.OnAfterRenderAsync(firstRender);
        }

        protected async Task HandleSearch(string searchTerm)
        {
            try
            {
                var products = await SearchProductService.Execute(searchTerm);
                Products = products?.ToList() ?? new List<Product>();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }
    }
}
