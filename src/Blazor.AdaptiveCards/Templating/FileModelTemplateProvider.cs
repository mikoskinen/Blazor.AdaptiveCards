using System.Threading.Tasks;

namespace Blazor.AdaptiveCards.Templating
{
    public class FileModelTemplateProvider<T> : IModelTemplateProvider<T>
    {
        private readonly string _filename;

        public FileModelTemplateProvider(string filename)
        {
            _filename = filename;
        }

        string IModelTemplateProvider<T>.GetTemplate(T model)
        {
            var result = System.IO.File.ReadAllText("TemplatedAdaptiveCard.json");

            return result;
        }
    }
}
