namespace Blazor.AdaptiveCards.Templating
{
    /// <summary>
    /// Interface IModelTemplateProvider
    /// </summary>
    public interface IModelTemplateProvider
    {
        /// <summary>
        /// Gets the template.
        /// </summary>
        /// <param name="templateName">Name of the template.</param>
        /// <returns>System.String.</returns>
        string GetTemplate(string templateName);
    }
}
