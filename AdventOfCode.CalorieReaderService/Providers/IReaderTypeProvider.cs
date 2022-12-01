namespace AdventOfCode.CalorieReaderService.Providers
{
    using FileReaderService;

    public interface IReaderTypeProvider
    {
        IReadFileService GetReader => new ReadFileService();
    }
}
