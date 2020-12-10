using eShop.Core.Models;
using Microsoft.AspNetCore.Components;

namespace eShop.Blazor.Server.Pages
{
    public class ProductCardBase : ComponentBase
    {
        [Parameter]
        public Product Product { get; set; }
    }
}