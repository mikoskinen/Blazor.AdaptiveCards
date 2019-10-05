using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Scriban;

namespace AdaptiveCards.Blazor.Templating
{
    public class ScribanCardBinder : IAdaptiveCardTemplatingProvider
    {
        private readonly ILogger<ScribanCardBinder> _logger;
        private readonly BlazorAdaptiveCardsOptions _options;

        public ScribanCardBinder(BlazorAdaptiveCardsOptions options, ILogger<ScribanCardBinder> logger)
        {
            _options = options;
            _logger = logger;
        }

        public Task<string> CreateSchemaFromTemplate(string template, object model)
        {
            try
            {
                var parsedTemplate = Template.Parse(template);
                var result = parsedTemplate.Render(model, member => member.Name);

                return Task.FromResult(result);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Failed to create schema from {template} with {model}", template, model);

                if (_options.AllowTemplatingError)
                {
                    return Task.FromResult(template);
                }

                throw new TemplatingException("Failed to create schema from template", template, model, e);
            }
        }
    }
}
