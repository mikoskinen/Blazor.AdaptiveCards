---
order: 3
title: Default Template
---

TemplatedAdaptiveCard can accept the Schema as a property but it can also automatically select the template. This feature is called Default Template. The default template is set in the application's ConfigureServices and it's based on the model's type:

```csharp {.line-numbers}
services.AddBlazorAdaptiveCards()
    .AddTemplate<Customer>(Schemas.CustomerTemplated);
```

If default template is defined, TemplatedAdaptiveCard can be used without schema:

```html {.line-numbers}
<TemplatedAdaptiveCard Model="customer"></TemplatedAdaptiveCard>

@code{
    Customer customer = new Customer() { FirstName = "Templated", LastName = "Customer" };
}
```