using System;
using System.Collections.Generic;
using System.Linq;

namespace PIN
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = Kata.GetPINs("11");
        }
    }
    public class Kata
    {
        public  string[][] PDigits;
        public static List<string> GetPINs(string observed)
        {
            List<string> possibleNums = new List<string>();

            string[][] PDigits = new string[10][];
            PDigits[0] = new[] {"0", "8" };
            PDigits[1] = new[] {"1", "2", "4" };
            PDigits[2] = new[] {"2", "1", "3", "5" };
            PDigits[3] = new[] {"3", "2", "6" };
            PDigits[4] = new[] {"4", "1", "5", "7" };
            PDigits[5] = new[] {"5", "2", "4", "6", "8" };
            PDigits[6] = new[] {"6", "3", "5", "9" };
            PDigits[7] = new[] {"7", "4", "8" };
            PDigits[8] = new[] {"8", "0", "5", "7", "9" };
            PDigits[9] = new[] {"9", "6", "8" };

            var obsNum = observed.ToCharArray().Select(c => Convert.ToInt32(c.ToString())).ToArray();
            GetCombinations(obsNum, PDigits, 0, "", possibleNums);

            return possibleNums;
        }
        private static void GetCombinations(int[] obsNum, string[][] PDigits, int depth, string comboStart, List<string> possibleNums)
        {
            if (depth == obsNum.Count())
            {
                possibleNums.Add(comboStart);
                return;
            }
            string comboContinue;
            for (int i = 0; i < PDigits[obsNum[depth]].Length; i++)
            {
                comboContinue = comboStart + PDigits[obsNum[depth]][i];
                GetCombinations(obsNum, PDigits, depth + 1, comboContinue, possibleNums);
            }
        }
    }
}
