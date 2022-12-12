using day05;
using System.Runtime.CompilerServices;

public class Program
{
    static void Main(string[] args)
    {
        string path = @"C:\Users\green\source\repos\advent-of-code-2022\day05\day05Data.txt";
        //part one
        var newCrateStruct = new CrateOnTopSolutionP1();
        string solution = newCrateStruct.CrateOnTopP1(path);
        Console.WriteLine(solution);

       
        //part two
        var newCrateStrucP2 = new CratesOnTopSolutionP2();
        string solutionP2 = newCrateStrucP2.CratesOntopP2(path);
        Console.WriteLine(solutionP2);
    }
}
