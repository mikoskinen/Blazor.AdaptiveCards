using System.Threading.Tasks;

namespace Blazor.AdaptiveCards.Templating
{
    /// <summary>
    /// Interface IAdaptiveCardTemplatingProvider
    /// </summary>
    public interface IAdaptiveCardTemplatingProvider
    {
        /// <summary>
        /// Creates the schema from template and from the model.
        /// </summary>
        /// <param name="template">The template.</param>
        /// <param name="model">The model.</param>
        /// <returns>Task&lt;System.String&gt;.</returns>
        Task<string> CreateSchemaFromTemplate(string template, object model);
    }
}
