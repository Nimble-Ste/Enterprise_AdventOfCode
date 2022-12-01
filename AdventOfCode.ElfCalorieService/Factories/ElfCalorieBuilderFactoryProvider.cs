namespace AdventOfCode.ElfCalorieService.Factories
{
    using AdventOfCode.Common.Extensions;
    using Common;
    using System;
    using ChunkerService;

    public class ElfCalorieBuilderFactoryProvider : IElfCalorieBuilderFactoryProvider
    {
        private readonly IChunkerService chunkerService;
        private readonly IBlankEntryProvider blankEntryProvider;

        public ElfCalorieBuilderFactoryProvider(IChunkerService chunkerService, IBlankEntryProvider blankEntryProvider)
        {
            this.chunkerService = chunkerService;
            this.blankEntryProvider = blankEntryProvider;
        }

        public async Task<IReadOnlyCollection<ElfModel>> BuildAsync(Func<Task<List<string>>> reader)
        {
            var rawCalories = await reader.Invoke();

            var chunked = chunkerService.ChunkIt(rawCalories, blankEntryProvider);

            var items = new List<ElfModel>();

            foreach (var chunk in chunked)
            {
                items.Add(new ElfModel(chunk.Key, chunk.Value.ToIntList().ToList()));
            }

            return items;
        }
    }
}
