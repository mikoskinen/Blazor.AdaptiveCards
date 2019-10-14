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

        #region Official Samples

        public static string ActivityUpdate = @"{
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
              ""text"": ""Matt Hidinger"",
              ""weight"": ""bolder"",
              ""wrap"": true
            },
            {
              ""type"": ""TextBlock"",
              ""spacing"": ""none"",
              ""text"": ""Created {{DATE(2017-02-14T06:08:39Z, SHORT)}}"",
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
            ""type"": ""Input.Date"",
            ""id"": ""dueDate""
          }
        ],
        ""actions"": [
          {
            ""type"": ""Action.Submit"",
            ""title"": ""OK""
          }
        ]
      }
    },
    {
      ""type"": ""Action.ShowCard"",
      ""title"": ""Comment"",
      ""card"": {
        ""type"": ""AdaptiveCard"",
        ""body"": [
          {
            ""type"": ""Input.Text"",
            ""id"": ""comment"",
            ""isMultiline"": true,
            ""placeholder"": ""Enter your comment""
          }
        ],
        ""actions"": [
          {
            ""type"": ""Action.Submit"",
            ""title"": ""OK""
          }
        ]
      }
    }
  ]
}
";

        public static string CalendarUpdate = @"{
  ""$schema"": ""http://adaptivecards.io/schemas/adaptive-card.json"",
  ""type"": ""AdaptiveCard"",
  ""version"": ""1.0"",
  ""speak"": ""Your  meeting about \""Adaptive Card design session\"" is starting at 12:30pmDo you want to snooze  or do you want to send a late notification to the attendees?"",
  ""body"": [
    {
      ""type"": ""TextBlock"",
      ""text"": ""Adaptive Card design session"",
      ""size"": ""large"",
      ""weight"": ""bolder""
    },
    {
      ""type"": ""TextBlock"",
      ""text"": ""Conf Room 112/3377 (10)"",
      ""isSubtle"": true
    },
    {
      ""type"": ""TextBlock"",
      ""text"": ""12:30 PM - 1:30 PM"",
      ""isSubtle"": true,
      ""spacing"": ""none""
    },
    {
      ""type"": ""TextBlock"",
      ""text"": ""Snooze for""
    },
    {
      ""type"": ""Input.ChoiceSet"",
      ""id"": ""snooze"",
      ""style"": ""compact"",
      ""value"": ""5"",
      ""choices"": [
        {
          ""title"": ""5 minutes"",
          ""value"": ""5""
        },
        {
          ""title"": ""15 minutes"",
          ""value"": ""15""
        },
        {
          ""title"": ""30 minutes"",
          ""value"": ""30""
        }
      ]
    }
  ],
  ""actions"": [
    {
      ""type"": ""Action.Submit"",
      ""title"": ""Snooze"",
      ""data"": {
        ""x"": ""snooze""
      }
    },
    {
      ""type"": ""Action.Submit"",
      ""title"": ""I'll be late"",
      ""data"": {
        ""x"": ""late""
      }
    }
  ]
}
";

        public static string FlightItinerary = @"{
  ""$schema"": ""http://adaptivecards.io/schemas/adaptive-card.json"",
  ""version"": ""1.0"",
  ""type"": ""AdaptiveCard"",
  ""speak"": ""Your flight is confirmed for you and 3 other passengers from San Francisco to Amsterdam on Friday, October 10 8:30 AM"",
  ""body"": [
    {
      ""type"": ""TextBlock"",
      ""text"": ""Passengers"",
      ""weight"": ""bolder"",
      ""isSubtle"": false
    },
    {
      ""type"": ""TextBlock"",
      ""text"": ""Sarah Hum"",
      ""separator"": true
    },
    {
      ""type"": ""TextBlock"",
      ""text"": ""Jeremy Goldberg"",
      ""spacing"": ""none""
    },
    {
      ""type"": ""TextBlock"",
      ""text"": ""Evan Litvak"",
      ""spacing"": ""none""
    },
    {
      ""type"": ""TextBlock"",
      ""text"": ""2 Stops"",
      ""weight"": ""bolder"",
      ""spacing"": ""medium""
    },
    {
      ""type"": ""TextBlock"",
      ""text"": ""Fri, October 10 8:30 AM"",
      ""weight"": ""bolder"",
      ""spacing"": ""none""
    },
    {
      ""type"": ""ColumnSet"",
      ""separator"": true,
      ""columns"": [
        {
          ""type"": ""Column"",
          ""width"": 1,
          ""items"": [
            {
              ""type"": ""TextBlock"",
              ""text"": ""San Francisco"",
              ""isSubtle"": true
            },
            {
              ""type"": ""TextBlock"",
              ""size"": ""extraLarge"",
              ""color"": ""accent"",
              ""text"": ""SFO"",
              ""spacing"": ""none""
            }
          ]
        },
        {
          ""type"": ""Column"",
          ""width"": ""auto"",
          ""items"": [
            {
              ""type"": ""TextBlock"",
              ""text"": "" ""
            },
            {
              ""type"": ""Image"",
              ""url"": ""http://adaptivecards.io/content/airplane.png"",
              ""size"": ""small"",
              ""spacing"": ""none""
            }
          ]
        },
        {
          ""type"": ""Column"",
          ""width"": 1,
          ""items"": [
            {
              ""type"": ""TextBlock"",
              ""horizontalAlignment"": ""right"",
              ""text"": ""Amsterdam"",
              ""isSubtle"": true
            },
            {
              ""type"": ""TextBlock"",
              ""horizontalAlignment"": ""right"",
              ""size"": ""extraLarge"",
              ""color"": ""accent"",
              ""text"": ""AMS"",
              ""spacing"": ""none""
            }
          ]
        }
      ]
    },
    {
      ""type"": ""TextBlock"",
      ""text"": ""Non-Stop"",
      ""weight"": ""bolder"",
      ""spacing"": ""medium""
    },
    {
      ""type"": ""TextBlock"",
      ""text"": ""Fri, October 18 9:50 PM"",
      ""weight"": ""bolder"",
      ""spacing"": ""none""
    },
    {
      ""type"": ""ColumnSet"",
      ""separator"": true,
      ""columns"": [
        {
          ""type"": ""Column"",
          ""width"": 1,
          ""items"": [
            {
              ""type"": ""TextBlock"",
              ""text"": ""Amsterdam"",
              ""isSubtle"": true
            },
            {
              ""type"": ""TextBlock"",
              ""size"": ""extraLarge"",
              ""color"": ""accent"",
              ""text"": ""AMS"",
              ""spacing"": ""none""
            }
          ]
        },
        {
          ""type"": ""Column"",
          ""width"": ""auto"",
          ""items"": [
            {
              ""type"": ""TextBlock"",
              ""text"": "" ""
            },
            {
              ""type"": ""Image"",
              ""url"": ""http://adaptivecards.io/content/airplane.png"",
              ""size"": ""small"",
              ""spacing"": ""none""
            }
          ]
        },
        {
          ""type"": ""Column"",
          ""width"": 1,
          ""items"": [
            {
              ""type"": ""TextBlock"",
              ""horizontalAlignment"": ""right"",
              ""text"": ""San Francisco"",
              ""isSubtle"": true
            },
            {
              ""type"": ""TextBlock"",
              ""horizontalAlignment"": ""right"",
              ""size"": ""extraLarge"",
              ""color"": ""accent"",
              ""text"": ""SFO"",
              ""spacing"": ""none""
            }
          ]
        }
      ]
    },
    {
      ""type"": ""ColumnSet"",
      ""spacing"": ""medium"",
      ""columns"": [
        {
          ""type"": ""Column"",
          ""width"": ""1"",
          ""items"": [
            {
              ""type"": ""TextBlock"",
              ""text"": ""Total"",
              ""size"": ""medium"",
              ""isSubtle"": true
            }
          ]
        },
        {
          ""type"": ""Column"",
          ""width"": 1,
          ""items"": [
            {
              ""type"": ""TextBlock"",
              ""horizontalAlignment"": ""right"",
              ""text"": ""$4,032.54"",
              ""size"": ""medium"",
              ""weight"": ""bolder""
            }
          ]
        }
      ]
    }
  ]
}
";
        #endregion
    }
}
