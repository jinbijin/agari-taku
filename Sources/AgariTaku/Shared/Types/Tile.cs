namespace AgariTaku.Shared.Types
{
    public record Tile
    {
        public int TileId { get; init; }
        public TileValue? Value { get; init; }
    }
}
