using AgariTaku.Shared.Types;
using System.Linq;
using System.Security.Cryptography;

namespace AgariTaku.Shared.GameState
{
    public class TileMapping : ITileMapping
    {
        private readonly IWallIndexConverter _wallIndexConverter;

        private readonly TileValue[] _tiles;
        private readonly int _breakLocation;

        public TileMapping(ITileGenerator generator, IShuffler shuffler, IBreakLocationLogic breakLogic, IWallIndexConverter wallIndexConverter, Player player)
        {
            _tiles = shuffler.Shuffle(generator.GenerateTiles()).ToArray();
            _breakLocation = breakLogic.DetermineBreak(player, RandomNumberGenerator.GetInt32(6), RandomNumberGenerator.GetInt32(6));
            _wallIndexConverter = wallIndexConverter;
        }

        public TileValue this[int index] => _tiles[_wallIndexConverter.Convert(_breakLocation, index)];
    }
}
