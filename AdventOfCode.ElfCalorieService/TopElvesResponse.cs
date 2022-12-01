namespace AdventOfCode.ElfCalorieService
{
    public class TopElvesResponse
    {
        public List<ElfModel> Elves { get; }

        public int TotalCalories => Elves.Sum(x => x.TotalCalorie);

        public TopElvesResponse(List<ElfModel> elves)
        {
            Elves = elves;
        }
    }
}
