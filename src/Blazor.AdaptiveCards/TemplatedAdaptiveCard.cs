using System.Text.Json;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;
using System;
using AdaptiveCards.Blazor.Actions;
using AdaptiveCards.Blazor.Templating;
using System.Collections.Generic;

namespace AdaptiveCards.Blazor
{
    /// <summary>
    /// Templated Adaptive Card. The card has a schema and a model.
    /// Implements the <see cref="Blazor.AdaptiveCards.AdaptiveCard" />
    /// </summary>
    /// <typeparam name="TModel">The type of the model.</typeparam>
    /// <seealso cref="Blazor.AdaptiveCards.AdaptiveCard" />
    public class TemplatedAdaptiveCard : AdaptiveCard
    {
        private object _model;
        private string _modelJson;
        private string _templateName;

        [Parameter]
        public object Model
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

        /// <summary>
        /// Gets or sets the name of the template.
        /// </summary>
        /// <value>The name of the template.</value>
        [Parameter] public string TemplateName { get => _templateName; set => _templateName = value; }

        /// <summary>
        /// Gets or sets the template selector.
        /// </summary>
        /// <value>The template selector.</value>
        [Parameter] public Func<object, string> TemplateSelector { get; set; }

        [Inject] private IAdaptiveCardTemplatingProvider TemplatingProvider { get; set; }
        [Inject] private IModelTemplateCatalog ModelTemplateCatalog { get; set; }

        [CascadingParameter(Name = "Template")]
        private string ParentTemplate { get; set; }

        [CascadingParameter(Name = "TemplateName")]
        private string ParentTemplateName { get; set; }

        [CascadingParameter(Name = "TemplateSelector")]
        private Func<object, string> ParentTemplateSelector { get; set; }

        public async Task RenderCard(string schema, object model)
        {
            _modelJson = JsonSerializer.Serialize(model);

            await RenderCard(schema);
        }

        protected override void OnParametersSet()
        {
            base.OnParametersSet();

            if (ParentTemplateSelector != null)
            {
                Schema = ParentTemplateSelector(_model);

                return;
            }

            if (TemplateSelector != null)
            {
                Schema = TemplateSelector(_model);

                return;
            }

            if (!string.IsNullOrWhiteSpace(ParentTemplate))
            {
                Schema = ParentTemplate;

                return;
            }

            if (!string.IsNullOrWhiteSpace(ParentTemplateName))
            {
                _templateName = ParentTemplateName;
            }

            if (!string.IsNullOrWhiteSpace(_templateName))
            {
                Schema = ModelTemplateCatalog.Get(_templateName);

                return;
            }

            if (string.IsNullOrWhiteSpace(Schema))
            {
                Schema = ModelTemplateCatalog.Get(Model.GetType().Name);
            }
        }

        protected override async Task<AdaptiveCardParseResult> CreateCardFromSchema(string schema)
        {
            var templatedSchema = await TemplatingProvider.CreateSchemaFromTemplate(schema, _model);

            var result = global::AdaptiveCards.AdaptiveCard.FromJson(templatedSchema);

            return result;
        }

        protected override async Task RunSubmit(SubmitEventArgs eventArgs)
        {
            await SubmitActionHandler.Handle(eventArgs, SubmitHandler, _model);
        }

        protected override SubmitEventArgs CreateSubmitEventArgs(Dictionary<string, object> data, string actionName)
        {
            return new SubmitEventArgs(actionName, data, this, _model);
        }
    }
}
