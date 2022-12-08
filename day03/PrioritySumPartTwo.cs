using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day03
{
    public class PrioritySumPartTwo
    {
        public int pSumPartTwo(string file)
        {
            var priortiesData = new ReadTextData();
            string[] priorites = priortiesData.Priorties(file);
            int sum = priorites.Chunk(3)
                      .Select(x => x[0].Intersect(x[1]).Intersect(x[2]).First())
                      .Select(c => char.IsUpper(c) ? c - 38 : c - 96)
                      .Sum();
            return sum;
        }
    }
}
