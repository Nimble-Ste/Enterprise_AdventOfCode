namespace AdventOfCode.ElfCalorieService;

public interface IElfCalorieService
{
    Task<ElfModel> GetElfByMaxCaloriesAsync();

    Task<TopElvesResponse> GetTopElves(int number);
}