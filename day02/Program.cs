using day02;

public class Program
{
    static void Main(string[] args)
    {
        string path = @"C:\Users\green\source\repos\advent-of-code-2022\day02\day02Data.txt";

        var game = new PartOneAndTwo();

        int[] solution = game.RockPaperScissors(path);

        Console.WriteLine(solution[0]);
        Console.Write(solution[1]);

    }
}

