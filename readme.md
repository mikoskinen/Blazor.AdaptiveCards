## Introduction

Adaptive Cards for Blazor is a community project that provides Adaptive Cards support for your Blazor applications. [Adaptive Cards](https://adaptivecards.io/) are a way to exchange content in a common and consistent way. Adaptive Cards can be integrated into different applications like Microsoft Teams and Outlook. Adaptive Cards can also be integrated into custom applications built with .NET, iOS and JavaScript. And now Blazor, the new Web App platform from Microsoft is supported.

## Feature Highlights

Adaptive Cards for Blazor provides components for displaying Adaptive Cards inside your Blazor Application. Here's few of the most notable features of this library:

* **JSON-support**: Create and display Adaptive Cards from the JSON-schema.
* **Templating**: Combine models (objects) and the schema.
* **Card Collections**: Display a list of cards based on model and use template selector to customize the output.
* **Action support**: Handle Submit and OpenUrl actions using C#.
* **Native .NET-based solution**: Blazor Adaptive Cards is based on the official .NET SDK for Adaptive Cards. 

## Project home

Adaptive Cards for Blazor's home site is located at https://adaptivecardsblazor.com/.

Project's source code is available from [GitHub](https://github.com/mikoskinen/Blazor.AdaptiveCards). GitHub can be used to report any suggestions or issues.

## Requirements

Adaptive Cards for Blazor targets .NET Core 3.0. Please also note that the library has been tested with the server side version of Blazor.

## Getting started

Getting Started guide is available through the [project's home site](https://adaptivecardsblazor.com/gettingstarted.html).

## Quick start

#### Add NuGet

```csharp
Install-Package Elma AdaptiveCardsBlazor
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
```html

## Authors

Adaptive Cards for Blazor is created by [Mikael Koskinen](https://mikaelkoskinen.net).

Contributions are welcome!

## License

Adaptive Cards for Blazor is MIT licensed. The library uses the following other libraries:

* [AdaptiveCards.Rendering.Html](https://www.nuget.org/packages/AdaptiveCards.Rendering.Html): MIT-license
* [Scriban](https://www.nuget.org/packages/Scriban/): BSD 2-Clause "Simplified" License