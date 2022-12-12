using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day06
{
    public class TextFileReaderDay06
    {


        public string day06Data(string file)
        {
            var input = File.ReadAllText(file);

            return input;
        }
    }
}
