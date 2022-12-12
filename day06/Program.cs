using day06;

public class Program
{
    static void Main(string[] args)
    {

        string path = @"C:\Users\green\source\repos\advent-of-code-2022\day06\day06Data.txt";

        //part one
        var newSolutionP1 = new NumOfCharsProccesedPart1();
        int solutionP1 = newSolutionP1.NumOfCharsPart1(path);
        Console.WriteLine(solutionP1);

        //part two 
        var newSolutionP2 = new NumOfCharsProccessedPart2();
        int solutionP2 = newSolutionP2.NumOfCharsPart2(path);
        Console.WriteLine(solutionP2);




    }
}
