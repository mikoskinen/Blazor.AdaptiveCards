using System.Threading.Tasks;

namespace Blazor.AdaptiveCards.Templating
{
    public interface IAdaptiveCardTemplatingProvider
    {
        Task<string> CreateSchemaFromTemplate(string template, object model);
    }
}
