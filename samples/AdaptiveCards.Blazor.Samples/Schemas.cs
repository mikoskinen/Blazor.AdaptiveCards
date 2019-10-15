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
        public static string WeatherShowCard = @"{
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
        public static string WeatherOpenUrl = @"{
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
        public static string CalendarReminder = @"{
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
        public static string FlightUpdate = @"{
  ""$schema"": ""http://adaptivecards.io/schemas/adaptive-card.json"",
  ""type"": ""AdaptiveCard"",
  ""version"": ""1.0"",
  ""speak"": ""Flight KL0605 to San Fransisco has been delayed.It will not leave until 10:10 AM."",
  ""body"": [
    {
      ""type"": ""ColumnSet"",
      ""columns"": [
        {
          ""type"": ""Column"",
          ""width"": ""auto"",
          ""items"": [
            {
              ""type"": ""Image"",
              ""size"": ""small"",
              ""url"": ""http://adaptivecards.io/content/airplane.png""
            }
          ]
        },
        {
          ""type"": ""Column"",
          ""width"": ""stretch"",
          ""items"": [
            {
              ""type"": ""TextBlock"",
              ""text"": ""Flight Status"",
              ""horizontalAlignment"": ""right"",
              ""isSubtle"": true
            },
            {
              ""type"": ""TextBlock"",
              ""text"": ""DELAYED"",
              ""horizontalAlignment"": ""right"",
              ""spacing"": ""none"",
              ""size"": ""large"",
              ""color"": ""attention""
            }
          ]
        }
      ]
    },
    {
      ""type"": ""ColumnSet"",
      ""separator"": true,
      ""spacing"": ""medium"",
      ""columns"": [
        {
          ""type"": ""Column"",
          ""width"": ""stretch"",
          ""items"": [
            {
              ""type"": ""TextBlock"",
              ""text"": ""Passengers"",
              ""isSubtle"": true,
              ""weight"": ""bolder""
            },
            {
              ""type"": ""TextBlock"",
              ""text"": ""Sarah Hum"",
              ""spacing"": ""small""
            },
            {
              ""type"": ""TextBlock"",
              ""text"": ""Jeremy Goldberg"",
              ""spacing"": ""small""
            },
            {
              ""type"": ""TextBlock"",
              ""text"": ""Evan Litvak"",
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
              ""text"": ""Seat"",
              ""horizontalAlignment"": ""right"",
              ""isSubtle"": true,
              ""weight"": ""bolder""
            },
            {
              ""type"": ""TextBlock"",
              ""text"": ""14A"",
              ""horizontalAlignment"": ""right"",
              ""spacing"": ""small""
            },
            {
              ""type"": ""TextBlock"",
              ""text"": ""14B"",
              ""horizontalAlignment"": ""right"",
              ""spacing"": ""small""
            },
            {
              ""type"": ""TextBlock"",
              ""text"": ""14C"",
              ""horizontalAlignment"": ""right"",
              ""spacing"": ""small""
            }
          ]
        }
      ]
    },
    {
      ""type"": ""ColumnSet"",
      ""spacing"": ""medium"",
      ""separator"": true,
      ""columns"": [
        {
          ""type"": ""Column"",
          ""width"": 1,
          ""items"": [
            {
              ""type"": ""TextBlock"",
              ""text"": ""Flight"",
              ""isSubtle"": true,
              ""weight"": ""bolder""
            },
            {
              ""type"": ""TextBlock"",
              ""text"": ""KL0605"",
              ""spacing"": ""small""
            }
          ]
        },
        {
          ""type"": ""Column"",
          ""width"": 1,
          ""items"": [
            {
              ""type"": ""TextBlock"",
              ""text"": ""Departs"",
              ""isSubtle"": true,
              ""horizontalAlignment"": ""center"",
              ""weight"": ""bolder""
            },
            {
              ""type"": ""TextBlock"",
              ""text"": ""10:10 AM"",
              ""color"": ""attention"",
              ""weight"": ""bolder"",
              ""horizontalAlignment"": ""center"",
              ""spacing"": ""small""
            }
          ]
        },
        {
          ""type"": ""Column"",
          ""width"": 1,
          ""items"": [
            {
              ""type"": ""TextBlock"",
              ""text"": ""Arrives"",
              ""isSubtle"": true,
              ""horizontalAlignment"": ""right"",
              ""weight"": ""bolder""
            },
            {
              ""type"": ""TextBlock"",
              ""text"": ""12:00 AM"",
              ""color"": ""attention"",
              ""horizontalAlignment"": ""right"",
              ""weight"": ""bolder"",
              ""spacing"": ""small""
            }
          ]
        }
      ]
    },
    {
      ""type"": ""ColumnSet"",
      ""spacing"": ""medium"",
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
              ""text"": ""AMS"",
              ""size"": ""extraLarge"",
              ""color"": ""accent"",
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
              ""text"": "" ""
            },
            {
              ""type"": ""Image"",
              ""url"": ""http://adaptivecards.io/content/airplane.png"",
              ""size"": ""small""
            }
          ]
        },
        {
          ""type"": ""Column"",
          ""width"": 1,
          ""items"": [
            {
              ""type"": ""TextBlock"",
              ""text"": ""San Francisco"",
              ""isSubtle"": true,
              ""horizontalAlignment"": ""right""
            },
            {
              ""type"": ""TextBlock"",
              ""text"": ""SFO"",
              ""horizontalAlignment"": ""right"",
              ""size"": ""extraLarge"",
              ""color"": ""accent"",
              ""spacing"": ""none""
            }
          ]
        }
      ]
    }
  ]
}
";

        public static string FoodOrder = @"{
  ""$schema"": ""http://adaptivecards.io/schemas/adaptive-card.json"",
  ""type"": ""AdaptiveCard"",
  ""version"": ""1.0"",
  ""body"": [
    {
      ""type"": ""TextBlock"",
      ""text"": ""Your registration is almost complete"",
      ""size"": ""medium"",
      ""weight"": ""bolder""
    },
    {
      ""type"": ""TextBlock"",
      ""text"": ""What type of food do you prefer?"",
      ""wrap"": true
    },
    {
      ""type"": ""ImageSet"",
      ""imageSize"": ""medium"",
      ""images"": [
        {
          ""type"": ""Image"",
          ""url"": ""http://contososcubademo.azurewebsites.net/assets/steak.jpg""
        },
        {
          ""type"": ""Image"",
          ""url"": ""http://contososcubademo.azurewebsites.net/assets/chicken.jpg""
        },
        {
          ""type"": ""Image"",
          ""url"": ""http://contososcubademo.azurewebsites.net/assets/tofu.jpg""
        }
      ]
    }
  ],
  ""actions"": [
    {
      ""type"": ""Action.ShowCard"",
      ""title"": ""Steak"",
      ""card"": {
        ""type"": ""AdaptiveCard"",
        ""body"": [
          {
            ""type"": ""TextBlock"",
            ""text"": ""How would you like your steak prepared?"",
            ""size"": ""medium"",
            ""wrap"": true
          },
          {
            ""type"": ""Input.ChoiceSet"",
            ""id"": ""SteakTemp"",
            ""style"": ""expanded"",
            ""choices"": [
              {
                ""title"": ""Rare"",
                ""value"": ""rare""
              },
              {
                ""title"": ""Medium-Rare"",
                ""value"": ""medium-rare""
              },
              {
                ""title"": ""Well-done"",
                ""value"": ""well-done""
              }
            ]
          },
          {
            ""type"": ""Input.Text"",
            ""id"": ""SteakOther"",
            ""isMultiline"": true,
            ""placeholder"": ""Any other preparation requests?""
          }
        ],
        ""actions"": [
          {
            ""type"": ""Action.Submit"",
            ""title"": ""OK"",
            ""data"": {
              ""FoodChoice"": ""Steak""
            }
          }
        ]
      }
    },
    {
      ""type"": ""Action.ShowCard"",
      ""title"": ""Chicken"",
      ""card"": {
        ""type"": ""AdaptiveCard"",
        ""body"": [
          {
            ""type"": ""TextBlock"",
            ""text"": ""Do you have any allergies?"",
            ""size"": ""medium"",
            ""wrap"": true
          },
          {
            ""type"": ""Input.ChoiceSet"",
            ""id"": ""ChickenAllergy"",
            ""style"": ""expanded"",
            ""isMultiSelect"": true,
            ""choices"": [
              {
                ""title"": ""I'm allergic to peanuts"",
                ""value"": ""peanut""
              }
            ]
          },
          {
            ""type"": ""Input.Text"",
            ""id"": ""ChickenOther"",
            ""isMultiline"": true,
            ""placeholder"": ""Any other preparation requests?""
          }
        ],
        ""actions"": [
          {
            ""type"": ""Action.Submit"",
            ""title"": ""OK"",
            ""data"": {
              ""FoodChoice"": ""Chicken""
            }
          }
        ]
      }
    },
    {
      ""type"": ""Action.ShowCard"",
      ""title"": ""Tofu"",
      ""card"": {
        ""type"": ""AdaptiveCard"",
        ""body"": [
          {
            ""type"": ""TextBlock"",
            ""text"": ""Would you like it prepared vegan?"",
            ""size"": ""medium"",
            ""wrap"": true
          },
          {
            ""type"": ""Input.Toggle"",
            ""id"": ""Vegetarian"",
            ""title"": ""Please prepare it vegan"",
            ""valueOn"": ""vegan"",
            ""valueOff"": ""notVegan""
          },
          {
            ""type"": ""Input.Text"",
            ""id"": ""VegOther"",
            ""isMultiline"": true,
            ""placeholder"": ""Any other preparation requests?""
          }
        ],
        ""actions"": [
          {
            ""type"": ""Action.Submit"",
            ""title"": ""OK"",
            ""data"": {
              ""FoodChoice"": ""Vegetarian""
            }
          }
        ]
      }
    }
  ]
}
";
        public static string ImageGallery = @"{
  ""$schema"": ""http://adaptivecards.io/schemas/adaptive-card.json"",
  ""type"": ""AdaptiveCard"",
  ""version"": ""1.0"",
  ""body"": [
    {
      ""type"": ""TextBlock"",
      ""text"": ""Here are some cool photos"",
      ""size"": ""large""
    },
    {
      ""type"": ""TextBlock"",
      ""text"": ""Sorry some of them are repeats"",
      ""size"": ""medium"",
      ""weight"": ""lighter""
    },
    {
      ""type"": ""ImageSet"",
      ""imageSize"": ""medium"",
      ""images"": [
        {
          ""type"": ""Image"",
          ""url"": ""https://picsum.photos/200/200?image=100""
        },
        {
          ""type"": ""Image"",
          ""url"": ""https://picsum.photos/300/200?image=200""
        },
        {
          ""type"": ""Image"",
          ""url"": ""https://picsum.photos/300/200?image=301""
        },
        {
          ""type"": ""Image"",
          ""url"": ""https://picsum.photos/200/200?image=400""
        },
        {
          ""type"": ""Image"",
          ""url"": ""https://picsum.photos/300/200?image=500""
        },
        {
          ""type"": ""Image"",
          ""url"": ""https://picsum.photos/200/200?image=600""
        },
        {
          ""type"": ""Image"",
          ""url"": ""https://picsum.photos/300/200?image=700""
        },
        {
          ""type"": ""Image"",
          ""url"": ""https://picsum.photos/300/200?image=800""
        },
        {
          ""type"": ""Image"",
          ""url"": ""https://picsum.photos/300/200?image=900""
        }
      ]
    }
  ]
}
";
        public static string InputForm = @"{
  ""$schema"": ""http://adaptivecards.io/schemas/adaptive-card.json"",
  ""type"": ""AdaptiveCard"",
  ""version"": ""1.0"",
  ""body"": [
    {
      ""type"": ""ColumnSet"",
      ""columns"": [
        {
          ""type"": ""Column"",
          ""width"": 2,
          ""items"": [
            {
              ""type"": ""TextBlock"",
              ""text"": ""Tell us about yourself"",
              ""weight"": ""bolder"",
              ""size"": ""medium""
            },
            {
              ""type"": ""TextBlock"",
              ""text"": ""We just need a few more details to get you booked for the trip of a lifetime!"",
              ""isSubtle"": true,
              ""wrap"": true
            },
            {
              ""type"": ""TextBlock"",
              ""text"": ""Don't worry, we'll never share or sell your information."",
              ""isSubtle"": true,
              ""wrap"": true,
              ""size"": ""small""
            },
            {
              ""type"": ""TextBlock"",
              ""text"": ""Your name"",
              ""wrap"": true
            },
            {
              ""type"": ""Input.Text"",
              ""id"": ""myName"",
              ""placeholder"": ""Last, First""
            },
            {
              ""type"": ""TextBlock"",
              ""text"": ""Your email"",
              ""wrap"": true
            },
            {
              ""type"": ""Input.Text"",
              ""id"": ""myEmail"",
              ""placeholder"": ""youremail@example.com"",
              ""style"": ""email""
            },
            {
              ""type"": ""TextBlock"",
              ""text"": ""Phone Number""
            },
            {
              ""type"": ""Input.Text"",
              ""id"": ""myTel"",
              ""placeholder"": ""xxx.xxx.xxxx"",
              ""style"": ""tel""
            }
          ]
        },
        {
          ""type"": ""Column"",
          ""width"": 1,
          ""items"": [
            {
              ""type"": ""Image"",
              ""url"": ""https://upload.wikimedia.org/wikipedia/commons/b/b2/Diver_Silhouette%2C_Great_Barrier_Reef.jpg"",
              ""size"": ""auto""
            }
          ]
        }
      ]
    }
  ],
  ""actions"": [
    {
      ""type"": ""Action.Submit"",
      ""title"": ""Submit""
    }
  ]
}
";
        public static string Inputs = @"{
	""$schema"": ""http://adaptivecards.io/schemas/adaptive-card.json"",
	""type"": ""AdaptiveCard"",
	""version"": ""1.0"",
	""body"": [
		{
			""type"": ""TextBlock"",
			""size"": ""medium"",
			""weight"": ""bolder"",
			""text"": ""Input.Text elements"",
			""horizontalAlignment"": ""center""
		},
		{
			""type"": ""Input.Text"",
			""placeholder"": ""Name"",
			""style"": ""text"",
			""maxLength"": 0,
			""id"": ""SimpleVal""
		},
		{
			""type"": ""Input.Text"",
			""placeholder"": ""Homepage"",
			""style"": ""url"",
			""maxLength"": 0,
			""id"": ""UrlVal""
		},
		{
			""type"": ""Input.Text"",
			""placeholder"": ""Email"",
			""style"": ""email"",
			""maxLength"": 0,
			""id"": ""EmailVal""
		},
		{
			""type"": ""Input.Text"",
			""placeholder"": ""Phone"",
			""style"": ""tel"",
			""maxLength"": 0,
			""id"": ""TelVal""
		},
		{
			""type"": ""Input.Text"",
			""placeholder"": ""Comments"",
			""style"": ""text"",
			""isMultiline"": true,
			""maxLength"": 0,
			""id"": ""MultiLineVal""
		},
		{
			""type"": ""Input.Number"",
			""placeholder"": ""Quantity"",
			""min"": -5,
			""max"": 5,
			""value"": 1,
			""id"": ""NumVal""
		},
		{
			""type"": ""Input.Date"",
			""placeholder"": ""Due Date"",
			""id"": ""DateVal"",
			""value"": ""2017-09-20""
		},
		{
			""type"": ""Input.Time"",
			""placeholder"": ""Start time"",
			""id"": ""TimeVal"",
			""value"": ""16:59""
		},
		{
			""type"": ""TextBlock"",
			""size"": ""medium"",
			""weight"": ""bolder"",
			""text"": ""Input.ChoiceSet"",
			""horizontalAlignment"": ""center""
		},
		{
			""type"": ""TextBlock"",
			""text"": ""What color do you want? (compact)""
		},
		{
			""type"": ""Input.ChoiceSet"",
			""id"": ""CompactSelectVal"",
			""style"": ""compact"",
			""value"": ""1"",
			""choices"": [
				{
					""title"": ""Red"",
					""value"": ""1""
				},
				{
					""title"": ""Green"",
					""value"": ""2""
				},
				{
					""title"": ""Blue"",
					""value"": ""3""
				}
			]
		},
		{
			""type"": ""TextBlock"",
			""text"": ""What color do you want? (expanded)""
		},
		{
			""type"": ""Input.ChoiceSet"",
			""id"": ""SingleSelectVal"",
			""style"": ""expanded"",
			""value"": ""1"",
			""choices"": [
				{
					""title"": ""Red"",
					""value"": ""1""
				},
				{
					""title"": ""Green"",
					""value"": ""2""
				},
				{
					""title"": ""Blue"",
					""value"": ""3""
				}
			]
		},
		{
			""type"": ""TextBlock"",
			""text"": ""What colors do you want? (multiselect)""
		},
		{
			""type"": ""Input.ChoiceSet"",
			""id"": ""MultiSelectVal"",
			""isMultiSelect"": true,
			""value"": ""1,3"",
			""choices"": [
				{
					""title"": ""Red"",
					""value"": ""1""
				},
				{
					""title"": ""Green"",
					""value"": ""2""
				},
				{
					""title"": ""Blue"",
					""value"": ""3""
				}
			]
		},
		{
			""type"": ""TextBlock"",
			""size"": ""medium"",
			""weight"": ""bolder"",
			""text"": ""Input.Toggle"",
			""horizontalAlignment"": ""center""
		},
		{
			""type"": ""Input.Toggle"",
			""title"": ""I accept the terms and conditions (True/False)"",
			""valueOn"": ""true"",
			""valueOff"": ""false"",
			""id"": ""AcceptsTerms""
		},
		{
			""type"": ""Input.Toggle"",
			""title"": ""Red cars are better than other cars"",
			""valueOn"": ""RedCars"",
			""valueOff"": ""NotRedCars"",
			""id"": ""ColorPreference""
		}
	],
	""actions"": [
		{
			""type"": ""Action.Submit"",
			""title"": ""Submit"",
			""data"": {
				""id"": ""1234567890""
			}
		},
		{
			""type"": ""Action.ShowCard"",
			""title"": ""Show Card"",
			""card"": {
				""type"": ""AdaptiveCard"",
				""body"": [
					{
						""type"": ""Input.Text"",
						""placeholder"": ""enter comment"",
						""style"": ""text"",
						""maxLength"": 0,
						""id"": ""CommentVal""
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
        public static string Restaurant = @"{
  ""$schema"": ""http://adaptivecards.io/schemas/adaptive-card.json"",
  ""type"": ""AdaptiveCard"",
  ""version"": ""1.0"",
  ""body"": [
    {
      ""type"": ""ColumnSet"",
      ""columns"": [
        {
          ""type"": ""Column"",
          ""width"": 2,
          ""items"": [
            {
              ""type"": ""TextBlock"",
              ""text"": ""PIZZA""
            },
            {
              ""type"": ""TextBlock"",
              ""text"": ""Tom's Pie"",
              ""weight"": ""bolder"",
              ""size"": ""extraLarge"",
              ""spacing"": ""none""
            },
            {
              ""type"": ""TextBlock"",
              ""text"": ""4.2 ★★★☆ (93) · $$"",
              ""isSubtle"": true,
              ""spacing"": ""none""
            },
            {
              ""type"": ""TextBlock"",
              ""text"": ""**Matt H. said** \""I'm compelled to give this place 5 stars due to the number of times I've chosen to eat here this past year!\"""",
              ""size"": ""small"",
              ""wrap"": true
            }
          ]
        },
        {
          ""type"": ""Column"",
          ""width"": 1,
          ""items"": [
            {
              ""type"": ""Image"",
              ""url"": ""https://picsum.photos/300?image=882"",
              ""size"": ""auto""
            }
          ]
        }
      ]
    }
  ],
  ""actions"": [
    {
      ""type"": ""Action.OpenUrl"",
      ""title"": ""More Info"",
      ""url"": ""https://www.youtube.com/watch?v=dQw4w9WgXcQ""
    }
  ]
}
";
        public static string Solitaire = @"{
  ""$schema"": ""http://adaptivecards.io/schemas/adaptive-card.json"",
  ""type"": ""AdaptiveCard"",
  ""version"": ""0.5"",
  ""backgroundImage"": ""https://download-ssl.msgamestudios.com/content/mgs/ce/production/SolitaireWin10/dev/adapative_card_assets/v1/card_background.png"",
  ""body"": [
    {
      ""type"": ""ColumnSet"",
      ""columns"": [
        {
          ""type"": ""Column"",
          ""width"": 1,
          ""items"": [
            {
              ""type"": ""Image"",
              ""url"": ""https://download-ssl.msgamestudios.com/content/mgs/ce/production/SolitaireWin10/dev/adapative_card_assets/v1/tile_spider.png"",
              ""size"": ""stretch""
            }
          ]
        },
        {
          ""type"": ""Column"",
          ""width"": 1,
          ""items"": [
            {
              ""type"": ""TextBlock"",
              ""text"": ""Click here to play another game of Spider in Microsoft Solitaire Collection!"",
              ""color"": ""light"",
              ""weight"": ""bolder"",
              ""wrap"": true,
              ""size"": ""default"",
              ""horizontalAlignment"": ""center""
            }
          ]
        }
      ]
    }
  ]
}
";
        public static string SportingEvent = @"{
  ""$schema"": ""http://adaptivecards.io/schemas/adaptive-card.json"",
  ""type"": ""AdaptiveCard"",
  ""version"": ""1.0"",
  ""speak"": ""The Seattle Seahawks beat the Carolina Panthers 40-7"",
  ""body"": [
    {
      ""type"": ""Container"",
      ""items"": [
        {
          ""type"": ""ColumnSet"",
          ""columns"": [
            {
              ""type"": ""Column"",
              ""width"": ""auto"",
              ""items"": [
                {
                  ""type"": ""Image"",
                  ""url"": ""http://adaptivecards.io/content/cats/3.png"",
                  ""size"": ""medium""
                },
                  {
                  ""type"": ""TextBlock"",
                  ""text"": ""SHADES"",
                  ""horizontalAlignment"": ""center"",
                  ""weight"": ""bolder""
                }
              ]
            },
            {
              ""type"": ""Column"",
              ""width"": ""stretch"",
              ""separator"": true,
              ""spacing"": ""medium"",
              ""items"": [
                {
                  ""type"": ""TextBlock"",
                  ""text"": ""Dec 4"",
                  ""horizontalAlignment"": ""center""
                },
                {
                  ""type"": ""TextBlock"",
                  ""text"": ""Final"",
                  ""spacing"": ""none"",
                  ""horizontalAlignment"": ""center""
                },
                {
                  ""type"": ""TextBlock"",
                  ""text"": ""7 - 40"",
                  ""size"": ""extraLarge"",
                  ""horizontalAlignment"": ""center""
                }
              ]
            },
            {
              ""type"": ""Column"",
              ""width"": ""auto"",
              ""separator"": true,
              ""spacing"": ""medium"",
              ""items"": [
                {
                  ""type"": ""Image"",
                  ""url"": ""http://adaptivecards.io/content/cats/2.png"",
                  ""size"": ""medium"",
                  ""horizontalAlignment"": ""center""
                },
                {
                  ""type"": ""TextBlock"",
                  ""text"": ""SKINS"",
                  ""horizontalAlignment"": ""center"",
                  ""weight"": ""bolder""
                }
              ]
            }
          ]
        }
      ]
    }
  ]
}
";
        public static string StockUpdate = @"{
  ""$schema"": ""http://adaptivecards.io/schemas/adaptive-card.json"",
  ""type"": ""AdaptiveCard"",
  ""version"": ""1.0"",
  ""speak"": ""Microsoft stock is trading at $62.30 a share, which is down .32%"",
  ""body"": [
    {
      ""type"": ""Container"",
      ""items"": [
        {
          ""type"": ""TextBlock"",
          ""text"": ""Microsoft Corp (NASDAQ: MSFT)"",
          ""size"": ""medium"",
          ""isSubtle"": true
        },
        {
          ""type"": ""TextBlock"",
          ""text"": ""September 19, 4:00 PM EST"",
          ""isSubtle"": true
        }
      ]
    },
    {
      ""type"": ""Container"",
      ""spacing"": ""none"",
      ""items"": [
        {
          ""type"": ""ColumnSet"",
          ""columns"": [
            {
              ""type"": ""Column"",
              ""width"": ""stretch"",
              ""items"": [
                {
                  ""type"": ""TextBlock"",
                  ""text"": ""75.30"",
                  ""size"": ""extraLarge""
                },
                {
                  ""type"": ""TextBlock"",
                  ""text"": ""▼ 0.20 (0.32%)"",
                  ""size"": ""small"",
                  ""color"": ""attention"",
                  ""spacing"": ""none""
                }
              ]
            },
            {
              ""type"": ""Column"",
              ""width"": ""auto"",
              ""items"": [
                {
                  ""type"": ""FactSet"",
                  ""facts"": [
                    {
                      ""title"": ""Open"",
                      ""value"": ""62.24""
                    },
                    {
                      ""title"": ""High"",
                      ""value"": ""62.98""
                    },
                    {
                      ""title"": ""Low"",
                      ""value"": ""62.20""
                    }
                  ]
                }
              ]
            }
          ]
        }
      ]
    }
  ]
}
";
        public static string WeatherCompact = @"{
  ""$schema"": ""http://adaptivecards.io/schemas/adaptive-card.json"",
  ""type"": ""AdaptiveCard"",
  ""version"": ""1.0"",
  ""speak"": ""The forecast for Seattle January 20 is mostly clear with a High of 51 degrees and Low of 40 degrees"",
  ""body"": [
    {
      ""type"": ""TextBlock"",
      ""text"": ""Seattle, WA"",
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
              ""text"": ""°F"",
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
  ]
}
";
        public static string WeatherLarge = @"{
  ""$schema"": ""http://adaptivecards.io/schemas/adaptive-card.json"",
  ""type"": ""AdaptiveCard"",
  ""version"": ""1.0"",
  ""speak"": ""Weather forecast for Monday is high of 62 and low of 42 degrees with a 20% chance of rainWinds will be 5 mph from the northeast"",
  ""backgroundImage"": ""http://messagecardplayground.azurewebsites.net/assets/Mostly%20Cloudy-Background-Dark.jpg"",
  ""body"": [
    {
      ""type"": ""ColumnSet"",
      ""columns"": [
        {
          ""type"": ""Column"",
          ""width"": ""35"",
          ""items"": [
            {
              ""type"": ""Image"",
              ""url"": ""http://messagecardplayground.azurewebsites.net/assets/Mostly%20Cloudy-Square.png"",
              ""size"": ""stretch""
            }
          ]
        },
        {
          ""type"": ""Column"",
          ""width"": ""65"",
          ""items"": [
            {
              ""type"": ""TextBlock"",
              ""text"": ""Monday April 1"",
              ""weight"": ""bolder"",
              ""size"": ""large"",
              ""color"": ""light""
            },
            {
              ""type"": ""TextBlock"",
              ""text"": ""63 / 42"",
              ""size"": ""medium"",
              ""spacing"": ""none""
            },
            {
              ""type"": ""TextBlock"",
              ""isSubtle"": true,
              ""text"": ""20% chance of rain"",
              ""spacing"": ""none""
            },
            {
              ""type"": ""TextBlock"",
              ""isSubtle"": true,
              ""text"": ""Winds 5 mph NE"",
              ""spacing"": ""none""
            }
          ]
        }
      ]
    },
    {
      ""type"": ""ColumnSet"",
      ""columns"": [
        {
          ""type"": ""Column"",
          ""width"": ""20"",
          ""items"": [
            {
              ""type"": ""TextBlock"",
              ""horizontalAlignment"": ""center"",
              ""wrap"": false,
              ""text"": ""Fri""
            },
            {
              ""type"": ""Image"",
              ""size"": ""auto"",
              ""url"": ""http://messagecardplayground.azurewebsites.net/assets/Mostly%20Cloudy-Square.png""
            },
            {
              ""type"": ""TextBlock"",
              ""horizontalAlignment"": ""center"",
              ""wrap"": false,
              ""text"": ""62""
            },
            {
              ""type"": ""TextBlock"",
              ""horizontalAlignment"": ""center"",
              ""isSubtle"": true,
              ""wrap"": false,
              ""text"": ""52"",
              ""spacing"": ""none""
            }
          ],
          ""selectAction"": {
            ""type"": ""Action.OpenUrl"",
            ""title"": ""View Friday"",
            ""url"": ""http://www.microsoft.com""
          }
        },
        {
          ""type"": ""Column"",
          ""width"": ""20"",
          ""items"": [
            {
              ""type"": ""TextBlock"",
              ""horizontalAlignment"": ""center"",
              ""wrap"": false,
              ""text"": ""Sat""
            },
            {
              ""type"": ""Image"",
              ""size"": ""auto"",
              ""url"": ""http://messagecardplayground.azurewebsites.net/assets/Drizzle-Square.png""
            },
            {
              ""type"": ""TextBlock"",
              ""horizontalAlignment"": ""center"",
              ""wrap"": false,
              ""text"": ""60""
            },
            {
              ""type"": ""TextBlock"",
              ""horizontalAlignment"": ""center"",
              ""isSubtle"": true,
              ""wrap"": false,
              ""text"": ""48"",
              ""spacing"": ""none""
            }
          ],
          ""selectAction"": {
            ""type"": ""Action.OpenUrl"",
            ""title"": ""View Saturday"",
            ""url"": ""http://www.microsoft.com""
          }
        },
        {
          ""type"": ""Column"",
          ""width"": ""20"",
          ""items"": [
            {
              ""type"": ""TextBlock"",
              ""horizontalAlignment"": ""center"",
              ""wrap"": false,
              ""text"": ""Sun""
            },
            {
              ""type"": ""Image"",
              ""size"": ""auto"",
              ""url"": ""http://messagecardplayground.azurewebsites.net/assets/Mostly%20Cloudy-Square.png""
            },
            {
              ""type"": ""TextBlock"",
              ""horizontalAlignment"": ""center"",
              ""wrap"": false,
              ""text"": ""59""
            },
            {
              ""type"": ""TextBlock"",
              ""horizontalAlignment"": ""center"",
              ""isSubtle"": true,
              ""wrap"": false,
              ""text"": ""49"",
              ""spacing"": ""none""
            }
          ],
          ""selectAction"": {
            ""type"": ""Action.OpenUrl"",
            ""title"": ""View Sunday"",
            ""url"": ""http://www.microsoft.com""
          }
        },
        {
          ""type"": ""Column"",
          ""width"": ""20"",
          ""items"": [
            {
              ""type"": ""TextBlock"",
              ""horizontalAlignment"": ""center"",
              ""wrap"": false,
              ""text"": ""Mon""
            },
            {
              ""type"": ""Image"",
              ""size"": ""auto"",
              ""url"": ""http://messagecardplayground.azurewebsites.net/assets/Mostly%20Cloudy-Square.png""
            },
            {
              ""type"": ""TextBlock"",
              ""horizontalAlignment"": ""center"",
              ""wrap"": false,
              ""text"": ""64""
            },
            {
              ""type"": ""TextBlock"",
              ""horizontalAlignment"": ""center"",
              ""isSubtle"": true,
              ""wrap"": false,
              ""text"": ""51"",
              ""spacing"": ""none""
            }
          ],
          ""selectAction"": {
            ""type"": ""Action.OpenUrl"",
            ""title"": ""View Monday"",
            ""url"": ""http://www.microsoft.com""
          }
        }
      ]
    }
  ]
}
";
        public static string ProductVideo = @"{
  ""$schema"": ""http://adaptivecards.io/schemas/adaptive-card.json"",
  ""type"": ""AdaptiveCard"",
  ""version"": ""1.1"",
  ""fallbackText"": ""This card requires Media to be viewed. Ask your platform to update to Adaptive Cards v1.1 for this and more!"",
    ""body"": [
        {
            ""type"": ""Media"",
            ""poster"": ""https://adaptivecards.io/content/poster-video.png"",
            ""sources"": [
                {
                    ""mimeType"": ""video/mp4"",
                    ""url"": ""https://adaptivecardsblob.blob.core.windows.net/assets/AdaptiveCardsOverviewVideo.mp4""
                }
            ]
        }
    ],
    ""actions"": [
        {
            ""type"": ""Action.OpenUrl"",
            ""title"": ""Learn more"",
            ""url"": ""https://adaptivecards.io""
        }
    ]
}
";
        public static string Agenda = @"{
  ""type"": ""AdaptiveCard"",
  ""body"": [
    {
      ""type"": ""ColumnSet"",
      ""horizontalAlignment"": ""Center"",
      ""columns"": [
        {
          ""type"": ""Column"",
          ""items"": [
            {
              ""type"": ""ColumnSet"",
              ""horizontalAlignment"": ""Center"",
              ""columns"": [
                {
                  ""type"": ""Column"",
                  ""items"": [
                    {
                      ""type"": ""Image"",
                      ""url"": ""http://messagecardplayground.azurewebsites.net/assets/LocationGreen_A.png""
                    }
                  ],
                  ""width"": ""auto""
                },
                {
                  ""type"": ""Column"",
                  ""items"": [
                    {
                      ""type"": ""TextBlock"",
                      ""text"": ""**Redmond**""
                    },
                    {
                      ""type"": ""TextBlock"",
                      ""spacing"": ""None"",
                      ""text"": ""8a - 12:30p""
                    }
                  ],
                  ""width"": ""auto""
                }
              ]
            }
          ],
          ""width"": 1
        },
        {
          ""type"": ""Column"",
          ""spacing"": ""Large"",
          ""separator"": true,
          ""items"": [
            {
              ""type"": ""ColumnSet"",
              ""horizontalAlignment"": ""Center"",
              ""columns"": [
                {
                  ""type"": ""Column"",
                  ""items"": [
                    {
                      ""type"": ""Image"",
                      ""url"": ""http://messagecardplayground.azurewebsites.net/assets/LocationBlue_B.png""
                    }
                  ],
                  ""width"": ""auto""
                },
                {
                  ""type"": ""Column"",
                  ""items"": [
                    {
                      ""type"": ""TextBlock"",
                      ""text"": ""**Bellevue**""
                    },
                    {
                      ""type"": ""TextBlock"",
                      ""spacing"": ""None"",
                      ""text"": ""12:30p - 3p""
                    }
                  ],
                  ""width"": ""auto""
                }
              ]
            }
          ],
          ""width"": 1
        },
        {
          ""type"": ""Column"",
          ""spacing"": ""Large"",
          ""separator"": true,
          ""items"": [
            {
              ""type"": ""ColumnSet"",
              ""horizontalAlignment"": ""Center"",
              ""columns"": [
                {
                  ""type"": ""Column"",
                  ""items"": [
                    {
                      ""type"": ""Image"",
                      ""url"": ""http://messagecardplayground.azurewebsites.net/assets/LocationRed_C.png""
                    }
                  ],
                  ""width"": ""auto""
                },
                {
                  ""type"": ""Column"",
                  ""items"": [
                    {
                      ""type"": ""TextBlock"",
                      ""text"": ""**Seattle**""
                    },
                    {
                      ""type"": ""TextBlock"",
                      ""spacing"": ""None"",
                      ""text"": ""8p""
                    }
                  ],
                  ""width"": ""auto""
                }
              ]
            }
          ],
          ""width"": 1
        }
      ]
    },
    {
      ""type"": ""ColumnSet"",
      ""columns"": [
        {
          ""type"": ""Column"",
          ""items"": [
            {
              ""type"": ""ColumnSet"",
              ""columns"": [
                {
                  ""type"": ""Column"",
                  ""items"": [
                    {
                      ""type"": ""Image"",
                      ""horizontalAlignment"": ""Left"",
                      ""url"": ""http://messagecardplayground.azurewebsites.net/assets/Conflict.png""
                    }
                  ],
                  ""width"": ""auto""
                },
                {
                  ""type"": ""Column"",
                  ""spacing"": ""None"",
                  ""items"": [
                    {
                      ""type"": ""TextBlock"",
                      ""text"": ""2:00 PM""
                    }
                  ],
                  ""width"": ""stretch""
                }
              ]
            },
            {
              ""type"": ""TextBlock"",
              ""spacing"": ""None"",
              ""text"": ""1hr"",
              ""isSubtle"": true
            }
          ],
          ""width"": ""110px""
        },
        {
          ""type"": ""Column"",
          ""backgroundImage"": {
            ""url"": ""http://messagecardplayground.azurewebsites.net/assets/SmallVerticalLineGray.png"",
            ""fillMode"": ""RepeatVertically"",
            ""horizontalAlignment"": ""Center""
          },
          ""items"": [
            {
              ""type"": ""Image"",
              ""horizontalAlignment"": ""Center"",
              ""url"": ""http://messagecardplayground.azurewebsites.net/assets/CircleGreen_coffee.png""
            }
          ],
          ""width"": ""auto"",
          ""spacing"": ""None""
        },
        {
          ""type"": ""Column"",
          ""items"": [
            {
              ""type"": ""TextBlock"",
              ""text"": ""**Contoso Campaign Status Meeting**""
            },
            {
              ""type"": ""ColumnSet"",
              ""spacing"": ""None"",
              ""columns"": [
                {
                  ""type"": ""Column"",
                  ""items"": [
                    {
                      ""type"": ""Image"",
                      ""url"": ""http://messagecardplayground.azurewebsites.net/assets/location_gray.png""
                    }
                  ],
                  ""width"": ""auto""
                },
                {
                  ""type"": ""Column"",
                  ""items"": [
                    {
                      ""type"": ""TextBlock"",
                      ""text"": ""Conf Room Bravern-2/9050""
                    }
                  ],
                  ""width"": ""stretch""
                }
              ]
            },
            {
              ""type"": ""ImageSet"",
              ""spacing"": ""Small"",
              ""imageSize"": ""Small"",
              ""images"": [
                {
                  ""type"": ""Image"",
                  ""url"": ""http://messagecardplayground.azurewebsites.net/assets/person_w1.png"",
                  ""size"": ""Small""
                },
                {
                  ""type"": ""Image"",
                  ""url"": ""http://messagecardplayground.azurewebsites.net/assets/person_m1.png"",
                  ""size"": ""Small""
                },
                {
                  ""type"": ""Image"",
                  ""url"": ""http://messagecardplayground.azurewebsites.net/assets/person_w2.png"",
                  ""size"": ""Small""
                }
              ]
            },
            {
              ""type"": ""ColumnSet"",
              ""spacing"": ""Small"",
              ""columns"": [
                {
                  ""type"": ""Column"",
                  ""items"": [
                    {
                      ""type"": ""Image"",
                      ""url"": ""http://messagecardplayground.azurewebsites.net/assets/power_point.png""
                    }
                  ],
                  ""width"": ""auto""
                },
                {
                  ""type"": ""Column"",
                  ""items"": [
                    {
                      ""type"": ""TextBlock"",
                      ""text"": ""**Contoso Brand Guidelines** shared by **Susan Metters**""
                    }
                  ],
                  ""width"": ""stretch""
                }
              ]
            }
          ],
          ""width"": 40
        }
      ]
    },
    {
      ""type"": ""ColumnSet"",
      ""spacing"": ""None"",
      ""columns"": [
        {
          ""type"": ""Column"",
          ""width"": ""110px""
        },
        {
          ""type"": ""Column"",
          ""backgroundImage"": {
            ""url"": ""http://messagecardplayground.azurewebsites.net/assets/SmallVerticalLineGray.png"",
            ""fillMode"": ""RepeatVertically"",
            ""horizontalAlignment"": ""Center""
          },
          ""items"": [
            {
              ""type"": ""Image"",
              ""horizontalAlignment"": ""Center"",
              ""url"": ""http://messagecardplayground.azurewebsites.net/assets/Gray_Dot.png""
            }
          ],
          ""width"": ""auto"",
          ""spacing"": ""None""
        },
        {
          ""type"": ""Column"",
          ""items"": [
            {
              ""type"": ""ColumnSet"",
              ""columns"": [
                {
                  ""type"": ""Column"",
                  ""items"": [
                    {
                      ""type"": ""Image"",
                      ""url"": ""http://messagecardplayground.azurewebsites.net/assets/car.png""
                    }
                  ],
                  ""width"": ""auto""
                },
                {
                  ""type"": ""Column"",
                  ""items"": [
                    {
                      ""type"": ""TextBlock"",
                      ""text"": ""about 45 minutes"",
                      ""isSubtle"": true
                    }
                  ],
                  ""width"": ""stretch""
                }
              ]
            }
          ],
          ""width"": 40
        }
      ]
    },
    {
      ""type"": ""ColumnSet"",
      ""spacing"": ""None"",
      ""columns"": [
        {
          ""type"": ""Column"",
          ""items"": [
            {
              ""type"": ""TextBlock"",
              ""spacing"": ""None"",
              ""text"": ""8:00 PM""
            },
            {
              ""type"": ""TextBlock"",
              ""spacing"": ""None"",
              ""text"": ""1hr"",
              ""isSubtle"": true
            }
          ],
          ""width"": ""110px""
        },
        {
          ""type"": ""Column"",
          ""backgroundImage"": {
            ""url"": ""http://messagecardplayground.azurewebsites.net/assets/SmallVerticalLineGray.png"",
            ""fillMode"": ""RepeatVertically"",
            ""horizontalAlignment"": ""Center""
          },
          ""items"": [
            {
              ""type"": ""Image"",
              ""horizontalAlignment"": ""Center"",
              ""url"": ""http://messagecardplayground.azurewebsites.net/assets/CircleBlue_flight.png""
            }
          ],
          ""width"": ""auto"",
          ""spacing"": ""None""
        },
        {
          ""type"": ""Column"",
          ""items"": [
            {
              ""type"": ""TextBlock"",
              ""text"": ""**Alaska Airlines AS1021 flight to Chicago**""
            },
            {
              ""type"": ""ColumnSet"",
              ""spacing"": ""None"",
              ""columns"": [
                {
                  ""type"": ""Column"",
                  ""items"": [
                    {
                      ""type"": ""Image"",
                      ""url"": ""http://messagecardplayground.azurewebsites.net/assets/location_gray.png""
                    }
                  ],
                  ""width"": ""auto""
                },
                {
                  ""type"": ""Column"",
                  ""items"": [
                    {
                      ""type"": ""TextBlock"",
                      ""text"": ""Seattle Tacoma International Airport (17801 International Blvd, Seattle, WA, United States)"",
                      ""wrap"": true
                    }
                  ],
                  ""width"": ""stretch""
                }
              ]
            },
            {
              ""type"": ""Image"",
              ""url"": ""http://messagecardplayground.azurewebsites.net/assets/SeaTacMap.png"",
              ""size"": ""Stretch""
            }
          ],
          ""width"": 40
        }
      ]
    }
  ],
  ""$schema"": ""http://adaptivecards.io/schemas/adaptive-card.json"",
  ""version"": ""1.0""
}";
        public static string ExpenseReport = @"{
  ""type"": ""AdaptiveCard"",
  ""body"": [
    {
      ""type"": ""Container"",
      ""style"": ""emphasis"",
      ""items"": [
        {
          ""type"": ""ColumnSet"",
          ""columns"": [
            {
              ""type"": ""Column"",
              ""items"": [
                {
                  ""type"": ""TextBlock"",
                  ""size"": ""Large"",
                  ""weight"": ""Bolder"",
                  ""text"": ""**EXPENSE APPROVAL**""
                }
              ],
              ""width"": ""stretch""
            },
            {
              ""type"": ""Column"",
              ""items"": [
                {
                  ""type"": ""Image"",
                  ""url"": ""https://adaptivecards.io/content/pending.png"",
                  ""height"": ""30px"",
                  ""altText"": ""Pending""
                }
              ],
              ""width"": ""auto""
            }
          ]
        }
      ],
      ""bleed"": true
    },
    {
      ""type"": ""Container"",
      ""items"": [
        {
          ""type"": ""ColumnSet"",
          ""columns"": [
            {
              ""type"": ""Column"",
              ""items"": [
                {
                  ""type"": ""TextBlock"",
                  ""size"": ""ExtraLarge"",
                  ""text"": ""Trip to UAE"",
                  ""wrap"": true
                },
                {
                  ""type"": ""TextBlock"",
                  ""spacing"": ""Small"",
                  ""size"": ""Small"",
                  ""weight"": ""Bolder"",
                  ""color"": ""Accent"",
                  ""text"": ""[ER-13052](https://adaptivecards.io)""
                }
              ],
              ""width"": ""stretch""
            },
            {
              ""type"": ""Column"",
              ""items"": [
                {
                  ""type"": ""ActionSet"",
                  ""actions"": [
                    {
                      ""type"": ""Action.OpenUrl"",
                      ""title"": ""EXPORT AS PDF"",
                      ""url"": ""https://adaptivecards.io""
                    }
                  ]
                }
              ],
              ""width"": ""auto""
            }
          ]
        },
        {
          ""type"": ""FactSet"",
          ""spacing"": ""Large"",
          ""facts"": [
            {
              ""title"": ""Submitted By"",
              ""value"": ""**Matt Hidinger**  matt@contoso.com""
            },
            {
              ""title"": ""Duration"",
              ""value"": ""2019/06/19 - 2019/06/25""
            },
            {
              ""title"": ""Submitted On"",
              ""value"": ""2019/04/14""
            },
            {
              ""title"": ""Reimbursable Amount"",
              ""value"": ""$ 404.30""
            },
            {
              ""title"": ""Awaiting approval from"",
              ""value"": ""**Thomas**  thomas@contoso.com""
            },
            {
              ""title"": ""Submitted to"",
              ""value"": ""**David**   david@contoso.com""
            }
          ]
        }
      ]
    },
    {
      ""type"": ""Container"",
      ""spacing"": ""Large"",
      ""style"": ""emphasis"",
      ""items"": [
        {
          ""type"": ""ColumnSet"",
          ""columns"": [
            {
              ""type"": ""Column"",
              ""items"": [
                {
                  ""type"": ""TextBlock"",
                  ""weight"": ""Bolder"",
                  ""text"": ""DATE""
                }
              ],
              ""width"": ""auto""
            },
            {
              ""type"": ""Column"",
              ""spacing"": ""Large"",
              ""items"": [
                {
                  ""type"": ""TextBlock"",
                  ""weight"": ""Bolder"",
                  ""text"": ""CATEGORY""
                }
              ],
              ""width"": ""stretch""
            },
            {
              ""type"": ""Column"",
              ""items"": [
                {
                  ""type"": ""TextBlock"",
                  ""weight"": ""Bolder"",
                  ""text"": ""AMOUNT""
                }
              ],
              ""width"": ""auto""
            }
          ]
        }
      ],
      ""bleed"": true
    },
    {
      ""type"": ""ColumnSet"",
      ""columns"": [
        {
          ""type"": ""Column"",
          ""items"": [
            {
              ""type"": ""TextBlock"",
              ""text"": ""06/19"",
              ""wrap"": true
            }
          ],
          ""width"": ""auto""
        },
        {
          ""type"": ""Column"",
          ""spacing"": ""Medium"",
          ""items"": [
            {
              ""type"": ""TextBlock"",
              ""text"": ""Air Travel Expense"",
              ""wrap"": true
            }
          ],
          ""width"": ""stretch""
        },
        {
          ""type"": ""Column"",
          ""items"": [
            {
              ""type"": ""TextBlock"",
              ""text"": ""$ 300"",
              ""wrap"": true
            }
          ],
          ""width"": ""auto""
        },
        {
          ""type"": ""Column"",
          ""id"": ""chevronDown1"",
          ""spacing"": ""Small"",
          ""verticalContentAlignment"": ""Center"",
          ""items"": [
            {
              ""type"": ""Image"",
              ""selectAction"": {
                ""type"": ""Action.ToggleVisibility"",
                ""title"": ""collapse"",
                ""targetElements"": [
                  ""cardContent1"",
                  ""chevronUp1"",
                  ""chevronDown1""
                ]
              },
              ""url"": ""https://adaptivecards.io/content/down.png"",
              ""width"": ""20px"",
              ""altText"": ""collapsed""
            }
          ],
          ""width"": ""auto""
        },
        {
          ""type"": ""Column"",
          ""id"": ""chevronUp1"",
          ""isVisible"": false,
          ""spacing"": ""Small"",
          ""verticalContentAlignment"": ""Center"",
          ""items"": [
            {
              ""type"": ""Image"",
              ""selectAction"": {
                ""type"": ""Action.ToggleVisibility"",
                ""title"": ""expand"",
                ""targetElements"": [
                  ""cardContent1"",
                  ""chevronUp1"",
                  ""chevronDown1""
                ]
              },
              ""url"": ""https://adaptivecards.io/content/up.png"",
              ""width"": ""20px"",
              ""altText"": ""expanded""
            }
          ],
          ""width"": ""auto""
        }
      ]
    },
    {
      ""type"": ""Container"",
      ""id"": ""cardContent1"",
      ""isVisible"": false,
      ""items"": [
        {
          ""type"": ""Container"",
          ""items"": [
            {
              ""type"": ""TextBlock"",
              ""text"": ""* Leg 1 on Tue, Jun 19th, 2019 at 6:00 AM."",
              ""isSubtle"": true,
              ""wrap"": true
            },
            {
              ""type"": ""TextBlock"",
              ""text"": ""* Leg 2 on Tue,Jun 19th, 2019 at 7:15 PM."",
              ""isSubtle"": true,
              ""wrap"": true
            },
            {
              ""type"": ""Container"",
              ""items"": [
                {
                  ""type"": ""Input.Text"",
                  ""id"": ""comment1"",
                  ""placeholder"": ""Add your comment here.""
                }
              ]
            }
          ]
        },
        {
          ""type"": ""Container"",
          ""items"": [
            {
              ""type"": ""ColumnSet"",
              ""columns"": [
                {
                  ""type"": ""Column"",
                  ""items"": [
                    {
                      ""type"": ""ActionSet"",
                      ""actions"": [
                        {
                          ""type"": ""Action.Submit"",
                          ""title"": ""Send"",
                          ""data"": {
                            ""id"": ""_qkQW8dJlUeLVi7ZMEzYVw"",
                            ""action"": ""comment"",
                            ""lineItem"": 1
                          }
                        }
                      ]
                    }
                  ],
                  ""width"": ""auto""
                }
              ]
            }
          ]
        }
      ]
    },
    {
      ""type"": ""ColumnSet"",
      ""columns"": [
        {
          ""type"": ""Column"",
          ""items"": [
            {
              ""type"": ""TextBlock"",
              ""horizontalAlignment"": ""Center"",
              ""text"": ""06/19"",
              ""wrap"": true
            }
          ],
          ""width"": ""auto""
        },
        {
          ""type"": ""Column"",
          ""spacing"": ""Medium"",
          ""items"": [
            {
              ""type"": ""TextBlock"",
              ""text"": ""Auto Mobile Expense"",
              ""wrap"": true
            }
          ],
          ""width"": ""stretch""
        },
        {
          ""type"": ""Column"",
          ""items"": [
            {
              ""type"": ""TextBlock"",
              ""text"": ""$ 100"",
              ""wrap"": true
            }
          ],
          ""width"": ""auto""
        },
        {
          ""type"": ""Column"",
          ""id"": ""chevronDown2"",
          ""spacing"": ""Small"",
          ""verticalContentAlignment"": ""Center"",
          ""items"": [
            {
              ""type"": ""Image"",
              ""selectAction"": {
                ""type"": ""Action.ToggleVisibility"",
                ""title"": ""collapse"",
                ""targetElements"": [
                  ""cardContent2"",
                  ""chevronUp2"",
                  ""chevronDown2""
                ]
              },
              ""url"": ""https://adaptivecards.io/content/down.png"",
              ""width"": ""20px"",
              ""altText"": ""collapsed""
            }
          ],
          ""width"": ""auto""
        },
        {
          ""type"": ""Column"",
          ""id"": ""chevronUp2"",
          ""isVisible"": false,
          ""spacing"": ""Small"",
          ""verticalContentAlignment"": ""Center"",
          ""items"": [
            {
              ""type"": ""Image"",
              ""selectAction"": {
                ""type"": ""Action.ToggleVisibility"",
                ""title"": ""expand"",
                ""targetElements"": [
                  ""cardContent2"",
                  ""chevronUp2"",
                  ""chevronDown2""
                ]
              },
              ""url"": ""https://adaptivecards.io/content/up.png"",
              ""width"": ""20px"",
              ""altText"": ""expanded""
            }
          ],
          ""width"": ""auto""
        }
      ]
    },
    {
      ""type"": ""Container"",
      ""id"": ""cardContent2"",
      ""isVisible"": false,
      ""items"": [
        {
          ""type"": ""Container"",
          ""items"": [
            {
              ""type"": ""TextBlock"",
              ""text"": ""* Contoso Car Rentrals, Tues 6/19 at 7:00 AM"",
              ""isSubtle"": true,
              ""wrap"": true
            },
            {
              ""type"": ""Container"",
              ""items"": [
                {
                  ""type"": ""Input.Text"",
                  ""id"": ""comment2"",
                  ""placeholder"": ""Add your comment here.""
                }
              ]
            }
          ]
        },
        {
          ""type"": ""Container"",
          ""items"": [
            {
              ""type"": ""ColumnSet"",
              ""columns"": [
                {
                  ""type"": ""Column"",
                  ""items"": [
                    {
                      ""type"": ""ActionSet"",
                      ""actions"": [
                        {
                          ""type"": ""Action.Submit"",
                          ""title"": ""Send"",
                          ""data"": {
                            ""id"": ""_qkQW8dJlUeLVi7ZMEzYVw"",
                            ""action"": ""comment"",
                            ""lineItem"": 2
                          }
                        }
                      ]
                    }
                  ],
                  ""width"": ""auto""
                }
              ]
            }
          ]
        }
      ]
    },
    {
      ""type"": ""ColumnSet"",
      ""columns"": [
        {
          ""type"": ""Column"",
          ""items"": [
            {
              ""type"": ""TextBlock"",
              ""horizontalAlignment"": ""Center"",
              ""text"": ""06/25"",
              ""wrap"": true
            }
          ],
          ""width"": ""auto""
        },
        {
          ""type"": ""Column"",
          ""spacing"": ""Medium"",
          ""items"": [
            {
              ""type"": ""TextBlock"",
              ""text"": ""Air Travel Expense"",
              ""wrap"": true
            }
          ],
          ""width"": ""stretch""
        },
        {
          ""type"": ""Column"",
          ""items"": [
            {
              ""type"": ""TextBlock"",
              ""text"": ""$ 4.30"",
              ""wrap"": true
            }
          ],
          ""width"": ""auto""
        },
        {
          ""type"": ""Column"",
          ""id"": ""chevronDown3"",
          ""spacing"": ""Small"",
          ""verticalContentAlignment"": ""Center"",
          ""items"": [
            {
              ""type"": ""Image"",
              ""selectAction"": {
                ""type"": ""Action.ToggleVisibility"",
                ""title"": ""collapse"",
                ""targetElements"": [
                  ""cardContent3"",
                  ""chevronUp3"",
                  ""chevronDown3""
                ]
              },
              ""url"": ""https://adaptivecards.io/content/down.png"",
              ""width"": ""20px"",
              ""altText"": ""collapsed""
            }
          ],
          ""width"": ""auto""
        },
        {
          ""type"": ""Column"",
          ""id"": ""chevronUp3"",
          ""isVisible"": false,
          ""spacing"": ""Small"",
          ""verticalContentAlignment"": ""Center"",
          ""items"": [
            {
              ""type"": ""Image"",
              ""selectAction"": {
                ""type"": ""Action.ToggleVisibility"",
                ""title"": ""expand"",
                ""targetElements"": [
                  ""cardContent3"",
                  ""chevronUp3"",
                  ""chevronDown3""
                ]
              },
              ""url"": ""https://adaptivecards.io/content/up.png"",
              ""width"": ""20px"",
              ""altText"": ""expanded""
            }
          ],
          ""width"": ""auto""
        }
      ]
    },
    {
      ""type"": ""Container"",
      ""id"": ""cardContent3"",
      ""isVisible"": false,
      ""items"": [
        {
          ""type"": ""Container"",
          ""items"": [
            {
              ""type"": ""Input.Text"",
              ""id"": ""comment3"",
              ""placeholder"": ""Add your comment here.""
            }
          ]
        },
        {
          ""type"": ""Container"",
          ""items"": [
            {
              ""type"": ""ColumnSet"",
              ""columns"": [
                {
                  ""type"": ""Column"",
                  ""items"": [
                    {
                      ""type"": ""ActionSet"",
                      ""actions"": [
                        {
                          ""type"": ""Action.Submit"",
                          ""title"": ""Send"",
                          ""data"": {
                            ""id"": ""_qkQW8dJlUeLVi7ZMEzYVw"",
                            ""action"": ""comment"",
                            ""lineItem"": 3
                          }
                        }
                      ]
                    }
                  ],
                  ""width"": ""auto""
                }
              ]
            }
          ]
        }
      ]
    },
    {
      ""type"": ""ColumnSet"",
      ""spacing"": ""Large"",
      ""separator"": true,
      ""columns"": [
        {
          ""type"": ""Column"",
          ""items"": [
            {
              ""type"": ""TextBlock"",
              ""horizontalAlignment"": ""Right"",
              ""text"": ""Total Expense Amount \t"",
              ""wrap"": true
            },
            {
              ""type"": ""TextBlock"",
              ""horizontalAlignment"": ""Right"",
              ""text"": ""Non-reimbursable Amount"",
              ""wrap"": true
            },
            {
              ""type"": ""TextBlock"",
              ""horizontalAlignment"": ""Right"",
              ""text"": ""Advance Amount"",
              ""wrap"": true
            }
          ],
          ""width"": ""stretch""
        },
        {
          ""type"": ""Column"",
          ""items"": [
            {
              ""type"": ""TextBlock"",
              ""text"": ""404.30""
            },
            {
              ""type"": ""TextBlock"",
              ""text"": ""(-) 0.00 \t""
            },
            {
              ""type"": ""TextBlock"",
              ""text"": ""(-) 0.00 \t""
            }
          ],
          ""width"": ""auto""
        },
        {
          ""type"": ""Column"",
          ""width"": ""auto""
        }
      ]
    },
    {
      ""type"": ""Container"",
      ""style"": ""emphasis"",
      ""items"": [
        {
          ""type"": ""ColumnSet"",
          ""columns"": [
            {
              ""type"": ""Column"",
              ""items"": [
                {
                  ""type"": ""TextBlock"",
                  ""horizontalAlignment"": ""Right"",
                  ""text"": ""Amount to be Reimbursed"",
                  ""wrap"": true
                }
              ],
              ""width"": ""stretch""
            },
            {
              ""type"": ""Column"",
              ""items"": [
                {
                  ""type"": ""TextBlock"",
                  ""weight"": ""Bolder"",
                  ""text"": ""$ 404.30""
                }
              ],
              ""width"": ""auto""
            },
            {
              ""type"": ""Column"",
              ""width"": ""auto""
            }
          ]
        }
      ],
      ""bleed"": true
    },
    {
      ""type"": ""Container"",
      ""items"": [
        {
          ""type"": ""ColumnSet"",
          ""columns"": [
            {
              ""type"": ""Column"",
              ""id"": ""chevronDown4"",
              ""selectAction"": {
                ""type"": ""Action.ToggleVisibility"",
                ""title"": ""show history"",
                ""targetElements"": [
                  ""cardContent4"",
                  ""chevronUp4"",
                  ""chevronDown4""
                ]
              },
              ""verticalContentAlignment"": ""Center"",
              ""items"": [
                {
                  ""type"": ""TextBlock"",
                  ""horizontalAlignment"": ""Right"",
                  ""color"": ""Accent"",
                  ""text"": ""Show history"",
                  ""wrap"": true
                }
              ],
              ""width"": 1
            },
            {
              ""type"": ""Column"",
              ""id"": ""chevronUp4"",
              ""isVisible"": false,
              ""selectAction"": {
                ""type"": ""Action.ToggleVisibility"",
                ""title"": ""hide history"",
                ""targetElements"": [
                  ""cardContent4"",
                  ""chevronUp4"",
                  ""chevronDown4""
                ]
              },
              ""verticalContentAlignment"": ""Center"",
              ""items"": [
                {
                  ""type"": ""TextBlock"",
                  ""horizontalAlignment"": ""Right"",
                  ""color"": ""Accent"",
                  ""text"": ""Hide history"",
                  ""wrap"": true
                }
              ],
              ""width"": 1
            }
          ]
        }
      ]
    },
    {
      ""type"": ""Container"",
      ""id"": ""cardContent4"",
      ""isVisible"": false,
      ""items"": [
        {
          ""type"": ""Container"",
          ""items"": [
            {
              ""type"": ""TextBlock"",
              ""text"": ""* Expense submitted by **Matt** on Wed, Apr 14th, 2019"",
              ""isSubtle"": true,
              ""wrap"": true
            },
            {
              ""type"": ""TextBlock"",
              ""text"": ""* Expense approved by **Thomas** on Thu, Apr 15th, 2019"",
              ""isSubtle"": true,
              ""wrap"": true
            }
          ]
        }
      ]
    },
    {
      ""type"": ""Container"",
      ""items"": [
        {
          ""type"": ""ActionSet"",
          ""actions"": [
            {
              ""type"": ""Action.Submit"",
              ""title"": ""Approve"",
              ""style"": ""positive"",
              ""data"": {
                ""id"": ""_qkQW8dJlUeLVi7ZMEzYVw"",
                ""action"": ""approve""
              }
            },
            {
              ""type"": ""Action.ShowCard"",
              ""title"": ""Reject"",
              ""style"": ""destructive"",
              ""card"": {
                ""type"": ""AdaptiveCard"",
                ""body"": [
                  {
                    ""type"": ""Input.Text"",
                    ""id"": ""RejectCommentID"",
                    ""placeholder"": ""Please specify an appropriate reason for rejection."",
                    ""isMultiline"": true
                  }
                ],
                ""actions"": [
                  {
                    ""type"": ""Action.Submit"",
                    ""title"": ""Send"",
                    ""data"": {
                      ""id"": ""_qkQW8dJlUeLVi7ZMEzYVw"",
                      ""action"": ""reject""
                    }
                  }
                ]
              }
            }
          ]
        }
      ]
    }
  ],
  ""$schema"": ""http://adaptivecards.io/schemas/adaptive-card.json"",
  ""version"": ""1.2"",
  ""fallbackText"": ""This card requires Adaptive Cards v1.2 support to be rendered properly.""
}";
        public static string FlightDetails = @"{
  ""type"": ""AdaptiveCard"",
  ""body"": [
    {
      ""type"": ""ColumnSet"",
      ""columns"": [
        {
          ""type"": ""Column"",
          ""items"": [
            {
              ""type"": ""Container"",
              ""backgroundImage"": ""http://messagecardplayground.azurewebsites.net/assets/TxP_Background.png"",
              ""items"": [
                {
                  ""type"": ""Image"",
                  ""horizontalAlignment"": ""Center"",
                  ""url"": ""http://messagecardplayground.azurewebsites.net/assets/TxP_Flight.png""
                }
              ],
              ""bleed"": true
            },
            {
              ""type"": ""Container"",
              ""spacing"": ""None"",
              ""style"": ""emphasis"",
              ""items"": [
                {
                  ""type"": ""TextBlock"",
                  ""size"": ""ExtraLarge"",
                  ""weight"": ""Lighter"",
                  ""color"": ""Accent"",
                  ""text"": ""Flight to Paris"",
                  ""wrap"": true
                },
                {
                  ""type"": ""TextBlock"",
                  ""spacing"": ""Small"",
                  ""text"": ""Delta Air Lines flight 8471"",
                  ""wrap"": true
                },
                {
                  ""type"": ""TextBlock"",
                  ""spacing"": ""None"",
                  ""text"": ""Confirmation code: ABCDEF"",
                  ""wrap"": true
                },
                {
                  ""type"": ""TextBlock"",
                  ""spacing"": ""None"",
                  ""text"": ""10 hours 45 minutes"",
                  ""wrap"": true
                }
              ],
              ""bleed"": true,
              ""height"": ""stretch""
            }
          ],
          ""width"": 45,
          ""height"": ""stretch""
        },
        {
          ""type"": ""Column"",
          ""items"": [
            {
              ""type"": ""Container"",
              ""height"": ""stretch"",
              ""items"": [
                {
                  ""type"": ""ColumnSet"",
                  ""columns"": [
                    {
                      ""type"": ""Column"",
                      ""items"": [
                        {
                          ""type"": ""TextBlock"",
                          ""size"": ""ExtraLarge"",
                          ""weight"": ""Lighter"",
                          ""text"": ""BLR""
                        }
                      ],
                      ""width"": ""auto""
                    },
                    {
                      ""type"": ""Column"",
                      ""verticalContentAlignment"": ""Center"",
                      ""items"": [
                        {
                          ""type"": ""Image"",
                          ""url"": ""http://messagecardplayground.azurewebsites.net/assets/graydot2x2.png"",
                          ""width"": ""10000px"",
                          ""height"": ""2px""
                        }
                      ],
                      ""width"": ""stretch""
                    },
                    {
                      ""type"": ""Column"",
                      ""spacing"": ""Small"",
                      ""verticalContentAlignment"": ""Center"",
                      ""items"": [
                        {
                          ""type"": ""Image"",
                          ""url"": ""http://messagecardplayground.azurewebsites.net/assets/smallairplane.png"",
                          ""height"": ""16px""
                        }
                      ],
                      ""width"": ""auto""
                    },
                    {
                      ""type"": ""Column"",
                      ""items"": [
                        {
                          ""type"": ""TextBlock"",
                          ""horizontalAlignment"": ""Right"",
                          ""size"": ""ExtraLarge"",
                          ""weight"": ""Lighter"",
                          ""text"": ""CDG""
                        }
                      ],
                      ""width"": ""auto""
                    }
                  ]
                },
                {
                  ""type"": ""ColumnSet"",
                  ""columns"": [
                    {
                      ""type"": ""Column"",
                      ""items"": [
                        {
                          ""type"": ""TextBlock"",
                          ""size"": ""Medium"",
                          ""text"": ""1:55 AM""
                        }
                      ],
                      ""width"": 1
                    },
                    {
                      ""type"": ""Column"",
                      ""items"": [
                        {
                          ""type"": ""TextBlock"",
                          ""horizontalAlignment"": ""Right"",
                          ""size"": ""Medium"",
                          ""text"": ""8:10 AM""
                        }
                      ],
                      ""width"": 1
                    }
                  ]
                },
                {
                  ""type"": ""ColumnSet"",
                  ""spacing"": ""None"",
                  ""columns"": [
                    {
                      ""type"": ""Column"",
                      ""items"": [
                        {
                          ""type"": ""TextBlock"",
                          ""text"": ""November 12, 2017"",
                          ""isSubtle"": true,
                          ""wrap"": true
                        }
                      ],
                      ""width"": 1
                    },
                    {
                      ""type"": ""Column"",
                      ""items"": [
                        {
                          ""type"": ""TextBlock"",
                          ""horizontalAlignment"": ""Right"",
                          ""text"": ""November 12, 2017"",
                          ""isSubtle"": true,
                          ""wrap"": true
                        }
                      ],
                      ""width"": 1
                    }
                  ]
                },
                {
                  ""type"": ""ColumnSet"",
                  ""spacing"": ""None"",
                  ""columns"": [
                    {
                      ""type"": ""Column"",
                      ""items"": [
                        {
                          ""type"": ""TextBlock"",
                          ""text"": ""Bengaluru"",
                          ""isSubtle"": true
                        }
                      ],
                      ""width"": 1
                    },
                    {
                      ""type"": ""Column"",
                      ""items"": [
                        {
                          ""type"": ""TextBlock"",
                          ""horizontalAlignment"": ""Right"",
                          ""text"": ""Paris"",
                          ""isSubtle"": true
                        }
                      ],
                      ""width"": 1
                    }
                  ],
                  ""height"": ""stretch""
                },
                {
                  ""type"": ""ActionSet"",
                  ""separator"": true,
                  ""actions"": [
                    {
                      ""type"": ""Action.Submit"",
                      ""title"": ""Check in"",
                      ""style"": ""positive""
                    },
                    {
                      ""type"": ""Action.Submit"",
                      ""title"": ""View in calendar""
                    }
                  ],
                  ""spacing"": ""Medium""
                }
              ]
            }
          ],
          ""width"": 55
        }
      ],
      ""height"": ""stretch""
    }
  ],
  ""$schema"": ""http://adaptivecards.io/schemas/adaptive-card.json"",
  ""version"": ""1.0""
}";

        #endregion

        #region Submits
        public static string SimpleSubmit = @"{
  ""$schema"": ""http://adaptivecards.io/schemas/adaptive-card.json"",
  ""type"": ""AdaptiveCard"",
  ""version"": ""1.0"",
  ""body"": [
    {
      ""type"": ""ColumnSet"",
      ""columns"": [
        {
          ""type"": ""Column"",
          ""items"": [
            {
              ""type"": ""TextBlock"",
              ""text"": ""Your name"",
              ""wrap"": true
            },
            {
              ""type"": ""Input.Text"",
              ""id"": ""myName"",
              ""placeholder"": ""Last, First""
            },
            {
              ""type"": ""TextBlock"",
              ""text"": ""Your email"",
              ""wrap"": true
            },
            {
              ""type"": ""Input.Text"",
              ""id"": ""myEmail"",
              ""placeholder"": ""youremail@example.com"",
              ""style"": ""email""
            }
          ]
        }
      ]
    }
  ],
  ""actions"": [
    {
      ""type"": ""Action.Submit"",
      ""title"": ""Submit""
    }
  ]
}
";
        public static string SimpleSubmitNamedAction = @"{
  ""$schema"": ""http://adaptivecards.io/schemas/adaptive-card.json"",
  ""type"": ""AdaptiveCard"",
  ""version"": ""1.0"",
  ""body"": [
    {
      ""type"": ""ColumnSet"",
      ""columns"": [
        {
          ""type"": ""Column"",
          ""items"": [
            {
              ""type"": ""TextBlock"",
              ""text"": ""Your name"",
              ""wrap"": true
            },
            {
              ""type"": ""Input.Text"",
              ""id"": ""myName"",
              ""placeholder"": ""Last, First""
            },
            {
              ""type"": ""TextBlock"",
              ""text"": ""Your email"",
              ""wrap"": true
            },
            {
              ""type"": ""Input.Text"",
              ""id"": ""myEmail"",
              ""placeholder"": ""youremail@example.com"",
              ""style"": ""email""
            }
          ]
        }
      ]
    }
  ],
  ""actions"": [
    {
      ""type"": ""Action.Submit"",
      ""title"": ""Submit"",
      ""name"": ""MySubmit""
    }
  ]
}
";
        public static string SimpleSubmitAndDecline = @"{
  ""$schema"": ""http://adaptivecards.io/schemas/adaptive-card.json"",
  ""type"": ""AdaptiveCard"",
  ""version"": ""1.0"",
  ""body"": [
    {
      ""type"": ""ColumnSet"",
      ""columns"": [
        {
          ""type"": ""Column"",
          ""items"": [
            {
              ""type"": ""TextBlock"",
              ""text"": ""Your name"",
              ""wrap"": true
            },
            {
              ""type"": ""Input.Text"",
              ""id"": ""myName"",
              ""placeholder"": ""Last, First""
            },
            {
              ""type"": ""TextBlock"",
              ""text"": ""Your email"",
              ""wrap"": true
            },
            {
              ""type"": ""Input.Text"",
              ""id"": ""myEmail"",
              ""placeholder"": ""youremail@example.com"",
              ""style"": ""email""
            }
          ]
        }
      ]
    }
  ],
  ""actions"": [
    {
      ""type"": ""Action.Submit"",
      ""title"": ""Send"",
      ""name"": ""send""
    },
    {
      ""type"": ""Action.Submit"",
      ""title"": ""Decline"",
      ""name"": ""decline""
    }
  ]
}
";
        #endregion
    }
}
