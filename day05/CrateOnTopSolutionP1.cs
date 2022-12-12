using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace day05
{
    public class CrateOnTopSolutionP1
    {

        public string CrateOnTopP1(string file)
        {
            string topCrates = string.Empty;
            var newInput = new FileTextReader();
            var input = newInput.ReadProcedures(file);

            Stack<string> stack1 = new Stack<string>((new[] {"G", "T", "R","W"}));
            Stack<string> stack2 = new Stack<string>((new[] { "G","C","H","P","M","S","V","W" }));
            Stack<string> stack3 = new Stack<string>((new[] { "C","L","T","S","G","M"}));
            Stack<string> stack4 = new Stack<string>((new[] {"J","H","D","M","W","R","F"}));
            Stack<string> stack5 = new Stack<string>((new[] { "P", "Q", "L", "H", "S", "W", "F", "J" }));
            Stack<string> stack6 = new Stack<string>((new[] {"P","J","D","N","F","M","S"}));
            Stack<string> stack7 = new Stack<string>((new[] {"Z","B","D","F","G","C","S","J" }));
            Stack<string> stack8 = new Stack<string>((new[] { "R", "T", "B" }));
            Stack<string> stack9 = new Stack<string>((new[] { "H", "N", "W", "L", "C" }));

            Dictionary<int, Stack<string>> dictionary = new Dictionary<int, Stack<string>>();

            dictionary.Add(1, stack1);
            dictionary.Add(2, stack2);
            dictionary.Add(3, stack3);
            dictionary.Add(4, stack4);
            dictionary.Add(5, stack5);
            dictionary.Add(6, stack6);
            dictionary.Add(7, stack7);  
            dictionary.Add(8, stack8);
            dictionary.Add(9, stack9);


            foreach(var line in input)
            {
                int amount = Int32.Parse(line[0].ToString());
                int from = Int32.Parse(line[1].ToString());
                int to = Int32.Parse(line[2].ToString());
                var fromStack= dictionary[from];
                var toStack = dictionary[to];
                int i = 0;

                while(i < amount)
                {
                    var crate = fromStack.Pop();
                    toStack.Push(crate);
                    i += 1;
                }   
            }

            foreach(var crates in dictionary)
            {
                topCrates += crates.Value.Pop();
            }
            return topCrates;
        }
    }
}
