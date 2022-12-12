using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day06
{
    public class NumOfCharsProccesedPart1
    {

        public int NumOfCharsPart1(string file)
        {
            var newData = new TextFileReaderDay06();
            string chars = newData.day06Data(file);
            Dictionary<char, int> dict = new Dictionary<char, int>();  

            int count = 0;
            
            int i = 0;
            int answer = 0;
            
           

            while (i < chars.Length)
            {
                count += 1;
                if (!dict.ContainsKey(chars[i])){
                    dict.Add(chars[i], i); 
                }
                if (count ==4 && dict.Count == 4)
                {
                  answer = i + 1  ;
                  break;
                }
                if (count==4)
                {
                    dict.Clear();
                    count = 0;
                    i = i - 3;
                }
                i += 1; 
                
            }

            return answer;
        }
    }
}
