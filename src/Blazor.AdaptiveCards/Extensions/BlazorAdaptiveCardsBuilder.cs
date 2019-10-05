using Microsoft.Extensions.DependencyInjection;

namespace AdaptiveCards.Blazor.Extensions
{
    public class BlazorAdaptiveCardsBuilder
    {
        public BlazorAdaptiveCardsBuilder(IServiceCollection services)
        {
            Services = services;
        }

        public IServiceCollection Services { get; }
    }
}
