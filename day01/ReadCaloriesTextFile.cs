using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day01
{
    public class ReadCaloriesTxtFile
    {
        public List<List<int>> calories;
        public List<List<int>> CaloriesList(string fileName)
        {
            var input = File.ReadAllText(fileName);
            calories = input
                .Split(Environment.NewLine + Environment.NewLine, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList())
                .ToList();


            return calories;
        }
    }
}
