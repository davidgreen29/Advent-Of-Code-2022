using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day03
{
    public class PrioritySum
    {
        public int PrioritiesSum(string file)
        {
            var priortiesData = new ReadTextData();
            string[] priorites = priortiesData.Priorties(file);
            int prioritySum = 0;
            List<char> uniqueVals = new();

            foreach (var ruckSack in priorites)
            {
                string ruckCompartment1 = ruckSack.Substring(0, ruckSack.Length / 2);
                string ruckCompartment2 = ruckSack.Substring(ruckSack.Length / 2);

                foreach (var letter in ruckCompartment1)
                {
                    if (ruckCompartment2.Contains(letter) && !uniqueVals.Contains(letter))
                    {
                        uniqueVals.Add(letter);
                        prioritySum += char.IsUpper(letter) ? letter - 38 : letter - 96;
                    }

                }
                uniqueVals.Clear();
            }
            return prioritySum;
        }

    }
}
