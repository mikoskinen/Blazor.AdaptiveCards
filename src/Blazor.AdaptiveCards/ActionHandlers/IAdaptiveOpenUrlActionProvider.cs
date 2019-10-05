using AdaptiveCards.Rendering.Html;

namespace AdaptiveCards.Blazor.ActionHandlers
{
    public interface IAdaptiveOpenUrlActionProvider
    {
        void Create(AdaptiveOpenUrlAction action, HtmlTag tag, AdaptiveRenderContext renderContext);
    }
}
