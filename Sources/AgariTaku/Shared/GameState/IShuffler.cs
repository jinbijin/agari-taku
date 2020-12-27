using System.Collections.Generic;

namespace AgariTaku.Shared.GameState
{
    public interface IShuffler
    {
        public IReadOnlyCollection<T> Shuffle<T>(IReadOnlyCollection<T> values);
    }
}
