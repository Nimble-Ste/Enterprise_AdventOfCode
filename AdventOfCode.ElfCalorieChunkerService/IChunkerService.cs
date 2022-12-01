namespace AdventOfCode.ChunkerService;

using AdventOfCode.Common;

public interface IChunkerService
{
    IDictionary<int, List<string>> ChunkIt(List<string> collection, IBlankEntryProvider blankEntryProvider);
}