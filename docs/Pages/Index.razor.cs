using Microsoft.AspNetCore.Components;

namespace Append.Blazor.Downloads.Documentation.Pages;
public partial class Index
{
    [Inject] public IDownloadService DownloadService { get; set; } = default!;
    private string filename = "file.txt";
    private async Task DownloadAsync()
    {
        var randomBinaryData = new byte[50 * 1024];
        var fileStream = new MemoryStream(randomBinaryData);

        await DownloadService.DownloadFileAsync(filename, fileStream);
    }
}

