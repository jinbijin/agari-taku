using AgariTaku.Shared.Types;

namespace AgariTaku.Shared.GameState
{
    public class BreakLocationLogic : IBreakLocationLogic
    {
        public int DetermineBreak(Player dealer, int die1, int die2)
        {
            return ((4 - (int)dealer) * 34 + (die1 + die2)) % 68; // Break location is per stack of two
        }
    }
}
