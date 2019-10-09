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

#### Add JSON schema-file

Please make sure that it is copied to output directory.

Schema.json:

```json
{
  "$schema": "http://adaptivecards.io/schemas/adaptive-card.json",
  "type": "AdaptiveCard",
  "version": "1.0",
  "body": [
    {
      "type": "TextBlock",
      "text": "Warm",
      "size": "large",
      "isSubtle": true
    },
    {
      "type": "TextBlock",
      "text": "September 18, 7:30 AM",
      "spacing": "none"
    }
  ]
}
```

#### Load schema in component

```csharp
@code{
    string schema = "";

    protected override void OnInitialized()
    {
        schema = System.IO.File.ReadAllText("Schema.json");
    }
}
```

#### Render the card by adding component into page

```html
        <AdaptiveCard Schema="@schema" SubmitHandler="this"></AdaptiveCard>
```

## Result

![](2019-10-09-21-44-46.png)

## Full source code of index.razor

```html
@page "/"

<h1>Hello Adaptive Cards for Blazor!</h1>

Here's a card for displaying the weather:

<div class="row">
    <div class="col-3">
        <AdaptiveCard Schema="@schema"></AdaptiveCard>
    </div>
</div>

@code{
    string schema = "";

    protected override void OnInitialized()
    {
        schema = System.IO.File.ReadAllText("WeatherSchema.json");
    }
}
```