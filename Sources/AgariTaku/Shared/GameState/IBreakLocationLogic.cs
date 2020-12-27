using AgariTaku.Shared.Types;

namespace AgariTaku.Shared.GameState
{
    public interface IBreakLocationLogic
    {
        int DetermineBreak(Player dealer, int die1, int die2);
    }
}
