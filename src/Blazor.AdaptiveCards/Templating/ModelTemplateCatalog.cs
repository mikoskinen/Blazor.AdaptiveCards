using System.Collections.Generic;

namespace Blazor.AdaptiveCards.Templating
{
    public class ModelTemplateCatalog : IModelTemplateCatalog
    {
        private readonly List<IModelTemplateProvider> _modelTemplateProviders = new List<IModelTemplateProvider>();

        /// <summary>
        /// Registers the specified provider.
        /// </summary>
        /// <param name="provider">The provider.</param>
        public void Register(IModelTemplateProvider provider)
        {
            _modelTemplateProviders.Add(provider);
        }

        /// <summary>
        /// Gets the specified template name.
        /// </summary>
        /// <param name="templateName">Name of the template.</param>
        /// <returns>System.String.</returns>
        public string Get(string templateName)
        {
            foreach (var templateProvider in _modelTemplateProviders)
            {
                var template = templateProvider.GetTemplate(templateName);

                if (!string.IsNullOrWhiteSpace(template))
                {
                    return template;
                }
            }

            return string.Empty;
        }
    }
}
