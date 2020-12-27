using AgariTaku.Shared.GameState;
using FluentAssertions;
using Xunit;

namespace AgariTaku.Shared.Tests
{
    public class WallIndexConverterTests
    {
        [Theory]
        // Small draw indices
        [InlineData(34, 3, 71)]
        [InlineData(34, 2, 70)]
        [InlineData(34, 1, 69)]
        [InlineData(34, 0, 68)]
        [InlineData(34, -1, 66)]
        [InlineData(34, -2, 67)]
        [InlineData(34, -3, 64)]
        [InlineData(34, -4, 65)]
        // Varying breaks
        [InlineData(0, 0, 0)]
        [InlineData(1, 0, 2)]
        [InlineData(2, 0, 4)]
        // Underflow
        [InlineData(0, -14, 123)]
        // Overflow
        [InlineData(51, 68, 34)]
        public void WallIndexConverterShouldSatisfyTheory(int breakLocation, int drawIndex, int expectedIndex)
        {
            // Arrange
            IWallIndexConverter converter = new WallIndexConverter();

            // Act
            int actualIndex = converter.Convert(breakLocation, drawIndex);

            // Assert
            actualIndex.Should().Be(expectedIndex);
        }
    }
}
