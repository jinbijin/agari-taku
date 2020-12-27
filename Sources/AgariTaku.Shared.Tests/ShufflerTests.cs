using AgariTaku.Shared.GameState;
using FluentAssertions;
using System.Collections.Generic;
using Xunit;

namespace AgariTaku.Shared.Tests
{
    public class ShufflerTests
    {
        [Fact]
        public void ShufflerShouldPermuteInput()
        {
            // Arrange
            IShuffler shuffler = new Shuffler();
            List<int> initialList = new() { 1, 2, 3 };

            // Act
            IReadOnlyCollection<int> shuffledList = shuffler.Shuffle<int>(initialList);

            // Assert
            shuffledList.Should().OnlyHaveUniqueItems();
            shuffledList.Should().BeEquivalentTo(initialList);
        }
    }
}
