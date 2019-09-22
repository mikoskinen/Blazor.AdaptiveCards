using System.Threading.Tasks;
using Scriban;

namespace Blazor.AdaptiveCards.Templating
{
    public class ScribanCardBinder : IAdaptiveCardTemplatingProvider
    {
        public Task<string> CreateSchemaFromTemplate(string template, object model)
        {
            var parsedTemplate = Template.Parse(template);
            var result = parsedTemplate.Render(model, member => member.Name);

            return Task.FromResult(result);
        }
    }
}
