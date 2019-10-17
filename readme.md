## Introduction

Adaptive Cards for Blazor is a community project that provides Adaptive Cards support for your Blazor applications. 

![Adaptive Cards for Blazor Logo](https://raw.githubusercontent.com/mikoskinen/Blazor.AdaptiveCards/master/doc/logo_small.jpg)

[Adaptive Cards](https://adaptivecards.io/) are a way to exchange content in a common and consistent way. Adaptive Cards can be integrated into different applications like Microsoft Teams and Outlook. Adaptive Cards can also be integrated into custom applications built with .NET, iOS and JavaScript. And now Blazor, the new Web App platform from Microsoft is supported.

[![NuGet](https://img.shields.io/nuget/v/AdaptiveCardsBlazor.svg)](https://www.nuget.org/packages/AdaptiveCardsBlazor/)

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

## Roadmap

* ~~October 2019: 1.0.0~~
* October 2019: 1.1.0: Adds support for ToggleVisibility.
* November 2019: 2.0.0: Adds support for .NET Core 3.1.
* May 2020: 3.0.0-beta: Adds support for preview version of .NET 5 and adds a fully tested support for Blazor WebAssembly.
* November 2020: 3.0.0: Adds support for RTM version of .NET 5 and fully supports both the WebAssembly and Server versions of Blazor.

## Getting started

Getting Started guide is available through the [project's home site](https://adaptivecardsblazor.com/gettingstarted.html).

## Quick start

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

## Authors

Adaptive Cards for Blazor is created by [Mikael Koskinen](https://mikaelkoskinen.net).

Contributions are welcome!

## License

Adaptive Cards for Blazor is MIT licensed. The library uses the following other libraries:

* [AdaptiveCards.Rendering.Html](https://www.nuget.org/packages/AdaptiveCards.Rendering.Html): MIT-license
* [Scriban](https://www.nuget.org/packages/Scriban/): BSD 2-Clause "Simplified" License
