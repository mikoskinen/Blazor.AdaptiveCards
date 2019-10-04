using System.Collections.Generic;
using AdaptiveCards;

namespace Blazor.AdaptiveCards.Actions
{
    public class CardRenderedEventArgs
    {
        public CardRenderedEventArgs(string schema, IList<AdaptiveWarning> warnings)
        {
            Schema = schema;
            Warnings = warnings;
        }

        /// <summary>
        /// Gets the schema.
        /// </summary>
        /// <value>The schema.</value>
        public string Schema { get; }

        /// <summary>
        /// Gets the warnings of the rendering.
        /// </summary>
        /// <value>The warnings.</value>
        public IList<AdaptiveWarning> Warnings { get; }
    }
}
