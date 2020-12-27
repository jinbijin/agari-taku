using AgariTaku.Shared.Types;
using System.Collections.Generic;
using System.Linq;

namespace AgariTaku.Shared.GameState
{
    public class TileGenerator : ITileGenerator
    {
        public IReadOnlyCollection<TileValue> GenerateTiles()
        {
            IEnumerable<Suit> regularSuits = new List<Suit>
            {
                Suit.Man,
                Suit.Pin,
                Suit.Sou,
            };
            IEnumerable<TileValue> regularTiles = regularSuits
                .SelectMany(suit => Enumerable.Range(1, 9).Select(value => new TileValue(suit, value)))
                .SelectMany(tile => Enumerable.Repeat(tile, 4));

            IEnumerable<Suit> honorSuits = new List<Suit>
            {
                Suit.Ton,
                Suit.Nan,
                Suit.Shaa,
                Suit.Pei,
                Suit.Haku,
                Suit.Hatsu,
                Suit.Chun,
            };
            IEnumerable<TileValue> honorTiles = honorSuits
                .Select(suit => new TileValue(suit, 1))
                .SelectMany(tile => Enumerable.Repeat(tile, 4));

            return regularTiles.Concat(honorTiles).ToList();
        }
    }
}
