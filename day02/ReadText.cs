using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day02
{
    public class ReadText
    {
        public string[] gameResults;
        public string[] GameResults(string fileName)
        {
            var input = File.ReadAllText(fileName);
            gameResults = input.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
            return gameResults;
        }
    }
}
