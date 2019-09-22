using AdaptiveCards;
using AdaptiveCards.Rendering.Html;
using System;
using Blazor.AdaptiveCards;
using Blazor.AdaptiveCards.ActionHandlers;
using Blazor.AdaptiveCards.Templating;

// ReSharper disable once CheckNamespace
namespace Microsoft.Extensions.DependencyInjection
{
    public static class AdaptiveCardsBlazorServiceCollectionExtensions
    {
        public static IServiceCollection AddBlazorAdaptiveCards(this IServiceCollection services, Action<BlazorAdaptiveCardsOptions> configure = null)
        {
            var options = new BlazorAdaptiveCardsOptions();
            configure?.Invoke(options);

            if (options.AdaptiveOpenUrlActionProvider != null)
            {
                AdaptiveCardActionCreators.CreateAdaptiveOpenUrlAction = options.AdaptiveOpenUrlActionProvider;
            }

            if (options.AdaptiveShowCardActionProvider != null)
            {
                AdaptiveCardActionCreators.CreateAdaptiveShowCardAction = options.AdaptiveShowCardActionProvider;
            }

            if (options.AdaptiveSubmitActionProvider != null)
            {
                AdaptiveCardActionCreators.CreateAdaptiveSubmitAction = options.AdaptiveSubmitActionProvider;
            }

            if (options.AdaptiveCardTemplatingProvider == null)
            {
                services.AddSingleton<IAdaptiveCardTemplatingProvider, ScribanCardBinder>();
            }

            AdaptiveCardRenderer.ActionTransformers.Register<AdaptiveOpenUrlAction>((action, tag, context) =>
            {
                AdaptiveCardActionCreators.CreateAdaptiveOpenUrlAction(action, tag, context);
            });

            AdaptiveCardRenderer.ActionTransformers.Register<AdaptiveShowCardAction>((action, tag, context) =>
            {
                AdaptiveCardActionCreators.CreateAdaptiveShowCardAction(action, tag, context);
            });

            AdaptiveCardRenderer.ActionTransformers.Register<AdaptiveSubmitAction>((action, tag, context) =>
            {
                AdaptiveCardActionCreators.CreateAdaptiveSubmitAction(action, tag, context);
            });

            services.AddSingleton<AdaptiveCardRenderer>();

            services.AddSingleton<AdaptiveOpenUrlActionAdapter>();

            //services.AddSingleton<MyH>();

            return services;
        }
    }

    //public class MyH : ComponentBase
    //{
    //    [Inject]
    //    private IJSRuntime jSRuntime { get; set; }
    //    [Inject]
    //    private AdaptiveOpenUrlActionAdapter adapter { get; set; }

    //    //public MyH(IJSRuntime jSRuntime, AdaptiveOpenUrlActionAdapter adapter)
    //    //{
    //    //    this.jSRuntime = jSRuntime;
    //    //    this.adapter = adapter;

    //    //    var myRef = DotNetObjectReference.Create(adapter);
    //    //    await JSRuntime.InvokeAsync<object>("blazorAdaptiveCards.setUrlOpener", myRef);
    //    //}

    //    protected override async Task OnInitializedAsync()
    //    {
    //        var myRef = DotNetObjectReference.Create(adapter);
    //        await jSRuntime.InvokeAsync<object>("blazorAdaptiveCards.setUrlOpener", myRef );

    //        //return base.OnInitializedAsync();
    //    }
    //}

    //public class ExampleJsInterop
    //{
    //    private readonly IJSRuntime _jsRuntime;
    //    private readonly ComponentBase component;

    //    public ExampleJsInterop(IJSRuntime jsRuntime, ComponentBase component)
    //    {
    //        _jsRuntime = jsRuntime;
    //        this.component = component;
    //    }

    //    public ValueTask<object> CallHelloHelperSayHello(string name)
    //    {
    //        // sayHello is implemented in wwwroot/exampleJsInterop.js
    //        return _jsRuntime.InvokeAsync<object>(
    //            "exampleJsFunctions.sayHello",
    //            DotNetObjectReference.Create(new HelloHelper(name)));
    //    }
    //}

    //public static class NavigationHelper
    //{
    //    public static IServiceProvider ServiceProvider { get; set; }

    //    [JSInvokable]
    //    public static Task NavigateToUrl(string url)
    //    {
    //        if (string.IsNullOrWhiteSpace(url))
    //        {
    //            return Task.CompletedTask;
    //        }

    //        Debug.WriteLine($"Navigating to {url}");

    //        var scopeFactory = ServiceProvider.GetService<IServiceScopeFactory>();
    //        using (var scope = scopeFactory.CreateScope())
    //        {
    //            var navigationManager = scope.ServiceProvider.GetRequiredService<NavigationManager>();
    //            navigationManager.NavigateTo(url);
    //        }

    //        return Task.CompletedTask;
    //    }
    //}
}
