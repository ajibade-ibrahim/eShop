using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace eShop.Blazor.Server.Pages
{
    public class SearchBoxBase : ComponentBase
    {
        [Parameter]
        public EventCallback<string> HandleSearch { get; set; }
        public string SearchText { get; set; }

        protected void HandleKeyUp(KeyboardEventArgs eventArgs)
        {
            if (eventArgs.Code == "Enter" || eventArgs.Code == "NumpadEnter")
            {
                // ...
            }
        }

        protected void OnSearchSubmit()
        {
            if (!string.IsNullOrWhiteSpace(SearchText))
            {
                HandleSearch.InvokeAsync(SearchText);
            }
        }
    }
}