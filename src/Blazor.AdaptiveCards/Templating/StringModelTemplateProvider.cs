using System.Threading.Tasks;

namespace Blazor.AdaptiveCards.Templating
{
    public class StringModelTemplateProvider<T> : IModelTemplateProvider<T>
    {
        private readonly string _template;

        public StringModelTemplateProvider(string template)
        {
            _template = template;
        }

        string IModelTemplateProvider<T>.GetTemplate(T model)
        {
            return _template;
        }
    }
}
