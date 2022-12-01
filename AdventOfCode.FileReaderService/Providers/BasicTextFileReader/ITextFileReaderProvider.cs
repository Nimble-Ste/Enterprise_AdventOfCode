namespace AdventOfCode.FileReaderService.Providers.BasicTextFileReader;

public interface ITextFileReaderProvider
{
    Task<List<string>> ReadAsync();
}