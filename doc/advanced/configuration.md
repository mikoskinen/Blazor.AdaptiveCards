---
order: 1
title: Configuration
---

Adaptive Cards for Blazor can be configured through the application's ConfigureServices-method. AddBlazorAdaptiveCards exposes BlazorAdaptiveCardsOptions, which allows configuring different aspects of the library:

```csharp {.line-numbers}
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddSingleton<WeatherForecastService>();

            services.AddBlazorAdaptiveCards(options =>
            {
                options.RenderFailedText = "Custom rendering error text";
            })
                .AddTemplate<WeatherForecast>(Schemas.WeatherTemplated)
                .AddTemplate<Customer>(Schemas.CustomerTemplated)
                .AddFileTemplate("Alternative", "AlternativeTemplatedAdaptiveCard.json");
        }
```

Here are all the options:

* AdaptiveOpenUrlActionProvider: Gets or sets the adaptive open URL action provider.
* AdaptiveShowCardActionProvider: Gets or sets the adaptive show card action provider.
* AdaptiveSubmitActionProvider: Gets or sets the adaptive submit action provider.
* AdaptiveCardTemplatingProvider: Gets or sets the adaptive card templating provider.
* AllowTemplatingError: Gets or sets a value indicating whether templating exception throws.
* RenderFailedText: Gets or sets the render failed text.

Another way to customize Adaptive Cards for Blazor is by implementing interfaces. For example, when a Submit action is executed, the execution happens through **ISubmitActionHandler**. By default this is implemented by **DefaultSubmitActionHandler**. If you want a complete control of how submit actions are handled, you can create a custom class:

```csharp {.line-numbers}
        public class MySubmitHandler : ISubmitActionHandler
        {
            public Task Handle(SubmitEventArgs eventArgs, object handler, object model)
            {
                ...
            }
        }
```

Then, add your custom solution in ConfigureServices before calling AddBlazorAdaptiveCards:

```csharp {.line-numbers}
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddSingleton<WeatherForecastService>();

            services.AddSingleton<ISubmitActionHandler, MySubmitHandler>();

            services.AddBlazorAdaptiveCards(options =>
            {
            });
        }
```

Here's the public interfaces you can replace with your own solutions:

* ISubmitActionHandler
* IModelTemplateCatalog
* IModelTemplateProvider
