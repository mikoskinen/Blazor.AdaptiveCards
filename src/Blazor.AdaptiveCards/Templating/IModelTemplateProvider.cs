using System.Threading.Tasks;
using System.Net.Http;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.JSInterop;
using Blazor.AdaptiveCards;

namespace Blazor.AdaptiveCards.Templating
{
    public interface IModelTemplateProvider<T>
    {
        string GetTemplate(T model);
    }
}
