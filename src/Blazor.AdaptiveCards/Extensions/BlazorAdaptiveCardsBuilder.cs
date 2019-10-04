namespace Microsoft.Extensions.DependencyInjection
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
