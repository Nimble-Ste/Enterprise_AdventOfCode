namespace AdventOfCode.ElfCalorieService.Provider;

public interface ICalorieReaderProvider
{
    Task<IReadOnlyCollection<ElfModel>> BuildAsync();
}