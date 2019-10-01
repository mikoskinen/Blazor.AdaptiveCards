using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AdaptiveCards;
using AdaptiveCards.Rendering.Html;
using Blazor.AdaptiveCards.ActionHandlers;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace Blazor.AdaptiveCards
{
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

        [Parameter] public string Schema { get; set; }

        [Parameter] public object SubmitHandler{ get; set; }

        [Parameter] public EventCallback<string> OnOpeningLink { get; set; }

        [Parameter] public EventCallback<SubmitEventArgs> OnCardSubmit { get; set; }

        [Parameter] public EventCallback<string> OnCardRendered { get; set; }

        protected override async Task OnParametersSetAsync()
        {
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

                var myRef = DotNetObjectReference.Create(this);
                await JsRuntime.InvokeAsync<object>("blazorAdaptiveCards.setUrlOpener", myRef);

                JsInitialized = true;
            }
        }

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

            var adaptiveCard = await CreateCardFromSchema(schema);
            CardHtml = Renderer.RenderCard(adaptiveCard.Card).Html.ToString();

            CurrentSchema = schema;

            if (OnCardRendered.HasDelegate == false)
            {
                return;
            }

            await OnCardRendered.InvokeAsync(CurrentSchema);
        }

        [JSInvokable]
        public async Task OpenUrl(string url)
        {
            if (OnOpeningLink.HasDelegate)
            {
                await OnOpeningLink.InvokeAsync(url);

                return;
            }

            UrlActionAdapter.OpenUrl(NavigationManager, url);
        }

        [JSInvokable]
        public async Task SubmitData(Dictionary<string, object> data, string actionName)
        {
            if (!OnCardSubmit.HasDelegate && SubmitHandler == null)
            {
                return;
            }

            var eventArgs = new SubmitEventArgs(actionName, data);

            if (SubmitHandler != null )
            {
                await RunSubmit(eventArgs);
            }
            else
            {
                await OnCardSubmit.InvokeAsync(eventArgs);
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
