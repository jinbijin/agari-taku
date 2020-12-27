using AgariTaku.Shared.Types;

namespace AgariTaku.Shared.GameState
{
    public class TileMappingFactory : ITileMappingFactory
    {
        private readonly ITileGenerator _generator;
        private readonly IShuffler _shuffler;
        private readonly IBreakLocationLogic _breakLogic;
        private readonly IWallIndexConverter _wallIndexConverter;

        public TileMappingFactory(ITileGenerator generator, IShuffler shuffler, IBreakLocationLogic breakLogic, IWallIndexConverter wallIndexConverter)
        {
            _generator = generator;
            _shuffler = shuffler;
            _breakLogic = breakLogic;
            _wallIndexConverter = wallIndexConverter;
        }

        public ITileMapping Create(Player dealer)
        {
            return new TileMapping(_generator, _shuffler, _breakLogic, _wallIndexConverter, dealer);
        }
    }
}
