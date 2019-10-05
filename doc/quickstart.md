---
order: 1
title: Quick Start
description: Adaptive Cards for Blazor is available as a NuGet package. This tutorial shows you can get started with the library.
---

## Introduction

Adaptive Cards for Blazor targets the server side version of Blazor, which was released in .NET Core 3.0. This tutorials gives you a quick run through of how to build a Blazor application which uses Adaptive Cards.

## The starting point

## The schema

Here's the JSON-schema we will be using in this tutorial:

```json {.line-numbers}
{
  "$schema": "http://adaptivecards.io/schemas/adaptive-card.json",
  "type": "AdaptiveCard",
  "version": "1.0",
  "body": [
    {
      "type": "TextBlock",
      "text": "Adaptive Cards for Blazor Sample Schema",
      "weight": "bolder",
      "size": "medium"
    },
    {
      "type": "ColumnSet",
      "columns": [
        {
          "type": "Column",
          "width": "auto",
          "items": [
            {
              "type": "Image",
              "url": "https://via.placeholder.com/400",
              "size": "small",
              "style": "person"
            }
          ]
        },
        {
          "type": "Column",
          "width": "stretch",
          "items": [
            {
              "type": "TextBlock",
              "text": "The Sample",
              "weight": "bolder",
              "wrap": true
            },
            {
              "type": "TextBlock",
              "spacing": "none",
              "text": "Created by Adaptive Cards for Blazor",
              "isSubtle": true,
              "wrap": true
            }
          ]
        }
      ]
    },
    {
      "type": "TextBlock",
      "text": "Adaptive Cards for Blazor supports JSON based schema. Highlights of its functionality include built-in support for templates and for card collections.",
      "wrap": true
    },
    {
      "type": "FactSet",
      "facts": [
        {
          "title": "Requirements:",
          "value": ".NET Core 3 & Server side Blazor"
        },
        {
          "title": "Project home:",
          "value": "https://github.com/mikoskinen/Blazor.AdaptiveCards"
        },
        {
          "title": "Author:",
          "value": "Mikael Koskinen"
        }
      ]
    }
  ]
}

```

We will be using the Flight Update sample, a simple JSON-schema from [Adaptive Cards' official sample site](https://adaptivecards.io/samples/). 


## Adding a submit action
## Feature Highlights

Blazor Adaptive Cards provides components for displaying daptive Cards inside your Blazor Application. Here's few of the most notable features of this library:

* **JSON-support**: Create and display Adaptive Cards from the JSON-schema.
* **Templating support**: Combine models (objects) and the schema.
* **Multi-card support**: Display a list of models and use template selector to customize the output.
* **Action support**: Handle submit and openlink actions using C#.
* **Native .NET-based solution**: Blazor Adaptive Cards is based on the official .NET SDK for Adaptive Cards. 

## Sample

Please note that the sample site runs on a slow Azure App Service so the provided performance may not be the best. You can run the samples locally by cloning the project repository from GitHub.

## Project home

Blazor Adaptive Cards source code is available from GitHub. GitHub can be used to report any suggestions or issues.

## Author

Blazor Adaptive Cards is created by [Mikael Koskinen](https://mikaelkoskinen.net).

Contributions are welcome!

## License

Blazor Adaptive Cards is MIT licensed. The library uses the following other libraries:

* [AdaptiveCards.Rendering.Html](https://www.nuget.org/packages/AdaptiveCards.Rendering.Html): MIT-license
* [Scriban](https://www.nuget.org/packages/Scriban/): BSD 2-Clause "Simplified" License