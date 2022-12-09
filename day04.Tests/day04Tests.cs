using FluentAssertions;
namespace day04.Tests
{
    public class day04Tests
    {
        
        
           
            [Theory]
            [InlineData(@"C:\Users\green\source\repos\advent-of-code-2022\day04.Tests\day04SampleData.txt", 2)]
            public void Assignment_Overlap_Part1_returns_the_specified_result(string file, int expected)
            {
                //arrange
                var assignment = new AssignmentOverlapCountP1();
                //act
                int solution = assignment.Overlaps(file);
                //assert
                solution.Should().Be(expected);
            }

            //part two 

            [Theory]
            [InlineData(@"C:\Users\green\source\repos\advent-of-code-2022\day04.Tests\day04SampleData.txt", 4)]

        public void Assignment_Overlap_Part2_returns_the_specified_result(string file, int expected)
        {
            //arrange
            var assignment = new AssignmentOverlapP2();
            //act
            int solution = assignment.OverlapsPart2(file);
            //assert
            solution.Should().Be(expected);
        }


    }
}