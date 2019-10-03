namespace Blazor.AdaptiveCards.Templating
{
    public interface IModelTemplateProvider
    {
        string GetTemplate(string templateName);
    }
}
