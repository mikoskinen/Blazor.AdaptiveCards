using Blazor.AdaptiveCards.Templating;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class AdaptiveCardsBlazorModelTemplateExtensions
    {
        /// <summary>
        /// Adds the file template.
        /// </summary>
        /// <typeparam name="TModel">The type of the model.</typeparam>
        /// <param name="builder">The builder.</param>
        /// <param name="filepath">The filepath.</param>
        /// <returns>BlazorAdaptiveCardsBuilder.</returns>
        public static BlazorAdaptiveCardsBuilder AddFileTemplate<TModel>(this BlazorAdaptiveCardsBuilder builder, string filepath)
        {
            builder.Services.AddTransient<IModelTemplateProvider>(provider =>
            {
                var templateName = typeof(TModel).Name;

                return new FileModelTemplateProvider(filepath, templateName);
            });

            return builder;
        }

        /// <summary>
        /// Adds the file template.
        /// </summary>
        /// <param name="builder">The builder.</param>
        /// <param name="templateName">Name of the template.</param>
        /// <param name="filepath">The filepath.</param>
        /// <returns>BlazorAdaptiveCardsBuilder.</returns>
        public static BlazorAdaptiveCardsBuilder AddFileTemplate(this BlazorAdaptiveCardsBuilder builder, string templateName, string filepath)
        {
            builder.Services.AddTransient<IModelTemplateProvider>(provider =>
            {
                return new FileModelTemplateProvider(filepath, templateName);
            });

            return builder;
        }
    }
}
