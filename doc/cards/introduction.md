---
order: 0
title: Introduction to Card Collections
---

Adaptive Cards for Blazor has a feature called Card Collections. Card Collections allow the developer to easily display a list of cards based on two things: **A list of models** and **a template**. Model can be any .NET object, like a Customer, Invoice or WeatherInfo. Template is a JSON schema. Card Collection takes a list of models, for example List<WeatherInfo> and the template and then binds each model against the schema. The end result is then rendered on the screen. 

![](2019-10-16-08-28-39.png)

*Note*: The templating support in Adaptive Cards for Blazor is a custom-built solution, based on the [Scriban](https://github.com/lunet-io/scriban) templating language. Adaptive Cards should at some point receive a native templating support.

Card Collection supported is provided by CardCollection component. Here's an example where CardCollection is used to display weather forecasts:

```html {.line-numbers}
@if (forecasts == null)
{
    <p><em>Loading...</em></p>
}
else
{
    <CardCollection Models="@forecasts" Schema="@Schemas.WeatherTemplated"></CardCollection>
}

@if (!string.IsNullOrWhiteSpace(actionDetails))
{
    <p class="alert alert-success mt-3" style="white-space: pre-wrap">@actionDetails</p>
}

@code {
    string actionDetails = "";
    WeatherForecast[] forecasts;
    string schema;

    protected override async Task OnInitializedAsync()
    {
        forecasts = await ForecastService.GetForecastAsync(DateTime.Now);
    }
}
```

Behind the scenes CardCollection uses TemplatedAdaptiveCard to create the cards. 