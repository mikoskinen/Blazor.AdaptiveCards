---
order: 2
title: Submit
---

Submit actions are quite likely the most popular actions in Adaptive Cards. They allow you to gather some input from the user, like their name and address, and then to submit that data into your desired endpoint. 

The [Inputs sample](https://adaptivecards.io/samples/Inputs.html) at the Adaptive Cards' sample site gives a good representation of different input controls which are available through the schema.

Here's an example schema with a submit action:

```json {.line-numbers}
"body": [
  ...
],
"actions": [
  {
    "type": "Action.OpenUrl",
    "title": "Open Weather Service",
    "url": "https://weather.com"
  },
  {
    "type": "Action.ShowCard",
    "title": "Share...",
    "card": {
      "type": "AdaptiveCard",
      "body": [
        {
          "type": "TextBlock",
          "text": "Share with Email:"
        },
        {
          "type": "Input.Text",
          "id": "emailAddress",
          "placeholder": "user@email.com"
        }
      ],
      "actions": [
        {
          "type": "Action.Submit",
          "title": "Send Email"
        }
      ]
    }
  }
]
```

Adaptive Cards for Blazor offers two ways of handling the submitted data: Using the **OnSubmitAction** or the **SubmitHandler**.

### OnSubmitAction

OnSubmitAction is an EventCallBack provided by AdaptiveCard-component. To handle the callback, define a method which takes SubmitEventArgs as a parameter:

```csharp {.line-numbers}
    private void OnSubmit(AdaptiveCards.Blazor.Actions.SubmitEventArgs eventArgs)
    {
        ...
    }
```    

### SubmitHandler

With SubmitHandler you aren't limited to getting the submitted data through the SubmitEventArgs as you can take advantage of model binding. In it's simplest form, SubmitHandler requires that the handler contains a method called **Submit**:

```html {.line-numbers}
<AdaptiveCard Schema="@Schemas.SimpleSubmit" SubmitHandler="this"></AdaptiveCard>
@code {
    public Task Submit(AdaptiveCards.Blazor.Actions.SubmitEventArgs eventArgs)
    {
        ...

        StateHasChanged();
        return Task.CompletedTask;
    }
}
```    

The model binding feature of SubmitHandler binds the input fields against the method parameters. Given the following schema:

```json {.line-numbers}
{
  "$schema": "http://adaptivecards.io/schemas/adaptive-card.json",
  "type": "AdaptiveCard",
  "version": "1.0",
  "body": [
    {
      "type": "ColumnSet",
      "columns": [
        {
          "type": "Column",
          "items": [
            {
              "type": "TextBlock",
              "text": "Your name",
              "wrap": true
            },
            {
              "type": "Input.Text",
              "id": "myName",
              "placeholder": "Last, First"
            },
            {
              "type": "TextBlock",
              "text": "Your email",
              "wrap": true
            },
            {
              "type": "Input.Text",
              "id": "myEmail",
              "placeholder": "youremail@example.com",
              "style": "email"
            }
          ]
        }
      ]
    }
  ],
  "actions": [
    {
      "type": "Action.Submit",
      "title": "Submit",
      "name": "MySubmit"
    }
  ]
}
``` 

The Submit-method can match parameters to the input fields using their id:

```html {.line-numbers}
<AdaptiveCard Schema="@Schemas.SimpleSubmit" SubmitHandler="this"></AdaptiveCard>
@code {
    public Task Submit(string myName, string myEmail)
    {
        ...

        StateHasChanged();
        return Task.CompletedTask;
    }
}
```

## Card with multiple submit actions

An Adaptive Card can contain multiple submit actions by giving them unique **name**:

```json {.line-numbers}
  "actions": [
    {
      "type": "Action.Submit",
      "title": "Send",
      "name": "send"
    },
    {
      "type": "Action.Submit",
      "title": "Decline",
      "name": "decline"
    }
  ]
```

To handle multiple actions using OnSubmitAction, you can use SubmitEventArgs.Action. Here's an example where the code can differentiate between the two actions:

```html {.line-numbers}
<AdaptiveCard Schema="@Schemas.SimpleSubmitAndDecline" OnSubmitAction="OnSubmitAndDecline"></AdaptiveCard>

@code {
    private void OnSubmitAndDecline(AdaptiveCards.Blazor.Actions.SubmitEventArgs eventArgs)
    {
        if (eventArgs.Action == "send")
        {
            ...
        }
        else
        {
            ...
        }
    }
}
```

To handle multiple actions using SubmitHandler, define multiple methods and match the method names with the action names:
```html {.line-numbers}
<AdaptiveCard Schema="@Schemas.SimpleSubmitAndDecline" SubmitHandler="this"></AdaptiveCard>

@code {
    public Task Send(AdaptiveCards.Blazor.Actions.SubmitEventArgs eventArgs)
    {
        ...
        return Task.CompletedTask;
    }

    public Task Decline(AdaptiveCards.Blazor.Actions.SubmitEventArgs eventArgs)
    {
        ...
        return Task.CompletedTask;
    }
}
```
