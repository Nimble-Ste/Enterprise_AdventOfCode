using AdventOfCode.ElfCalorieService.Factories;

namespace AdventOfCode.ElfCalorieService.Provider
{
    using CalorieReaderService;

    public class CalorieReaderProvider : ICalorieReaderProvider
    {
        private readonly IElfCalorieBuilderFactoryProvider elfCalorieBuilderFactoryProvider;

        private readonly ICalorieReaderService calorieReaderService;

        public CalorieReaderProvider(IElfCalorieBuilderFactoryProvider elfCalorieBuilderFactoryProvider, ICalorieReaderService calorieReaderService)
        {
            this.elfCalorieBuilderFactoryProvider = elfCalorieBuilderFactoryProvider;
            this.calorieReaderService = calorieReaderService;
        }


        public async Task<IReadOnlyCollection<ElfModel>> BuildAsync()
        {
            return await elfCalorieBuilderFactoryProvider.BuildAsync(async () => await calorieReaderService.GetCaloriesListAsync());
        }
    }
}
