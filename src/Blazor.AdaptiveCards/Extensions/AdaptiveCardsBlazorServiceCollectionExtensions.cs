using AdaptiveCards;
using AdaptiveCards.Rendering.Html;
using System;
using AdaptiveCards.Blazor;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System.Linq;
using AdaptiveCards.Blazor.ActionHandlers;
using AdaptiveCards.Blazor.Actions;
using AdaptiveCards.Blazor.Extensions;
using AdaptiveCards.Blazor.Templating;

// ReSharper disable once CheckNamespace
namespace Microsoft.Extensions.DependencyInjection
{
    public static class AdaptiveCardsBlazorServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the adaptive cards support into your Blazor app.
        /// </summary>
        /// <param name="services">The service collection.</param>
        /// <param name="configure">The configure action.</param>
        /// <returns>BlazorAdaptiveCardsBuilder.</returns>
        public static BlazorAdaptiveCardsBuilder AddBlazorAdaptiveCards(this IServiceCollection services, Action<BlazorAdaptiveCardsOptions> configure = null)
        {
            var builder = new BlazorAdaptiveCardsBuilder(services);

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

            services.TryAddSingleton<IModelTemplateCatalog>(provider =>
            {
                var templateProviders = provider.GetServices(typeof(IModelTemplateProvider)).Cast<IModelTemplateProvider>();

                var result = new ModelTemplateCatalog();

                foreach (var templateProvider in templateProviders)
                {
                    result.Register(templateProvider);
                }

                return result;
            });

            services.AddSingleton(options);

            return builder;
        }
    }
}
