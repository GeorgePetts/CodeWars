using System;
using System.Linq;
namespace TenMinuteWalk
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.IsValidWalk(new string[] { "n", "s", "n", "s", "n", "s", "n", "s", "n", "s" }));
        }
    }
    public class Kata
    {
        public static bool IsValidWalk(string[] walk)
        {
            if (walk.Count() != 10)
                return false;
            else
            {

                int ncount = walk.Where(c => c == "n").Count();
                int scount = walk.Where(c => c == "s").Count();
                int ecount = walk.Where(c => c == "e").Count();
                int wcount = walk.Where(c => c == "w").Count();

                return ncount == scount && ecount == wcount;
            }
        }
    }
}
