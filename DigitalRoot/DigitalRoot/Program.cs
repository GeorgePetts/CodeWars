using System;
using System.Linq;

namespace DigitalRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Number.DigitalRoot(456));
        }
    }
    public class Number
    {
        public static int DigitalRoot(long n)
        {
            int dr = n.ToString().ToCharArray().Select(c => Convert.ToInt32(c.ToString())).Sum();
            if (dr < 10)
                return dr;
            else
                return DigitalRoot(dr);
        }
    }
}
