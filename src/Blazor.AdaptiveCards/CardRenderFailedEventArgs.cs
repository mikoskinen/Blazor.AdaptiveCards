using System;

namespace AdaptiveCards.Blazor.Actions
{
    public class CardRenderFailedEventArgs
    {
        public CardRenderFailedEventArgs(string schema, Exception exception)
        {
            Schema = schema;
            Exception = exception;
        }

        /// <summary>
        /// Gets the schema.
        /// </summary>
        /// <value>The schema.</value>
        public string Schema { get; }

        /// <summary>
        /// Gets the exception.
        /// </summary>
        /// <value>The exception.</value>
        public Exception Exception { get; }
    }
}
