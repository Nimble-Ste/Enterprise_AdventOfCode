namespace AdventOfCode.FileReaderService.Providers.BasicTextFileReader
{
    public class BasicTextFileReaderProvider : ITextFileReaderProvider
    {
        public async Task<List<string>> ReadAsync()
        {
            return (await File.ReadAllLinesAsync("CalorieData.txt")).ToList();
        }
    }
}
