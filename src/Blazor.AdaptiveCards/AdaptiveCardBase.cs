using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AdaptiveCards;
using AdaptiveCards.Rendering.Html;
using Blazor.AdaptiveCards.ActionHandlers;
using Blazor.AdaptiveCards.Actions;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace Blazor.AdaptiveCards
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

        [Inject] private AdaptiveOpenUrlActionAdapter UrlActionAdapter { get; set; }
        [Inject] private AdaptiveCardRenderer Renderer { get; set; }
        [Inject] private IJSRuntime JsRuntime { get; set; }

        [Inject] private NavigationManager NavigationManager { get; set; }

        [Inject] protected ISubmitActionHandler SubmitActionHandler { get; set; }

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

        [Parameter(CaptureUnmatchedValues = true)]
        public Dictionary<string, object> Attributes { get; set; }

        protected override async Task OnParametersSetAsync()
        {
            // Enable for sync render
            //await RenderCard(Schema);
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                if (JsInitialized)
                {
                    return;
                }

                var myRef = DotNetObjectReference.Create(this);
                await JsRuntime.InvokeAsync<object>("blazorAdaptiveCards.setUrlOpener", myRef);

                JsInitialized = true;

                // Enable for async render
                await RenderCard(Schema);
            }
        }

        /// <summary>
        /// Renders the card.
        /// </summary>
        /// <param name="schema">The schema.</param>
        public async Task RenderCard(string schema)
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

            System.Diagnostics.Debug.WriteLine("Rendering card");

            var adaptiveCard = await CreateCardFromSchema(schema);
            var renderedAdaptiveCard = Renderer.RenderCard(adaptiveCard.Card);
            CardHtml = renderedAdaptiveCard.Html.ToString();

            CurrentSchema = schema;

            // Enable for async render
            StateHasChanged();

            if (OnCardRendered.HasDelegate == false)
            {
                return;
            }

            await OnCardRendered.InvokeAsync(new CardRenderedEventArgs(CurrentSchema, renderedAdaptiveCard.Warnings));
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

            var eventArgs = new SubmitEventArgs(actionName, data);

            if (SubmitHandler != null)
            {
                await RunSubmit(eventArgs);
            }
            else
            {
                await OnSubmitAction.InvokeAsync(eventArgs);
            }
        }

        protected virtual async Task RunSubmit(SubmitEventArgs eventArgs)
        {
            await SubmitActionHandler.Handle(eventArgs, SubmitHandler, null);
        }

        protected virtual bool ShouldRender(string currentSchema, string newSchema)
        {
            return !string.Equals(newSchema, currentSchema, StringComparison.InvariantCulture);
        }

        protected virtual Task<AdaptiveCardParseResult> CreateCardFromSchema(string schema)
        {
            var result = global::AdaptiveCards.AdaptiveCard.FromJson(schema);

            return Task.FromResult(result);
        }
    }
}
