---
order: 5
title: Template Selector
---

TemplateSelector allows you to define a function which selects the template based on some criteria. This is useful in scenarios where you have multiple schemas for a single type and fixed criteria of when to use which schema.

To use Template Select, first configure available schemas in application's ConfigureServices:

```csharp {.line-numbers}
services.AddBlazorAdaptiveCards()
    .AddTemplate<Customer>(Schemas.CustomerTemplated)
    .AddFileTemplate("Alternative", "AlternativeTemplatedAdaptiveCard.json");
```

Then use **TemplateSelector** property of TemplatedAdaptiveCard to define the selection criteria. ModelTemplateCatalog is useful in these scenarios as it can be used to get a schema by its name:

```html {.line-numbers}
<TemplatedAdaptiveCard TemplateSelector="SelectTemplate" Model="@(new Customer() { FirstName = "Templated", LastName = "Customer" })"></TemplatedAdaptiveCard>

<TemplatedAdaptiveCard TemplateSelector="SelectTemplate" Model="@(new Customer() { FirstName = "Second", LastName = "Customer" })"></TemplatedAdaptiveCard>

@code{
    [Inject]
    private IModelTemplateCatalog ModelTemplateCatalog { get; set; }

    private string SelectTemplate(object customer)
    {
        var cust = (Customer)customer;
        if (cust.FirstName.Contains("Second"))
        {
            return ModelTemplateCatalog.Get("Alternative");
        }

        return ModelTemplateCatalog.Get(customer.GetType().Name);
    }
}
```