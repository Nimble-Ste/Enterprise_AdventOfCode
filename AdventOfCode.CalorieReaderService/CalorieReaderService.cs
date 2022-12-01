namespace AdventOfCode.CalorieReaderService
{
    using AdventOfCode.FileReaderService.Providers;
    using Providers;

    public class CalorieReaderService : ICalorieReaderService
    {
        private readonly IReaderTypeProvider readerTypeProvider;

        private readonly IFileReaderProviderService fileReaderProviderService;

        public CalorieReaderService(IReaderTypeProvider readerTypeProvider, IFileReaderProviderService fileReaderProviderService)
        {
            this.readerTypeProvider = readerTypeProvider;
            this.fileReaderProviderService = fileReaderProviderService;
        }

        public Task<List<string>> GetCaloriesListAsync()
        {
            return readerTypeProvider.GetReader.ReadAsync(fileReaderProviderService);
        }
    }
}