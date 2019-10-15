---
order: 4
title: Alternative Template
---

The template name used by TemplatedAdaptiveCard can be set through the TemplateName-property. This is useful in scenarios where you have a type with a Default Template set but you also want to display the same type with a different schema in some situations. 

To add multiple schemas for a type, configure them in application's ConfigureServices and give the alternative templates a name:

```csharp {.line-numbers}
services.AddBlazorAdaptiveCards()
    .AddTemplate<Customer>(Schemas.CustomerTemplated)
    .AddFileTemplate("Alternative", "AlternativeTemplatedAdaptiveCard.json");
```

If **TemplateName** is defined, TemplatedAdaptiveCard uses that schema instead of the default:

```html {.line-numbers}
<TemplatedAdaptiveCard TemplateName="Alternative" Model="customer"></TemplatedAdaptiveCard>

@code{
    Customer customer = new Customer() { FirstName = "Templated", LastName = "Customer" };
}
```