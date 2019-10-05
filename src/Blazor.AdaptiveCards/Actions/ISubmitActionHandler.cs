using System.Threading.Tasks;

namespace AdaptiveCards.Blazor.Actions
{
    public interface ISubmitActionHandler
    {
        Task Handle(SubmitEventArgs eventArgs, object handler, object model);
    }
}
