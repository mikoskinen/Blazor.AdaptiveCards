---
order: 1
title: OpenUrl
---

OpenUrl action defines an action which navigates the user to an URL. Here's an example schema with an OpenUrl which takes user to Weather.com:

```json {.line-numbers}
"body": [
  ...
],
"actions": [
  {
    "type": "Action.OpenUrl",
    "title": "Open Weather Service",
    "url": "https://weather.com"
  }
]
```

Adaptive Cards for Blazor can automatically handle OpenUrl, meaning there's no need to define handler for the action:

```html {.line-numbers}
<AdaptiveCard Schema="@Schemas.WeatherOpenUrl"></AdaptiveCard>
```

When no handler is set, Adaptive Cards for Blazor automatically transfer the user to the URL.

It's possible to handle the navigation manually. This happens through OnOpenUrlAction:

```html {.line-numbers}
<AdaptiveCard OnOpenUrlAction="HandleOpenUrl" Schema="@Schemas.WeatherOpenUrl"></AdaptiveCard>

@if (!string.IsNullOrWhiteSpace(openUrl))
{
    <p class="alert alert-success">Navigating to: @openUrl</p>
}

@code {
    string openUrl;

    private void HandleOpenUrl(string url)
    {
        openUrl = url;
    }
}
```