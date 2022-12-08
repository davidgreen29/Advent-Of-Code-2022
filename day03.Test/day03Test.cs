using FluentAssertions;

namespace day03.Test
{
    public class day03Test
    {
        [Theory]
        [InlineData(@"C:\Users\green\source\repos\advent-of-code-2022\day03.Test\day03TestData.txt", 157)]
        public void PrioritySum_returns_The_Specified_amount(string file, int expected)
        {
            //arrange
            var prioritiesSum = new PrioritySum();
            //act
            int solution = prioritiesSum.PrioritiesSum(file);
            //assert
            solution.Should().Be(expected);
        }

        //part two 

        [Theory]
        [InlineData(@"C:\Users\green\source\repos\advent-of-code-2022\day03.Test\day03TestData.txt", 70)]

        public void PrioritySum_part_two_returns_the_specified_amount(string file, int expected)
        {
            var part2 = new PrioritySumPartTwo();

            int result = part2.pSumPartTwo(file);

            result.Should().Be(expected);
        }
    }
}