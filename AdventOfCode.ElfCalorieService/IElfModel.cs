namespace AdventOfCode.ElfCalorieService;

using Common;

public interface IElfModel : IIDentifieable
{
    List<int> Calories { get; }
    int TotalCalorie { get; }
}