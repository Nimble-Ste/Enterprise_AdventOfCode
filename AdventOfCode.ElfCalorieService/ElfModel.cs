namespace AdventOfCode.ElfCalorieService
{
    public class ElfModel : IElfModel
    {
        public int Id { get; }

        public List<int> Calories { get; }

        public int TotalCalorie => Calories.Sum();

        public ElfModel(int id, List<int> calories)
        {
            Id = id;
            Calories = calories;
        }
    }
}
