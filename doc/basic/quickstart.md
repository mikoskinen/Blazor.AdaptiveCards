---
order: 0
title: Quick start
---

This quick start shows the required steps of using Adaptive Cards for Blazor. For a more throughout tutorial, please see the [Getting Started](/gettingstarted.html) guide.

The quick start assumes that an existing server side Blazor application is modified to support Adaptive Cards.

#### Add NuGet

```csharp
Install-Package AdaptiveCardsBlazor
```

#### Configure Startup.cs

```csharp
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddServerSideBlazor();
            
            ...

            services.AddBlazorAdaptiveCards();
        }
```

#### Configure _Imports.razor

```csharp
...
@using AdaptiveCards.Blazor
```

#### Add JS interop into _Host.cshtml

```html
    <script src="_content/AdaptiveCardsBlazor/adaptiveCardsJsInterop.js"></script>
```

#### Create the schema in Index-component

```csharp
@code {
    string schema = @"{
      ""$schema"": ""http://adaptivecards.io/schemas/adaptive-card.json"",
      ""type"": ""AdaptiveCard"",
      ""version"": ""1.2"",
      ""body"": [
        {
          ""type"": ""TextBlock"",
          ""text"": ""Adaptive Cards for Blazor simple example""
        }
      ]
    }";
}
```

#### Render the card by adding component into page

```html
        <AdaptiveCard Schema="@schema"></AdaptiveCard>
```

## Result

![](2019-10-15-19-09-18.png)

## Full source code of index.razor

```html
@page "/"

<AdaptiveCard Schema="@schema"></AdaptiveCard>

@code{
    string schema = @"{
      ""$schema"": ""http://adaptivecards.io/schemas/adaptive-card.json"",
      ""type"": ""AdaptiveCard"",
      ""version"": ""1.2"",
      ""body"": [
        {
          ""type"": ""TextBlock"",
          ""text"": ""Adaptive Cards for Blazor simple example""
        }
      ]
    }";
}
```