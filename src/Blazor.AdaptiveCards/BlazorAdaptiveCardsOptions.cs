using System;
using AdaptiveCards;
using AdaptiveCards.Rendering.Html;
using Blazor.AdaptiveCards.Templating;

namespace Blazor.AdaptiveCards
{
    public class BlazorAdaptiveCardsOptions
    {
        public Action<AdaptiveOpenUrlAction, HtmlTag, AdaptiveRenderContext> AdaptiveOpenUrlActionProvider { get; set; }
        public Action<AdaptiveShowCardAction, HtmlTag, AdaptiveRenderContext> AdaptiveShowCardActionProvider { get; set; }
        public Action<AdaptiveSubmitAction, HtmlTag, AdaptiveRenderContext> AdaptiveSubmitActionProvider { get; set; }
        public IAdaptiveCardTemplatingProvider AdaptiveCardTemplatingProvider { get; set; }
        public bool AllowTemplatingError { get; set; }
    }
}
