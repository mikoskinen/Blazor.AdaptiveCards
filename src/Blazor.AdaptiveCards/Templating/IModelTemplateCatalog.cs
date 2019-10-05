namespace AdaptiveCards.Blazor.Templating
{
    public interface IModelTemplateCatalog
    {
        void Register(IModelTemplateProvider provider);
        string Get(string templateName);
    }
}
