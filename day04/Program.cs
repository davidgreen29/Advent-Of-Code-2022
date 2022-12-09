
using day04;

public class Program
{
    static void Main(string[] args)
    {
        string Path = @"C:\Users\green\source\repos\advent-of-code-2022\day04\Day04Data.txt";

        var assignmentsP1 = new AssignmentOverlapCountP1();
         int resultPart1 = assignmentsP1.Overlaps(Path);
        Console.WriteLine(resultPart1);


        var assignmentP2 = new AssignmentOverlapP2();
        int resultPar2 = assignmentP2.OverlapsPart2(Path);
        Console.WriteLine(resultPar2);  


    }
}