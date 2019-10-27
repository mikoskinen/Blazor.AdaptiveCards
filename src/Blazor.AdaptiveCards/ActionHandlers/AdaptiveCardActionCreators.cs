using System;
using AdaptiveCards.Rendering.Html;

namespace AdaptiveCards.Blazor.ActionHandlers
{
    public static class AdaptiveCardActionCreators
    {
        public static Action<AdaptiveOpenUrlAction, HtmlTag, AdaptiveRenderContext> CreateAdaptiveOpenUrlAction = DefaultAdaptiveOpenUrlActionProvider.Create;
        public static Action<AdaptiveShowCardAction, HtmlTag, AdaptiveRenderContext> CreateAdaptiveShowCardAction = DefaultAdaptiveShowCardActionProvider.Create;
        public static Action<AdaptiveSubmitAction, HtmlTag, AdaptiveRenderContext> CreateAdaptiveSubmitAction = DefaultAdaptiveSubmitActionProvider.Create;
        public static Action<AdaptiveToggleVisibilityAction, HtmlTag, AdaptiveRenderContext> CreateAdaptiveToggleVisibilityAction = DefaultAdaptiveToggleVisibilityActionProvider.Create;
    }
}
