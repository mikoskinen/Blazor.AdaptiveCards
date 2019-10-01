using System.Text.Json;
using AdaptiveCards;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;
using Blazor.AdaptiveCards.Templating;

namespace Blazor.AdaptiveCards
{
    public class TemplatedAdaptiveCard<TModel> : AdaptiveCard
    {
        private TModel _model;
        private string _modelJson;

        [Parameter]
        public TModel Model
        {
            get
            {
                return _model;
            }
            set
            {
                _model = value;

                if (_model == null)
                {
                    _modelJson = null;

                    return;
                }

                _modelJson = JsonSerializer.Serialize(_model);
            }
        }

        [Inject] private IAdaptiveCardTemplatingProvider TemplatingProvider { get; set; }
        [CascadingParameter(Name = "Template")] private string Template { get; set; }

        public async Task RenderCard(string schema, TModel model)
        {
            _modelJson = JsonSerializer.Serialize(model);

            await RenderCard(schema);
        }

        protected override void OnParametersSet()
        {
            base.OnParametersSet();

            if (string.IsNullOrWhiteSpace(Template))
            {
                return;
            }

            Schema = Template;
        }

        protected override async Task<AdaptiveCardParseResult> CreateCardFromSchema(string schema)
        {
            var templatedSchema = await TemplatingProvider.CreateSchemaFromTemplate(schema, JsonSerializer.Deserialize<TModel>(_modelJson));

            var result = global::AdaptiveCards.AdaptiveCard.FromJson(templatedSchema);

            return result;
        }

        protected override bool ShouldRender(string currentSchema, string newSchema)
        {
            return true;
        }

        protected override async Task RunSubmit(SubmitEventArgs eventArgs)
        {
            await SubmitActionHandler.Handle(eventArgs, SubmitHandler, _model);
        }
    }
}
