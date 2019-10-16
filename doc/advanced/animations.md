---
order: 2
title: Animations
---

Adaptive Cards can be animated using CSS and JS libraries. Here's an example where [aos.js](https://michalsnik.github.io/aos/) is used to animate a Card Collection.

![](animatedcard.gif)

Here's a step by step guide of integrating AOS with Adaptive Cards for Blazor.

### Modify _Host.cshtml

Add the following lines into your _Host.cshtml header:

```html {.line-numbers}
    <link href="https://unpkg.com/aos@2.3.1/dist/aos.css" rel="stylesheet">
    <script src="https://unpkg.com/aos@2.3.1/dist/aos.js"></script>
```

And then the following lines just before the body-tag:

```html {.line-numbers}
    <script>
        AOS.init({
            once: true
        });
    </script>
```

### Add animation attributes

AOS uses attributes for defining how cards are animated. The **CardAttributes** and **CardAttributeFunctions** parameters of CardCollection are handy as they can be used to add the required attributes.

Here's an example which makes each card to fade up:

```html {.line-numbers}
@if (Customers?.Any() == true)
{
    <CardCollection Models="@Customers" CardAttributes="@AnimationAttributes"></CardCollection>
}

@code {
    private List<Customer> Customers = new List<Customer>();
    private Dictionary<string, object> AnimationAttributes = new Dictionary<string, object>() {
        { "data-aos", "fade-up" },
    };

    protected override void OnInitialized()
    {
        Customers.Clear();

        for (int i = 0; i < 10; i++)
        {
            Customers.Add(new Customer() { FirstName = $"Person {i}", LastName = "Lastname" });
        }
    }
}
```

This looks OK but every card is animated at the same time. To make the cards animate one after another, CardAttributeFunctions can be used to set a individual delay for each card:

```html {.line-numbers}
@if (Customers?.Any() == true)
{
    <Info>
        This sample shows how cards can be animated using aos.js
    </Info>
    <CardCollection Models="@Customers" CardAttributes="@AnimationAttributes"></CardCollection>

    <Info class="mt-4">
        This sample shows how cards can be animated one by one
    </Info>

    <CardCollection Models="@Customers" CardAttributes="@AnimationAttributes" CardAttributeFunctions="@AttributeFunctions"></CardCollection>
}

@code {
    private List<Customer> Customers = new List<Customer>();
    private Dictionary<string, object> AnimationAttributes = new Dictionary<string, object>() {
        { "data-aos", "fade-up" },
    };

    private List<(string, Func<int, object, object>)> AttributeFunctions = new List<(string, Func<int, object, object>)>() {
        ("data-aos-delay", (i, customer) => (i * 200).ToString())
    };

    protected override void OnInitialized()
    {
        Customers.Clear();

        for (int i = 0; i < 10; i++)
        {
            Customers.Add(new Customer() { FirstName = $"Person {i}", LastName = "Lastname" });
        }
    }
}
```