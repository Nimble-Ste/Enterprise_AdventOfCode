namespace AdventOfCode.FileReaderService.Providers
{
    using BasicTextFileReader;

    public interface IFileReaderProviderService
    {
        ITextFileReaderProvider Provider => new BasicTextFileReaderProvider();
    }
}
