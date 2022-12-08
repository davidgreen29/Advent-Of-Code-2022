using FluentAssertions;
namespace day02.Test
{
    public class rockPaperScissorsTest
    {
        [Theory]
        [InlineData(@"C:\Users\green\source\repos\advent-of-code-2022\day02.Test\day02TestData.txt", new int[] { 15, 12 })]
        public void PartOneAndTWo_RockPaPerScissors_returnsTheSpecifiedScore(string file, int[] partOneAnTwo)
        {
            //arrange
            var game = new PartOneAndTwo();
            //act
            int[] solution = game.RockPaperScissors(file);
            //assert
            solution.Should().BeEquivalentTo(partOneAnTwo);
        }
    }
}