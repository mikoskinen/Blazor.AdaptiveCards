using System.Threading.Tasks;

namespace Blazor.AdaptiveCards.Actions
{
    public interface ISubmitActionHandler
    {
        Task Handle(SubmitEventArgs eventArgs, object handler, object model);
    }
}
