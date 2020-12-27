using AgariTaku.Shared.Types;
using System.Collections.Generic;

namespace AgariTaku.Shared.GameState
{
    public interface ITileGenerator
    {
        IReadOnlyCollection<TileValue> GenerateTiles();
    }
}
