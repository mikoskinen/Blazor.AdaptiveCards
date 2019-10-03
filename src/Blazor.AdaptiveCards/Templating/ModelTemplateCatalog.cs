using System.Collections.Generic;

namespace Blazor.AdaptiveCards.Templating
{
    public class ModelTemplateCatalog : IModelTemplateCatalog
    {
        private readonly List<IModelTemplateProvider> _modelTemplateProviders = new List<IModelTemplateProvider>();

        public void Register(IModelTemplateProvider provider)
        {
            _modelTemplateProviders.Add(provider);
        }

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
