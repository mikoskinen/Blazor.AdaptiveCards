using System;
using AdaptiveCards;
using AdaptiveCards.Rendering.Html;

namespace Blazor.AdaptiveCards.ActionHandlers
{
    public static class AdaptiveCardActionCreators
    {
        public static Action<AdaptiveOpenUrlAction, HtmlTag, AdaptiveRenderContext> CreateAdaptiveOpenUrlAction = (action, tag, context) =>
        {
            DefaultAdaptiveOpenUrlActionProvider.Create(action, tag, context);
        };

        public static Action<AdaptiveShowCardAction, HtmlTag, AdaptiveRenderContext> CreateAdaptiveShowCardAction = (action, tag, context) =>
        {
            DefaultAdaptiveShowCardActionProvider.Create(action, tag, context);
        };

        public static Action<AdaptiveSubmitAction, HtmlTag, AdaptiveRenderContext> CreateAdaptiveSubmitAction = (action, tag, context) =>
        {
            DefaultAdaptiveSubmitActionProvider.Create(action, tag, context);
        };
    }
}
