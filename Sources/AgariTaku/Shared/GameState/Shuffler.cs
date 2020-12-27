using System.Collections.Generic;
using System.Security.Cryptography;

namespace AgariTaku.Shared.GameState
{
    public class Shuffler : IShuffler
    {
        public IReadOnlyCollection<T> Shuffle<T>(IReadOnlyCollection<T> values)
        {
            List<T> shuffledList = new();
            foreach (T value in values)
            {
                int shuffledCount = shuffledList.Count;
                int insertionIndex = RandomNumberGenerator.GetInt32(shuffledCount + 1);
                shuffledList.Insert(insertionIndex, value);
            }

            return shuffledList;
        }
    }
}
