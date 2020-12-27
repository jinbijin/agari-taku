using AgariTaku.Shared.Types;

namespace AgariTaku.Shared.GameState
{
    public interface ITileMapping
    {
        TileValue this[int index] { get; }
    }
}
