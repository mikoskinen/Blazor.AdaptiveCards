using System.Collections.Generic;

namespace AdaptiveCards.Blazor.Actions
{
    public class SubmitEventArgs
    {
        public SubmitEventArgs(string actionName, Dictionary<string, object> data, object model = null)
        {
            Action = actionName;
            Data = data;
            Model = model;
        }

        public string Action { get; }
        public Dictionary<string, object> Data { get; }
        public object Model { get; }
    }
}
