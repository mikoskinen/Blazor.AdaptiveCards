using System.Threading.Tasks;

namespace Blazor.AdaptiveCards
{
    public interface ISubmitActionHandler
    {
        Task Handle(SubmitEventArgs eventArgs, object handler, object model);
    }
}
