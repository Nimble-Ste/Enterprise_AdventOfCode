namespace AdventOfCode.ChunkerService
{
    using AdventOfCode.Common;

    public class ChunkerService : IChunkerService
    {
        public IDictionary<int, List<string>> ChunkIt(List<string> collection, IBlankEntryProvider blankEntryProvider)
        {
            IDictionary<int, List<string>> chunked = new Dictionary<int, List<string>>();

            var temp = new List<string>();
            int id = 0;

            foreach (var item in collection)
            {
                temp.Add(item);
                //new chunk
                if (item.Equals(blankEntryProvider.Empty))
                {
                    chunked.Add(id, temp);
                    id++;
                    temp = new List<string>();

                }
            }

            return chunked;
        }
        
    }
}