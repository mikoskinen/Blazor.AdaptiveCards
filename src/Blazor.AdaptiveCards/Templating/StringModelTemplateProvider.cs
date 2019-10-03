using System.Threading.Tasks;

namespace Blazor.AdaptiveCards.Templating
{
    public class StringModelTemplateProvider : IModelTemplateProvider
    {
        private readonly string _template;
        private readonly string _templateName;

        public StringModelTemplateProvider(string template, string templateName)
        {
            _template = template;
            _templateName = templateName;
        }

        public string GetTemplate(string templateName)
        {
            if (!string.Equals(_templateName, templateName))
            {
                return null;
            }

            return _template;
        }
    }
}
