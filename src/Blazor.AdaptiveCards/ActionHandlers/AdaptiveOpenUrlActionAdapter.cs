using Microsoft.AspNetCore.Components;

namespace AdaptiveCards.Blazor.ActionHandlers
{
    public class AdaptiveOpenUrlActionAdapter
    {
        public void OpenUrl(NavigationManager navigationManager, string url)
        {
            navigationManager.NavigateTo(url);
        }
    }
}
