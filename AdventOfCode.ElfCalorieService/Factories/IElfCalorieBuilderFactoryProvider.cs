namespace AdventOfCode.ElfCalorieService.Factories;

public interface IElfCalorieBuilderFactoryProvider
{
    Task<IReadOnlyCollection<ElfModel>> BuildAsync(Func<Task<List<string>>> reader);
}