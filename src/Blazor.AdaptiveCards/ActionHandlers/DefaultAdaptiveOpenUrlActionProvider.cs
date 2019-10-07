using AdaptiveCards.Rendering.Html;

namespace AdaptiveCards.Blazor.ActionHandlers
{
    public class DefaultAdaptiveOpenUrlActionProvider
    {
        public static void Create(AdaptiveOpenUrlAction action, HtmlTag tag, AdaptiveRenderContext renderContext)
        {
            tag.Attr("id", AdaptiveCardRenderer.GenerateRandomId());
            tag.Attr("data-ac-url", action.Url);

            tag.Attributes.Add("onclick", "window.blazorAdaptiveCards.openUrl(this.getAttribute('data-ac-url'), this)");
        }
    }
}
