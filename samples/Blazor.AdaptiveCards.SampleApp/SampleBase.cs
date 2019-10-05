using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace Blazor.AdaptiveCards.SampleApp
{
    public class SampleBase : ComponentBase
    {
        [Parameter]
        public string Path { get; set; }

        //protected override Task OnInitializedAsync()
        //{
        //    var filesInFolder = System.IO.Directory.EnumerateFiles(@".\Pages\Samples\Templated Card").ToList();

        //    var documentationFilePath = filesInFolder.FirstOrDefault(x => x.EndsWith("md"));


        //}
    }
}
