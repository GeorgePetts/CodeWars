using System;

namespace MovieTickets
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] peopleInLine = new int[] { 25, 25, 50, 50 };
            Console.Write(Line.Tickets(peopleInLine));
        }
    }
    public class Line
    {
        public static string Tickets(int[] peopleInLine)
        {
            int count25 = 0;
            int count50 = 0;

            foreach(int t in peopleInLine)
            {
                switch (t)
                {
                    case 25:
                        count25++;
                        break;
                    case 50:
                        if (count25 > 0)
                        {
                            count50++;
                            count25--;
                        }
                        else
                        {
                            return "NO";
                        }
                        break;
                    case 100:
                        if(count50 > 0 && count25 > 0)
                        {
                            count50--;
                            count25--;
                        }
                        else
                        {
                            if(count25 > 2)
                            {
                                count25 -= 3;
                            }
                            else
                            {
                                return "NO";
                            }
                        }
                        break;
                }
            }
            return "YES";
        }
    }
}
