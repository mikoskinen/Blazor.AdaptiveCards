namespace AdaptiveCards.Blazor.Samples
{
    public static class Schemas
    {
        #region Weather
        public static string Weather = @"{
  ""$schema"": ""http://adaptivecards.io/schemas/adaptive-card.json"",
  ""type"": ""AdaptiveCard"",
  ""version"": ""1.0"",
  ""body"": [
    {
      ""type"": ""TextBlock"",
      ""text"": ""Warm"",
      ""size"": ""large"",
      ""isSubtle"": true
    },
    {
      ""type"": ""TextBlock"",
      ""text"": ""September 18, 7:30 AM"",
      ""spacing"": ""none""
    },
    {
      ""type"": ""ColumnSet"",
      ""columns"": [
        {
          ""type"": ""Column"",
          ""width"": ""auto"",
          ""items"": [
            {
              ""type"": ""Image"",
              ""url"": ""http://messagecardplayground.azurewebsites.net/assets/Mostly%20Cloudy-Square.png"",
              ""size"": ""small""
            }
          ]
        },
        {
          ""type"": ""Column"",
          ""width"": ""auto"",
          ""items"": [
            {
              ""type"": ""TextBlock"",
              ""text"": ""42"",
              ""size"": ""extraLarge"",
              ""spacing"": ""none""
            }
          ]
        },
        {
          ""type"": ""Column"",
          ""width"": ""stretch"",
          ""items"": [
            {
              ""type"": ""TextBlock"",
              ""text"": ""F"",
              ""weight"": ""bolder"",
              ""spacing"": ""small""
            }
          ]
        },
        {
          ""type"": ""Column"",
          ""width"": ""stretch"",
          ""items"": [
            {
              ""type"": ""TextBlock"",
              ""text"": ""Hi 51"",
              ""horizontalAlignment"": ""left""
            },
            {
              ""type"": ""TextBlock"",
              ""text"": ""Lo 40"",
              ""horizontalAlignment"": ""left"",
              ""spacing"": ""none""
            }
          ]
        }
      ]
    }
  ],
  ""actions"": [
    {
      ""type"": ""Action.OpenUrl"",
      ""title"": ""Open Weather Service"",
      ""url"": ""https://weather.com""
    },
    {
      ""type"": ""Action.ShowCard"",
      ""title"": ""Share..."",
      ""card"": {
        ""type"": ""AdaptiveCard"",
        ""body"": [
          {
            ""type"": ""TextBlock"",
            ""text"": ""Share with Email:""
          },
          {
            ""type"": ""Input.Text"",
            ""id"": ""emailAddress"",
            ""placeholder"": ""user@email.com""
          }
        ],
        ""actions"": [
          {
            ""type"": ""Action.Submit"",
            ""title"": ""Send Email""
          }
        ]
      }
    }
  ]
}";
        #endregion

        #region Templated Weather
        public static string WeatherTemplated = @"{
  ""$schema"": ""http://adaptivecards.io/schemas/adaptive-card.json"",
  ""type"": ""AdaptiveCard"",
  ""version"": ""1.0"",
  ""body"": [
    {
      ""type"": ""TextBlock"",
      ""text"": ""{{ Summary }}"",
      ""size"": ""large"",
      ""isSubtle"": true
    },
    {
      ""type"": ""TextBlock"",
      ""text"": ""{{ Date }}"",
      ""spacing"": ""none""
    },
    {
      ""type"": ""ColumnSet"",
      ""columns"": [
        {
          ""type"": ""Column"",
          ""width"": ""auto"",
          ""items"": [
            {
              ""type"": ""Image"",
              ""url"": ""http://messagecardplayground.azurewebsites.net/assets/Mostly%20Cloudy-Square.png"",
              ""size"": ""small""
            }
          ]
        },
        {
          ""type"": ""Column"",
          ""width"": ""auto"",
          ""items"": [
            {
              ""type"": ""TextBlock"",
              ""text"": ""{{ TemperatureF }}"",
              ""size"": ""extraLarge"",
              ""spacing"": ""none""
            }
          ]
        },
        {
          ""type"": ""Column"",
          ""width"": ""stretch"",
          ""items"": [
            {
              ""type"": ""TextBlock"",
              ""text"": ""F"",
              ""weight"": ""bolder"",
              ""spacing"": ""small""
            }
          ]
        },
        {
          ""type"": ""Column"",
          ""width"": ""auto"",
          ""items"": [
            {
              ""type"": ""TextBlock"",
              ""text"": ""{{ TemperatureC }}"",
              ""size"": ""extraLarge"",
              ""spacing"": ""none""
            }
          ]
        },
        {
          ""type"": ""Column"",
          ""width"": ""stretch"",
          ""items"": [
            {
              ""type"": ""TextBlock"",
              ""text"": ""C"",
              ""weight"": ""bolder"",
              ""spacing"": ""small""
            }
          ]
        }
      ]
    }
  ],
  ""actions"": [
    {
      ""type"": ""Action.OpenUrl"",
      ""title"": ""Open Weather Service"",
      ""url"": ""https://weather.com""
    },
    {
      ""type"": ""Action.ShowCard"",
      ""title"": ""Share..."",
      ""card"": {
        ""type"": ""AdaptiveCard"",
        ""body"": [
          {
            ""type"": ""TextBlock"",
            ""text"": ""Share with Email:""
          },
          {
            ""type"": ""Input.Text"",
            ""id"": ""emailAddress"",
            ""placeholder"": ""user@email.com""
          }
        ],
        ""actions"": [
          {
            ""type"": ""Action.Submit"",
            ""title"": ""Send Email""
          }
        ]
      }
    }
  ]
}
";
        #endregion

        #region Customer
        public static string CustomerTemplated = @"{
  ""$schema"": ""http://adaptivecards.io/schemas/adaptive-card.json"",
  ""type"": ""AdaptiveCard"",
  ""version"": ""1.0"",
  ""body"": [
    {
      ""type"": ""TextBlock"",
      ""text"": ""Publish Adaptive Card schema"",
      ""weight"": ""bolder"",
      ""size"": ""medium""
    },
    {
      ""type"": ""ColumnSet"",
      ""columns"": [
        {
          ""type"": ""Column"",
          ""width"": ""auto"",
          ""items"": [
            {
              ""type"": ""Image"",
              ""url"": ""https://pbs.twimg.com/profile_images/3647943215/d7f12830b3c17a5a9e4afcc370e3a37e_400x400.jpeg"",
              ""size"": ""small"",
              ""style"": ""person""
            }
          ]
        },
        {
          ""type"": ""Column"",
          ""width"": ""stretch"",
          ""items"": [
            {
              ""type"": ""TextBlock"",
              ""text"": ""{{FirstName}} {{LastName}}"",
              ""weight"": ""bolder"",
              ""wrap"": true
            },
            {
              ""type"": ""TextBlock"",
              ""spacing"": ""none"",
              ""text"": ""Created "",
              ""isSubtle"": true,
              ""wrap"": true
            }
          ]
        }
      ]
    },
    {
      ""type"": ""TextBlock"",
      ""text"": ""Now that we have defined the main rules and features of the format, we need to produce a schema and publish it to GitHub. The schema will be the starting point of our reference documentation."",
      ""wrap"": true
    },
    {
      ""type"": ""FactSet"",
      ""facts"": [
        {
          ""title"": ""Board:"",
          ""value"": ""Adaptive Card""
        },
        {
          ""title"": ""List:"",
          ""value"": ""Backlog""
        },
        {
          ""title"": ""Assigned to:"",
          ""value"": ""Matt Hidinger""
        },
        {
          ""title"": ""Due date:"",
          ""value"": ""Not set""
        }
      ]
    }
  ],
  ""actions"": [
    {
      ""type"": ""Action.ShowCard"",
      ""title"": ""Set due date"",
      ""card"": {
        ""type"": ""AdaptiveCard"",
        ""body"": [
          {
            ""type"": ""Input.Text"",
            ""id"": ""dueDate"",
            ""placeholder"": ""What date?""
          }
        ],
        ""actions"": [
          {
            ""type"": ""Action.Submit"",
            ""title"": ""OK"",
            ""data"": {
              ""x"": 13
            },
            ""name"": ""SaveDate""
          }
        ]
      }
    },
    {
      ""type"": ""Action.OpenUrl"",
      ""title"": ""Open link"",
      ""url"": ""https://www.youtube.com/watch?v=dQw4w9WgXcQ""
    }
  ]
}";
        #endregion
    }
}
