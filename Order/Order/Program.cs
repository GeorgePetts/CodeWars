using System;
using System.Linq;

namespace Order
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.Order("4of Fo1r pe6ople g3ood th5e the2"));
        }
    }
    public static class Kata
    {
        public static string Order(string words)
        {
            if (words == "") 
            { 
                return words; 
            }
            else
            {
                return String.Join(" ", words.Split(" ").OrderBy(w => getNumber(w)).Select(w => w).ToArray());
            }
        }
        private static int getNumber(string word) => Convert.ToInt32(word.ToCharArray().Where(c => Char.IsNumber(c)).First());
    }
}
