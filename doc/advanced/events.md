---
order: 0
title: Events
---

Adaptive Cards provide the following event callbacks:

* OnCardRendered
* OnCardRenderFailed
* OnSubmitAction
* OnOpenUrlAction

Example of OnCardRendered:

```html {.line-numbers}
    <AdaptiveCard Schema="@Schemas.Weather" OnCardRendered="HandleCardRendered"></AdaptiveCard>
    ...

@code {
    public void HandleCardRendered(AdaptiveCards.Blazor.Actions.CardRenderedEventArgs eventArgs)
    {
        ...
    }}    
```

Example of OnCardRenderFailed:

```html {.line-numbers}
    <AdaptiveCard Schema="broken schema" OnCardRenderFailed="HandleCardRenderFailed" ></AdaptiveCard>
    ...

@code {
    public void HandleCardRenderFailed(AdaptiveCards.Blazor.Actions.CardRenderFailedEventArgs eventArgs)
    {
        ...
    }
```

Example of OnSubmitAction:

```html {.line-numbers}
    <AdaptiveCard Schema="@Schemas.SimpleSubmit" OnSubmitAction="HandleSubmit"></AdaptiveCard>
    ...

@code {
    public void HandleSubmit(AdaptiveCards.Blazor.Actions.SubmitEventArgs eventArgs)
    {
        ...
    }
```

Example of OnOpenUrlAction:

```html {.line-numbers}
    <AdaptiveCard Schema="@Schemas.WeatherOpenUrl" OnOpenUrlAction="HandleOpenUrl"></AdaptiveCard>
    ...

@code {
    public void HandleOpenUrl(string url)
    {
        ...
    }
```