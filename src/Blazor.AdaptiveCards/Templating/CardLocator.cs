using System.IO;

namespace Blazor.AdaptiveCards.Templating
{
    public class CardLocator
    {
        public string Get(object obj, string cardId)
        {
            var objTypeName = obj.GetType().Name;
            var cardName = "default";

            if (!string.IsNullOrWhiteSpace(cardId))
            {
                cardName = cardId;
            }

            var location = Path.Combine("Cards", objTypeName, cardName + ".json");

            if (File.Exists(location))
            {
                var template = File.ReadAllText(location);

                return template;
            }
            else
            {
                location = Path.Combine("Cards", objTypeName, "default.json");
                var template = File.ReadAllText(location);

                return template;
            }
        }
    }
}
