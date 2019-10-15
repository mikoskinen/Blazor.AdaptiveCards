---
order: 0
title: Introduction to templating
---

Templating allows you to combine an adaptive card and a model (C# object). Template is a JSON schema. Model is any C# object. 

Templating works through the TemplatedAdaptiveCard-component:

```html {.line-numbers}
<TemplatedAdaptiveCard Schema="@Schemas.CustomerTemplated" Model="customer"></TemplatedAdaptiveCard>

@code{
    Customer customer = new Customer() { FirstName = "Templated", LastName = "Customer" };
}
```

### Syntax

The syntax for template is:

```json
{{ PropertyName }}
```

Given the following model:

```csharp
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }
    }
```

The syntax for displaying property **TemperatureC** is:

```json {.line-numbers}
        {
          "type": "Column",
          "width": "auto",
          "items": [
            {
              "type": "TextBlock",
              "text": "{{ TemperatureC }}",
              "size": "extraLarge",
              "spacing": "none"
            }
          ]
        },
```

The templating support in Adaptive Cards for Blazor is a custom-built solution, based on the [Scriban](https://github.com/lunet-io/scriban) templating language. You can use all the features of the Scriban in your Adaptive Cards, like built-in functions and if/else/for/while functionality.

**Note:** Adaptive Cards for .NET contains support for some built-in functions. The built-in functions use the same syntax as Scriban. This can cause issues. The recommended approach is to use Scriban's functions.