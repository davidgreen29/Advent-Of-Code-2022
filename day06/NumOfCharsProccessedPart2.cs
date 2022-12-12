using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day06
{
    public class NumOfCharsProccessedPart2
    {

        public int NumOfCharsPart2(string file)
        {
        var newData = new TextFileReaderDay06();
        string chars = newData.day06Data(file);
        Dictionary<char, int> dict = new Dictionary<char, int>();

        int count = 0;

        int i = 0;
        int answer = 0;
            
           

            while (i<chars.Length)
            {
                count += 1;
                if (!dict.ContainsKey(chars[i])){
                    dict.Add(chars[i], i); 
                }
                if (count ==14 && dict.Count == 14)
                {
                  answer = i + 1  ;
                  break;
                }
                if (count == 14)
                {
                    dict.Clear();
                    count = 0;
                    i = i - 13;
                }
                i += 1; 
                
            }

            return answer;
        }
    }
}
