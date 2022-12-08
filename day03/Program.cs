using day03;

public class Program
{
    static void Main(string[] args)
    {
        string path = @"C:\Users\green\source\repos\advent-of-code-2022\day03\day03Data.txt";
        var newRuckSacks = new PrioritySum();

        int result = newRuckSacks.PrioritiesSum(path);
        Console.WriteLine(result);

        var partTwo = new PrioritySumPartTwo();
        int sum = partTwo.pSumPartTwo(path);
        Console.WriteLine(sum);
    }
}
