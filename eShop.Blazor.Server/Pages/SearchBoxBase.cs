using Microsoft.AspNetCore.Components;

namespace eShop.Blazor.Server.Pages
{
    public class SearchBoxBase : ComponentBase
    {
        [Parameter]
        public EventCallback<string> HandleSearch { get; set; }
        public string SearchText { get; set; }
    }
}