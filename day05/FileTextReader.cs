using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace day05
{
    public class FileTextReader
    {
       public  List<string[]>? procdureResults;
        public string regex = @"move (\d+) from (\d+) to (\d+)";
        public char[] charSeperators = new char[] {' '};
        public List<string[]> ReadProcedures(string fileName) 
        { 
            var input = File.ReadAllText(fileName);
            procdureResults = input.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => Regex.Split(x, @"\D+").Where(s => s != String.Empty).ToArray<string>())
                .ToList();
                
            return procdureResults;
        }
    }
}
