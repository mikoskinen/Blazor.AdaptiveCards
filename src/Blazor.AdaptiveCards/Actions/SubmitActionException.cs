using System;

namespace AdaptiveCards.Blazor.Actions
{
    public class SubmitActionException : Exception
    {
        public SubmitActionException(string message, SubmitEventArgs eventArgs, object handler) : base(message)
        {
            EventArgs = eventArgs;
            Handler = handler;
        }

        public SubmitActionException(string message, SubmitEventArgs eventArgs, object handler, Exception innerException) : base(message, innerException)
        {
            EventArgs = eventArgs;
            Handler = handler;
        }

        public SubmitEventArgs EventArgs { get; }
        public object Handler { get; }
    }
}
