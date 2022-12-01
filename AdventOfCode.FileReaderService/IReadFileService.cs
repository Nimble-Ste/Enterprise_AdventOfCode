namespace AdventOfCode.FileReaderService;

using Providers;

public interface IReadFileService
{
    Task<List<string>> ReadAsync(IFileReaderProviderService fileReaderProviderService);
}