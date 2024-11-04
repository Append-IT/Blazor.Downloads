namespace Append.Blazor.Downloads;

public interface IDownloadService
{
    /// <summary>
    /// Downloads a file from the specified stream.
    /// </summary>
    /// <param name="fileName">Your own file name with extension.</param>
    /// <param name="stream">The file you're downloading.</param>
    /// <returns></returns>
    ValueTask DownloadFileAsync(string fileName, Stream stream);
}