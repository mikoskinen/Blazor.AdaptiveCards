using System.Threading.Tasks;

namespace Blazor.AdaptiveCards.Templating
{
    public class FileModelTemplateProvider : IModelTemplateProvider
    {
        private readonly string _filename;
        private readonly string _templateName;

        public FileModelTemplateProvider(string filename, string templateName)
        {
            _filename = filename;
            _templateName = templateName;
        }

        public string GetTemplate(string templateName)
        {
            if (!string.Equals(templateName, _templateName))
            {
                return null;
            }

            var result = System.IO.File.ReadAllText(_filename);

            return result;
        }
    }
}
