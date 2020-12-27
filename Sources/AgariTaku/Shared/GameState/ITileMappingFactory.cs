using AgariTaku.Shared.Types;

namespace AgariTaku.Shared.GameState
{
    public interface ITileMappingFactory
    {
        ITileMapping Create(Player dealer, int die1, int die2);
    }
}
