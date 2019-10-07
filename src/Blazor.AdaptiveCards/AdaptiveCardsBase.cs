using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Components;

namespace AdaptiveCards.Blazor
{
    public abstract class AdaptiveCardsBase<TModel> : ComponentBase
    {
        [Parameter]
        public string Schema { get; set; }

        [Parameter]
        public RenderFragment<TModel> RowTemplate { get; set; }

        [Parameter]
        public List<TModel> Models { get; set; }

        [Parameter]
        public Func<TModel, string> TemplateSelector { get; set; }

        [Parameter]
        public string @class { get; set; } = "row";

        [Parameter]
        public string CardClass { get; set; }

        [Parameter]
        public Dictionary<string, object> CardAttributes { get; set; } = new Dictionary<string, object>();

        [Parameter]
        public List<(string, Func<int, TModel, object>)> CardAttributeFunctions { get; set; }

        [Parameter(CaptureUnmatchedValues = true)]
        public Dictionary<string, object> Attributes { get; set; }

        [Parameter]
        public RenderMode RenderMode { get; set; } = RenderMode.Synchronous;

        protected Dictionary<string, object> GetCardAttributes(int index, TModel model)
        {
            var result = new Dictionary<string, object>(CardAttributes);

            if (!string.IsNullOrWhiteSpace(CardClass) && !result.ContainsKey("class"))
            {
                result.Add("class", CardClass);
            }

            if (CardAttributeFunctions?.Any() != true)
            {
                return result;
            }

            foreach (var cardAttribute in CardAttributeFunctions)
            {
                result.Add(cardAttribute.Item1, cardAttribute.Item2(index, model));
            }

            return result;
        }
    }
}
