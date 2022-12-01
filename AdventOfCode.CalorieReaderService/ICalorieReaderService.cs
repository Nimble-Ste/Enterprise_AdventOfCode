namespace AdventOfCode.CalorieReaderService;

public interface ICalorieReaderService
{
    Task<List<string>> GetCaloriesListAsync();
}