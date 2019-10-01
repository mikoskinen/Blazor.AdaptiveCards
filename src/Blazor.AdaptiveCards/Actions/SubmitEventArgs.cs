using System.Collections.Generic;

namespace Blazor.AdaptiveCards
{
    public class SubmitEventArgs
    {
        public SubmitEventArgs(string actionName, Dictionary<string, object> data)
        {
            Action = actionName;
            Data = data;
        }

        public string Action { get; private set; }
        public Dictionary<string, object> Data { get; private set; }
    }
}
