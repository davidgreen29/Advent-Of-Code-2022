using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day02
{
    public class PartOneAndTwo
    {


        public int[] RockPaperScissors(string data)
        {
            var read = new ReadText();
            string[] games = read.GameResults(data);
            int sum = 0;
            int P2Sum = 0;

            foreach (string gameLine in games)
            {
                string[] game = gameLine.Split(' ');

                switch (game[0])
                {
                    case "A": // Rock = 1
                        if (String.Equals(game[1], "X"))
                        {
                            sum += 4;
                            P2Sum += 3;
                        }
                        else if (String.Equals(game[1], "Y"))
                        {
                            sum += 8;
                            P2Sum += 4;
                        }
                        else
                        {
                            sum += 3;
                            P2Sum += 8;
                        }
                        break;
                    case "B": // Paper = 2
                        if (game[1].Equals("X"))
                        {
                            sum += 1;
                            P2Sum += 1;
                        }
                        else if (game[1].Equals("Y"))
                        {
                            sum += 5;
                            P2Sum += 5;
                        }
                        else
                        {
                            sum += 9;
                            P2Sum += 9;
                        }
                        break;
                    case "C": // Scissors = 3
                        if (game[1].Equals("X"))
                        {
                            sum += 7;
                            P2Sum += 2;
                        }
                        else if (game[1].Equals("Y"))
                        {
                            sum += 2;
                            P2Sum += 6;
                        }
                        else
                        {
                            sum += 6;
                            P2Sum += 7;
                        }
                        break;
                }
            }
            int[] solutions = new int[] { sum, P2Sum };
            return solutions;

        }
        
    }

}
