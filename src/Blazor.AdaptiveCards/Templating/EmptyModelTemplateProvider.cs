namespace AdaptiveCards.Blazor.Templating
{
    public class EmptyModelTemplateProvider : IModelTemplateProvider
    {
        public EmptyModelTemplateProvider()
        {
        }

        public string GetTemplate(string templateName)
        {
            return string.Empty;
        }
    }
}
