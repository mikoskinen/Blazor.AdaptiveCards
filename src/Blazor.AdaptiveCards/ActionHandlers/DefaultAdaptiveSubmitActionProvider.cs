using AdaptiveCards;
using AdaptiveCards.Rendering.Html;
using Newtonsoft.Json;

namespace Blazor.AdaptiveCards.ActionHandlers
{
    public class DefaultAdaptiveSubmitActionProvider
    {
        public static void Create(AdaptiveSubmitAction action, HtmlTag tag, AdaptiveRenderContext renderContext)
        {
            tag.Attr("id", AdaptiveCardRenderer.GenerateRandomId());
            tag.Attr("data-ac-submitData", JsonConvert.SerializeObject(action.Data, Formatting.None));

            if (action.AdditionalProperties.ContainsKey("name"))
            {
                tag.Attributes.Add("data-name", action.AdditionalProperties["name"].ToString());
            }
            else
            {
                tag.Attributes.Add("data-name", "Submit");
            }

            tag.Attributes.Add("onclick", "window.blazorAdaptiveCards.submitData(this)");

            //tag.Attributes.Add("onclick", "window.location.assign(this.getAttribute('data-ac-url'))");
        }
    }
}
