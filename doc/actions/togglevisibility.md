---
order: 4
title: ToggleVisibility
---

ToggleVisibility action can be used to show and hide card's elements. Unlike ShowCard, which can be used to display and hide a Card, ToggleVisibility can be used to control the visibility of individual Adaptive Card elements.

Adaptive Cards for Blazor automatically handles the ToggleVisibility action. Here's an example schema with ToggleVisibility:

```json {.line-numbers}
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
              "url": "http://messagecardplayground.azurewebsites.net/assets/Mostly%20Cloudy-Square.png",
              "size": "small",
              "visibility": false,
              "id": "weatherImage"
            }
          ]
        },
        {
          "type": "Column",
          "width": "auto",
          "items": [
            {
              "type": "TextBlock",
              "text": "42",
              "size": "extraLarge",
              "spacing": "none"
            }
          ]
        },
        {
          "type": "Column",
          "width": "stretch",
          "items": [
            {
              "type": "TextBlock",
              "text": "F",
              "weight": "bolder",
              "spacing": "small"
            }
          ]
        },
        {
          "type": "Column",
          "width": "stretch",
          "items": [
            {
              "type": "TextBlock",
              "text": "Hi 51",
              "horizontalAlignment": "left"
            },
            {
              "type": "TextBlock",
              "text": "Lo 40",
              "horizontalAlignment": "left",
              "spacing": "none"
            }
          ]
        }
      ]
    }
  ],
  "actions": [
    {
      "type": "Action.ToggleVisibility",
      "title": "Toggle Image",
      "targetElements": [ "weatherImage"]
    }
  ]
}  
```

Using the action doesn't require any code:

```csharp
<AdaptiveCard Schema="@Schemas.WeatherToggleVisibility"></AdaptiveCard>
```