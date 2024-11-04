using Microsoft.JSInterop;

namespace Append.Blazor.Downloads;

public class DownloadService : IAsyncDisposable, IDownloadService
{
    private readonly Lazy<Task<IJSObjectReference>> moduleTask;

    public DownloadService(IJSRuntime jsRuntime)
    {
        moduleTask = new(() => jsRuntime.InvokeAsync<IJSObjectReference>("import", "./_content/Append.Blazor.Downloads/scripts.js").AsTask());
    }

    /// <inheritdoc/>
    public async ValueTask DownloadFileAsync(string fileName, Stream stream)
    {
        using var streamRef = new DotNetStreamReference(stream: stream);
        var module = await moduleTask.Value;

        await module.InvokeVoidAsync("downloadFileFromStream", fileName, streamRef);
    }

    /// <inheritdoc/>
    public async ValueTask DisposeAsync()
    {
        if (moduleTask.IsValueCreated)
        {
            var module = await moduleTask.Value;
            await module.DisposeAsync();
        }
    }
}
