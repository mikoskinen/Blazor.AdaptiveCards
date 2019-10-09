using System.Collections.Generic;

namespace AdaptiveCards.Blazor.Actions
{
    public class SubmitEventArgs
    {
        public SubmitEventArgs(string actionName, Dictionary<string, object> data, AdaptiveCardBase adaptiveCard, object model = null)
        {
            Action = actionName;
            Data = data;
            AdaptiveCard = adaptiveCard;
            Model = model;
        }

        public string Action { get; }
        public Dictionary<string, object> Data { get; }
        public AdaptiveCardBase AdaptiveCard { get; }
        public object Model { get; }
    }
}
