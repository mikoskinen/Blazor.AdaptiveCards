using System;
using System.Collections.Generic;
using System.Linq;

namespace AdaptiveCards.Blazor.Actions
{
    public class ActionCreator
    {
        public AdaptiveCards.AdaptiveCard Create(AdaptiveCards.AdaptiveCard adaptiveCard, Func<dynamic, List<AdaptiveAction>> actions,
            object obj)
        {
            if (actions == null)
            {
                return adaptiveCard;
            }

            var createdActions = actions(obj);

            if (createdActions?.Any() != true)
            {
                return adaptiveCard;
            }

            adaptiveCard.Actions.AddRange(createdActions);

            return adaptiveCard;
        }
    }
}
