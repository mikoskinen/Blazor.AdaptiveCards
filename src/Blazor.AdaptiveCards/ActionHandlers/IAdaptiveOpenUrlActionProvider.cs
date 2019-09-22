using AdaptiveCards;
using AdaptiveCards.Rendering.Html;

namespace Blazor.AdaptiveCards.ActionHandlers
{
    public interface IAdaptiveOpenUrlActionProvider
    {
        void Create(AdaptiveOpenUrlAction action, HtmlTag tag, AdaptiveRenderContext renderContext);
    }
}
