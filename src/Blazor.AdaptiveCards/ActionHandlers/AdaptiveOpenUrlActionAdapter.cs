using Microsoft.AspNetCore.Components;

namespace Blazor.AdaptiveCards.ActionHandlers
{
    public class AdaptiveOpenUrlActionAdapter
    {
        public void OpenUrl(NavigationManager navigationManager, string url)
        {
            navigationManager.NavigateTo(url);
        }
    }
}
