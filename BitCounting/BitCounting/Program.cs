using System;

namespace BitCounting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.CountBits(256));
        }
    }
    public class Kata
    {
        public static int CountBits(int n)
        {
            UInt32 un = (uint)n;
            UInt32 numbits = 0;
            while (un > 0)
            {
                numbits += (un & 1);
                un = un >> 1;
            }
            return (int)numbits;
        }
    }
}
