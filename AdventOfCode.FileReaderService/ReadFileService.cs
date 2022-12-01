using AdventOfCode.FileReaderService.Providers;

namespace AdventOfCode.FileReaderService
{
    public class ReadFileService : IReadFileService
    {
        public Task<List<string>> ReadAsync(IFileReaderProviderService fileReaderProviderService)
        {
           return fileReaderProviderService.Provider.ReadAsync();
        }
    }
}