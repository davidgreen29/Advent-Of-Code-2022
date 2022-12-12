using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day04
{
    public class TextFileReader
    {

        public List<string[]>? rangeResults;
        public char[] charSeperators = new char[] {',','-' };
        
        public List<string[]> ReadRanges(string fileName)
        {
            var input = File.ReadAllText(fileName);
            rangeResults = input.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries)
                .Select(x=>x.Split(charSeperators)).ToList();
            return rangeResults;
        }
              
    }
}
