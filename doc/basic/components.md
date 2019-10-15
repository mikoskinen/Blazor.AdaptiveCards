---
order: 2
title: Components
---

Adaptive Cards for Blazor contains three components:

## AdaptiveCard

AdaptiveCard-component is the basic building block in Adaptive Cards for Blazor. AdaptiveCard always requires a JSON schema in string-format. This is used to render the card. 

**Usage:**

```json {.line-numbers}
<AdaptiveCard Schema="@schema"></AdaptiveCard>
```

## TemplatedAdaptiveCard

TemplatedAdaptiveCard is a component which supports templating. Template is a JSON schema. TemplatedAdaptiveCard takes a model (C# object) and a template. The model is bound against the template schema. The end result is then rendered on the screen. 

*Note*: The templating support in Adaptive Cards for Blazor is a custom-built solution, based on the [Scriban](https://github.com/lunet-io/scriban) templating language. Adaptive Cards should at some point receive a native templating support and it's possible that at that point, Adaptive Cards for Blazor changes from Scriban to the official solution.

**Usage:**

```html {.line-numbers}
<TemplatedAdaptiveCard Model="customer" Schema="@schema"></TemplatedAdaptiveCard>

@code{
    string schema = "";
    Customer customer = new Customer() { FirstName = "My", LastName = "Name" };

    protected override void OnInitialized()
    {
        schema = System.IO.File.ReadAllText("TemplatedAdaptiveCard.json");
    }
}
```

## CardCollection

Adaptive Cards for Blazor has a feature called Card Collections. Card Collections allow the developer to easily display a list of cards based on two things: **A list of models** and **a template**. Model can be any .NET object, like a Customer. Template is a JSON schema. Card Collection takes a list of models, for example List<WeatherInfo> and the template and then binds each model against the schema. The end result is then rendered on the screen. 

**Usage:**

```html {.line-numbers}
@if (forecasts == null)
{
    <p><em>Loading...</em></p>
}
else
{
    @if (selectedForecast != null && !string.IsNullOrWhiteSpace(submittedTo))
    {
        <b>@selectedForecast.Date.ToShortDateString(): </b> @submittedTo
    }

    <CardCollection Models="@forecasts" Schema="@schema"></AdaptiveCards>
}

@code {
    WeatherForecast[] forecasts;
    string schema;

    protected override async Task OnInitializedAsync()
    {
        forecasts = await ForecastService.GetForecastAsync(DateTime.Now);
        schema = System.IO.File.ReadAllText("WeatherSchemaTemplate.json");
    }
}
```