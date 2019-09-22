using AdaptiveCards;
using AdaptiveCards.Rendering.Html;

namespace Blazor.AdaptiveCards.ActionHandlers
{
    public class DefaultAdaptiveShowCardActionProvider
    {
        public static void Create(AdaptiveShowCardAction action, HtmlTag tag, AdaptiveRenderContext renderContext)
        {
            tag.Attr("id", AdaptiveCardRenderer.GenerateRandomId());

            var targetId = AdaptiveCardRenderer.GenerateRandomId();
            tag.Attr("data-ac-showCardId", targetId);

            tag.Attributes.Add("onclick",
                "document.getElementById('" + targetId + "').style.display === 'none' ? document.getElementById('" + targetId +
                "').style.display = '' : document.getElementById('" + targetId + "').style.display = 'none';");
        }
    }
}
