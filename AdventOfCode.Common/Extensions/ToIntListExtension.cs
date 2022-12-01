namespace AdventOfCode.Common.Extensions
{
    public static class ToIntListExtension
    {
        public static IEnumerable<int> ToIntList(this List<string> input)
        {
            foreach (var inputString in input)
            {
                if (inputString.Equals(new BlankEntryProvider().Empty))
                {
                    continue;
                }

                yield return int.Parse(inputString);
            }
        }
    }
}
