using System;

namespace RGB
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.Rgb(0, 255, 300));
        }
    }
    public class Kata
    {
        public static string Rgb(int r, int g, int b)
        {
            r = Math.Min(r, 255); r = Math.Max(r, 0);
            g = Math.Min(g, 255); g = Math.Max(g, 0);
            b = Math.Min(b, 255); b = Math.Max(b, 0);
            return ((r * 65536) + (g * 256) + b).ToString("X6"); //.Substring(1);
        }
    }
}
