using AgariTaku.Shared.GameState;
using AgariTaku.Shared.Types;
using FluentAssertions;
using Xunit;

namespace AgariTaku.Shared.Tests
{
    public class BreakLocationLogicTests
    {
        [Theory]
        // Varying players
        [InlineData(Player.East, 1, 1, 2)]
        [InlineData(Player.South, 1, 1, 53)]
        [InlineData(Player.West, 1, 1, 36)]
        [InlineData(Player.North, 1, 1, 19)]
        // Varying sum
        [InlineData(Player.East, 6, 6, 12)]
        [InlineData(Player.South, 4, 2, 57)]
        [InlineData(Player.West, 3, 6, 43)]
        [InlineData(Player.North, 1, 5, 23)]
        public void BreakLocationLogicShouldSatisfyTheory(Player dealer, int die1, int die2, int expectedLocation)
        {
            // Arrange
            IBreakLocationLogic logic = new BreakLocationLogic();

            // Act
            int actualLocation = logic.DetermineBreak(dealer, die1, die2);

            // Assert
            actualLocation.Should().Be(expectedLocation);
        }
    }
}
