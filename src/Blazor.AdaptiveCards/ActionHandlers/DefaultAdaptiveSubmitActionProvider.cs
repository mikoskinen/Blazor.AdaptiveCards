using AdaptiveCards.Rendering.Html;
using Newtonsoft.Json;

namespace AdaptiveCards.Blazor.ActionHandlers
{
    /// <summary>
    /// The default class for for creating submit actions
    /// </summary>
    public class DefaultAdaptiveSubmitActionProvider
    {
        /// <summary>
        /// Creates the specified submit action.
        /// </summary>
        /// <param name="action">The action.</param>
        /// <param name="tag">The tag.</param>
        /// <param name="renderContext">The render context.</param>
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
        }
    }
}
