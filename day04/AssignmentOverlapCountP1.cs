using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day04
{
    public class AssignmentOverlapCountP1
    {

        public int Overlaps(string file)
        {
            var data = new TextFileReader();
            List<string[]> dataResult = data.ReadRanges(file);
            int count = 0;

            foreach(var pair in dataResult)
            {
                bool notCounted = true;
                if (Int32.Parse(pair[0]) >= Int32.Parse(pair[2])&& Int32.Parse(pair[1]) <= Int32.Parse(pair[3])&& notCounted )
                {
                    count += 1;
                    notCounted = false;
                }
                if(Int32.Parse(pair[2]) >= Int32.Parse(pair[0]) && Int32.Parse(pair[3]) <= Int32.Parse(pair[1]) && notCounted)
                {
                    count += 1;
                    notCounted=false;
                }
            }
            return count;

        }
    }
}
