using AdaptiveCards;
using AdaptiveCards.Rendering.Html;
using System;
using Blazor.AdaptiveCards;
using Blazor.AdaptiveCards.ActionHandlers;
using Blazor.AdaptiveCards.Templating;
using Microsoft.Extensions.DependencyInjection.Extensions;

// ReSharper disable once CheckNamespace
namespace Microsoft.Extensions.DependencyInjection
{
    public static class AdaptiveCardsBlazorServiceCollectionExtensions
    {
        public static IServiceCollection AddBlazorAdaptiveCards(this IServiceCollection services, Action<BlazorAdaptiveCardsOptions> configure = null)
        {
            var options = new BlazorAdaptiveCardsOptions();
            configure?.Invoke(options);

            if (options.AdaptiveOpenUrlActionProvider != null)
            {
                AdaptiveCardActionCreators.CreateAdaptiveOpenUrlAction = options.AdaptiveOpenUrlActionProvider;
            }

            if (options.AdaptiveShowCardActionProvider != null)
            {
                AdaptiveCardActionCreators.CreateAdaptiveShowCardAction = options.AdaptiveShowCardActionProvider;
            }

            if (options.AdaptiveSubmitActionProvider != null)
            {
                AdaptiveCardActionCreators.CreateAdaptiveSubmitAction = options.AdaptiveSubmitActionProvider;
            }

            if (options.AdaptiveCardTemplatingProvider == null)
            {
                services.AddSingleton<IAdaptiveCardTemplatingProvider, ScribanCardBinder>();
            }

            AdaptiveCardRenderer.ActionTransformers.Register<AdaptiveOpenUrlAction>((action, tag, context) =>
            {
                AdaptiveCardActionCreators.CreateAdaptiveOpenUrlAction(action, tag, context);
            });

            AdaptiveCardRenderer.ActionTransformers.Register<AdaptiveShowCardAction>((action, tag, context) =>
            {
                AdaptiveCardActionCreators.CreateAdaptiveShowCardAction(action, tag, context);
            });

            AdaptiveCardRenderer.ActionTransformers.Register<AdaptiveSubmitAction>((action, tag, context) =>
            {
                AdaptiveCardActionCreators.CreateAdaptiveSubmitAction(action, tag, context);
            });

            services.AddSingleton<AdaptiveCardRenderer>();
            services.AddSingleton<AdaptiveOpenUrlActionAdapter>();
            services.TryAddSingleton<ISubmitActionHandler, DefaultSubmitActionHandler>();

            services.AddSingleton(options);

            return services;
        }
    }
}
