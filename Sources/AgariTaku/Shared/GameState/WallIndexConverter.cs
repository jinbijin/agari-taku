namespace AgariTaku.Shared.GameState
{
    public class WallIndexConverter : IWallIndexConverter
    {
        public int Convert(int breakLocation, int drawIndex)
        {
            return drawIndex >= 0
                ? (breakLocation * 2 + drawIndex) % 136
                : (136 + breakLocation * 2 + ((drawIndex + 1) / 2) * 2 + (-1) + (drawIndex % 2)) % 136;
        }
    }
}
