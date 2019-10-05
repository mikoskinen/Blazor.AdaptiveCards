using System;
using AdaptiveCards;
using AdaptiveCards.Blazor.Templating;
using AdaptiveCards.Rendering.Html;

namespace AdaptiveCards.Blazor
{
    /// <summary>
    /// Options
    /// </summary>
    public class BlazorAdaptiveCardsOptions
    {
        /// <summary>
        /// Gets or sets the adaptive open URL action provider.
        /// </summary>
        /// <value>The adaptive open URL action provider.</value>
    
        public Action<AdaptiveOpenUrlAction, HtmlTag, AdaptiveRenderContext> AdaptiveOpenUrlActionProvider { get; set; }
        /// <summary>
        /// Gets or sets the adaptive show card action provider.
        /// </summary>
        /// <value>The adaptive show card action provider.</value>
      
        public Action<AdaptiveShowCardAction, HtmlTag, AdaptiveRenderContext> AdaptiveShowCardActionProvider { get; set; }
        /// <summary>
        /// Gets or sets the adaptive submit action provider.
        /// </summary>
        /// <value>The adaptive submit action provider.</value>
     
        public Action<AdaptiveSubmitAction, HtmlTag, AdaptiveRenderContext> AdaptiveSubmitActionProvider { get; set; }
        /// <summary>
        /// Gets or sets the adaptive card templating provider.
        /// </summary>
        /// <value>The adaptive card templating provider.</value>
       
        public IAdaptiveCardTemplatingProvider AdaptiveCardTemplatingProvider { get; set; }
     
        /// <summary>
        /// Gets or sets a value indicating whether [allow templating error].
        /// </summary>
        /// <value><c>true</c> if [allow templating error]; otherwise, <c>false</c>.</value>
        public bool AllowTemplatingError { get; set; }

        /// <summary>
        /// Gets or sets the render failed text.
        /// </summary>
        /// <value>The render failed text.</value>
        public string RenderFailedText { get; set; } = "Rendering card failed: {0}";
    }
}
