using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AdaptiveCards.Blazor.ActionHandlers;
using AdaptiveCards.Blazor.Actions;
using AdaptiveCards.Rendering.Html;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Logging;
using Microsoft.JSInterop;

namespace AdaptiveCards.Blazor
{
    /// <summary>
    /// Base class for Adaptive Card
    /// Implements the <see cref="Microsoft.AspNetCore.Components.ComponentBase" />
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Components.ComponentBase" />
    public abstract class AdaptiveCardBase : ComponentBase
    {
        protected string CardHtml = "";
        protected string CurrentSchema = "";
        protected bool JsInitialized;
        protected Guid Id { get; set; } = Guid.NewGuid();
        public bool ShouldReRender { get; set; }

        [Inject] private AdaptiveOpenUrlActionAdapter UrlActionAdapter { get; set; }
        [Inject] private AdaptiveCardRenderer Renderer { get; set; }
        [Inject] protected IJSRuntime JsRuntime { get; set; }

        [Inject] private NavigationManager NavigationManager { get; set; }

        [Inject] protected ISubmitActionHandler SubmitActionHandler { get; set; }

        [Inject] protected ILogger<AdaptiveCardBase> Logger { get; set; }

        [Inject] protected BlazorAdaptiveCardsOptions Options { get; set; }

        /// <summary>
        /// Gets or sets the schema.
        /// </summary>
        /// <value>The schema.</value>
        [Parameter] public string Schema { get; set; }

        /// <summary>
        /// Gets or sets the submit handler.
        /// </summary>
        /// <value>The submit handler.</value>
        [Parameter] public object SubmitHandler { get; set; }

        /// <summary>
        /// Gets or sets the handler which is executed when opening link.
        /// </summary>
        /// <value>The handler.</value>
        [Parameter] public EventCallback<string> OnOpenLinkAction { get; set; }

        /// <summary>
        /// Gets or sets the submit action handler.
        /// </summary>
        /// <value>The handler.</value>
        [Parameter] public EventCallback<SubmitEventArgs> OnSubmitAction { get; set; }

        /// <summary>
        /// Gets or sets the callback when a card is rendered.
        /// </summary>
        /// <value>The on card rendered.</value>
        [Parameter] public EventCallback<CardRenderedEventArgs> OnCardRendered { get; set; }

        /// <summary>
        /// Gets or sets the callback when rendering the card fails.
        /// </summary>
        /// <value>The on card render failed.</value>
        [Parameter] public EventCallback<CardRenderFailedEventArgs> OnCardRenderFailed { get; set; }

        [Parameter(CaptureUnmatchedValues = true)]
        public Dictionary<string, object> Attributes { get; set; }

        [CascadingParameter(Name = "RenderMode")]
        public RenderMode RenderMode { get; set; } = RenderMode.Synchronous;

        protected override async Task OnParametersSetAsync()
        {
            if (Attributes == null)
            {
                Attributes = new Dictionary<string, object>();
                Attributes.Add("class", "blazor-adaptive-card-container");
            }
            else
            {
                if (Attributes.ContainsKey("class"))
                {
                    Attributes["class"] = Attributes["class"] + " " + "blazor-adaptive-card-container";
                }
                else
                {
                    Attributes.Add("class", "blazor-adaptive-card-container");
                }
            }
            
            if (RenderMode == RenderMode.Asynchronous)
            {
                return;
            }

            await RenderCard(Schema);
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                if (JsInitialized)
                {
                    return;
                }

                await InitializeJsInterop();

                if (RenderMode == RenderMode.Synchronous)
                {
                    return;
                }

                await RenderCard(Schema);
            }
        }

        protected virtual async Task InitializeJsInterop()
        {
            var myRef = DotNetObjectReference.Create(this);
            await JsRuntime.InvokeAsync<object>("blazorAdaptiveCards.setCardComponent", myRef, Id);

            JsInitialized = true;
        }

        /// <summary>
        /// Renders the card.
        /// </summary>
        /// <param name="schema">The schema.</param>
        public async Task RenderCard(string schema)
        {
            try
            {

                if (string.IsNullOrWhiteSpace(schema))
                {
                    CardHtml = "";

                    return;
                }

                if (!ShouldRender(CurrentSchema, schema))
                {
                    return;
                }

                var adaptiveCard = await CreateCardFromSchema(schema);
                var renderedAdaptiveCard = Renderer.RenderCard(adaptiveCard.Card);
                CardHtml = renderedAdaptiveCard.Html.ToString();

                CurrentSchema = schema;

                if (RenderMode == RenderMode.Asynchronous)
                {
                    StateHasChanged();
                }

                if (OnCardRendered.HasDelegate == false)
                {
                    return;
                }

                await OnCardRendered.InvokeAsync(new CardRenderedEventArgs(CurrentSchema, renderedAdaptiveCard.Warnings));
            }
            catch (Exception e)
            {
                Logger.LogError(e, "Failed to render card with {Schema}.", Schema);

                CardHtml = string.Format(Options.RenderFailedText, e.ToString());

                if (OnCardRenderFailed.HasDelegate == false)
                {
                    return;
                }

                await OnCardRenderFailed.InvokeAsync(new CardRenderFailedEventArgs(schema, e));
            }
        }

        [JSInvokable]
        public async Task OpenUrl(string url)
        {
            if (OnOpenLinkAction.HasDelegate)
            {
                await OnOpenLinkAction.InvokeAsync(url);

                return;
            }

            UrlActionAdapter.OpenUrl(NavigationManager, url);
        }

        [JSInvokable]
        public async Task SubmitData(Dictionary<string, object> data, string actionName)
        {
            if (!OnSubmitAction.HasDelegate && SubmitHandler == null)
            {
                return;
            }

            var eventArgs = CreateSubmitEventArgs(data, actionName);

            if (SubmitHandler != null)
            {
                await RunSubmit(eventArgs);
            }
            else
            {
                await OnSubmitAction.InvokeAsync(eventArgs);
            }
        }

        protected virtual SubmitEventArgs CreateSubmitEventArgs(Dictionary<string, object> data, string actionName)
        {
            return new SubmitEventArgs(actionName, data, this);
        }

        protected virtual async Task RunSubmit(SubmitEventArgs eventArgs)
        {
            await SubmitActionHandler.Handle(eventArgs, SubmitHandler, null);
        }

        protected virtual bool ShouldRender(string currentSchema, string newSchema)
        {
            if (ShouldReRender)
            {
                ShouldReRender = false;

                return true;
            }

            return !string.Equals(newSchema, currentSchema, StringComparison.InvariantCulture);
        }

        protected virtual Task<AdaptiveCardParseResult> CreateCardFromSchema(string schema)
        {
            var result = global::AdaptiveCards.AdaptiveCard.FromJson(schema);

            return Task.FromResult(result);
        }
    }
}
