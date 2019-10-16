---
order: 3
title: Performance tips
---

Adaptive Cards work by transforming a JSON schema into HTML. This takes time. Adaptive Cards for Blazor uses the Adaptive Cards for .NET SDK to create the cards so it can work as quickly as the underlying SDK. Unfortunately the SDK doesn't always provide a lightning fast rendering.

If you render just a single card, it's unlikely you notice a long delay, even if the JSON schema is complex. But, if you use Card Collections and display hundredths of cards in a single page, it's quite likely you start to see performance problems.

By default, an Adaptive Card is rendered before the page hosting the card is shown. In other words, the rendering happens in the **OnParametersSetAsync** of the component. In many ways this is the desired way as it means the card is fully visible when the user first sees the page.

There's an alternative mode for rendering the card. In this mode, card isn't rendered during OnParametersSetAsync but on **OnAfterRenderAsync**. This way the page can be shown to the user even though the card isn't yet ready. With a single card this causes flashing issues as the card first takes 0 pixels and after the render it expand to take the required space, making other HTML elements to jump into their new locations. But the alternative render mode can be a life saver when using Card Collections. 

These two render modes are called Synchronous and Asynchronous. By default Synchronous is used. To switch to the Asynchronous rendering, use **RenderMode** parameter:

```html {.line-numbers}
    <CardCollection Models="@Customers" RenderMode="RenderMode.Asynchronous"></CardCollection>
```html

Is Asynchronous rendering better than Synchronous? It depends on multiple factors:

* How many cards you are going to display
* How complicated is the schema
* Is it better for your user to first see an empty page

The recommended way is to start from Synchronous and to switch into Asynchronous if you need a better performance. And you quite likely need all the performance benefits if you're rendering more than 30 cards.

*Note:* Currently the RenderMode parameter is accessible only through CardCollection. You can't set RenderMode for a single AdaptiveCard. This may change in future.