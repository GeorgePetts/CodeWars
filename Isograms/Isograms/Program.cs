using System;
using System.Collections.Generic;
using System.Linq;

namespace Isograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Kata.Test("2 4 7 8 10");
        }
    }

public class Kata
    {
        public static int Test(string numbers)
        {
            int[] NumArray = numbers.Split(" ").Select(s => Convert.ToInt32(s)).ToArray();
            int x = NumArray.Select(n => new { num = n, odd = n % 2 }).GroupBy(a => a.odd).Where(c => c.Count() == 1).First().First().num;
            //Your code is here...
            return Array.FindIndex(NumArray, i => i == x) + 1;
        }
    }
}
