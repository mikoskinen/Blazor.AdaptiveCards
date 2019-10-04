using System;

namespace Blazor.AdaptiveCards.Templating
{
    public class TemplatingException : Exception
    {
        public TemplatingException(string message, string template, object model, Exception innerException) : base(message, innerException)
        {
            Template = template;
            Model = model;
        }

        public string Template { get; }
        public object Model { get; }
    }
}
