using System.Linq;
using AdaptiveCards.Rendering.Html;

namespace AdaptiveCards.Blazor.ActionHandlers
{
    /// <summary>
    /// The default implementation for adding required HTML attributes for ToggleVisibilityAction into the card HTML.  
    /// </summary>
    /// <remarks>Based on the following code: https://github.com/microsoft/AdaptiveCards/blob/master/source/dotnet/Library/AdaptiveCards.Rendering.Html/AdaptiveCardRenderer.cs</remarks>
    public class DefaultAdaptiveToggleVisibilityActionProvider
    {
        public static void Create(AdaptiveToggleVisibilityAction action, HtmlTag tag, AdaptiveRenderContext renderContext)
        {
            var targetElements = string.Empty;

            if (action.TargetElements?.Any() != true)
            {
                return;
            }
            
            foreach (var targetElement in action.TargetElements)
            {
                if (!string.IsNullOrWhiteSpace(targetElements))
                {
                    targetElements += ",";
                }

                string targetElementId = null;
                var targetElementToggleAction = "Toggle";

                if (targetElement != null)
                {
                    targetElementId = targetElement.ElementId;

                    if (targetElement.IsVisible.HasValue)
                    {
                        targetElementToggleAction = targetElement.IsVisible.Value.ToString();
                    }
                }

                targetElements += targetElementId + ":" + targetElementToggleAction;
            }

            tag.Attr("data-ac-targetelements", targetElements);
            var toggleId = AdaptiveCardRenderer.GenerateRandomId();
            
            tag.Attr("id", toggleId);
            tag.Attributes.Add("onclick",
                $"blazorAdaptiveCards.toggleVisibility('{toggleId}')");
        }
    }
}
