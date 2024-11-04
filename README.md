# Downloads
Service to download files in Microsoft Blazor.

[![Package Version](https://img.shields.io/nuget/v/Append.Blazor.Downloads.svg)](https://www.nuget.org/packages/Append.Blazor.Downloads)
[![NuGet Downloads](https://img.shields.io/nuget/dt/Append.Blazor.Downloads.svg)](https://www.nuget.org/packages/Append.Blazor.Downloads)
[![License](https://img.shields.io/github/license/Append-IT/Blazor.Downloads.svg)](https://github.com/Append-IT/Blazor.Downloads/blob/main/LICENSE)

## Installation

```
Install-Package Append.Blazor.Downloads
```

## Demo
// TODO: Add azure file link
There is a sample application in /docs folder which is also hosted as [documentation](https://wonderful-smoke-084433603.2.azurestaticapps.net). 

## Usage

### Add `IDownloadsService` via DI in `Program.cs`
> Scoped by default.
```csharp
builder.Services.AddDownloadServices();
```

### Inject into component/pages
```csharp
@using Append.Blazor.Downloads
@inject IDownloadService DownloadService
```

or

### Inject on a `BlazorComponent` class:

```c#
[Inject] public IDownloadService DownloadService { get; set; } = default!;
```

### Download a file
```csharp
// Your file stream
var randomBinaryData = new byte[50 * 1024];
var fileStream = new MemoryStream(randomBinaryData);

await DownloadService.DownloadFileAsync("myFile.txt", fileStream);
```

# Contributions and feedback

Please feel free to use the component, open issues, fix bugs or provide feedback.

# Contributors

This project is created and maintained by:

- [Benjamin Vertonghen](https://github.com/vertonghenb)
