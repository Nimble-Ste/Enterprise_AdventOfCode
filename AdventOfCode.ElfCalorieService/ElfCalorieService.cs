namespace AdventOfCode.ElfCalorieService
{
    using AdventOfCode.ElfCalorieService.Provider;


    public class ElfCalorieService : IElfCalorieService
    {
        private readonly ICalorieReaderProvider calorieReaderProvider;

        public ElfCalorieService(ICalorieReaderProvider calorieReaderProvider)
        {
            this.calorieReaderProvider = calorieReaderProvider;
        }

        private async Task<IReadOnlyCollection<ElfModel>> GetAllElvesAsync()
        {
            return await calorieReaderProvider.BuildAsync();
        }

        public async Task<ElfModel> GetElfByMaxCaloriesAsync()
        {
            var all = await this.GetAllElvesAsync();

            return all.MaxBy(x => x.TotalCalorie);
        }

        public async Task<TopElvesResponse> GetTopElves(int number)
        {
            var all = await this.GetAllElvesAsync();

            var elves = all.OrderByDescending(x => x.TotalCalorie).Take(number).ToList();

            return new TopElvesResponse(elves);
        }
    }
}