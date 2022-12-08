using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day03
{
    public class ReadTextData
    {
        public string[] ruckSacks;
        public string[] Priorties(string fileName)
        {
            var input = File.ReadAllText(fileName);
            ruckSacks = input.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
            return ruckSacks;
        }
    }
}
