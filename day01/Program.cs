
using System.Linq;
using System;
using System.Collections.Generic;
using day01;

class Program
{
    static void Main(string[] args)
    {
        string filePath = @"C:\Users\green\source\repos\advent-of-code-2022\day01\day01Data.txt";

        var readText = new ReadCaloriesTxtFile();
        List<List<int>> caloriesList = readText.CaloriesList(filePath);

        //max value using Select
        int max = caloriesList.Select(i => i.Sum())
                    .Max();
        Console.WriteLine(max);

        // sum of 3 largest calories
        int threeLargest = caloriesList.Select(i => i.Sum())
                           .OrderByDescending(i => i)
                           .Take(3)
                           .Sum();
        Console.WriteLine(threeLargest);

        //max value of calories
        List<int> sums = new List<int>();
        for (int i = 0; i < caloriesList.Count; i++)
        {
            int sum = caloriesList[i].Sum();
            sums.Add(sum);
        }
        sums.Sort();

        Console.WriteLine(sums[sums.Count - 1]);

        //sum of top 3 calories
        Console.WriteLine(sums[sums.Count - 1] + sums[sums.Count - 2] + sums[sums.Count - 3]);



    }
}