using AgariTaku.Shared.Types;
using System.Collections.Generic;
using System.Linq;

namespace AgariTaku.Shared.GameState
{
    public class TileMapping : ITileMapping
    {
        private readonly IWallIndexConverter _wallIndexConverter;

        private readonly TileValue[] _tiles;
        private readonly int _breakLocation;

        public TileMapping(ITileGenerator generator, IShuffler shuffler, IBreakLocationLogic breakLogic, IWallIndexConverter wallIndexConverter, Player player, int die1, int die2)
        {
            _tiles = shuffler.Shuffle(generator.GenerateTiles()).ToArray();
            _breakLocation = breakLogic.DetermineBreak(player, die1, die2);
            _wallIndexConverter = wallIndexConverter;
        }

        public TileValue this[int index] => _tiles[_wallIndexConverter.Convert(_breakLocation, index)];

        public IReadOnlyCollection<TileValue> Slice(int index, int count) => Enumerable.Range(index, count).Select(i => this[i]).ToList();
    }
}
