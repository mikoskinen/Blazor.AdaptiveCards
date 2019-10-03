using System.Threading.Tasks;

namespace Blazor.AdaptiveCards.Templating
{
    public class EmptyModelTemplateProvider<T> : IModelTemplateProvider<T>
    {
        public EmptyModelTemplateProvider()
        {
        }

        public string GetTemplate(T model)
        {
            return string.Empty;
        }
    }
}
