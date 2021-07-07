using System;

namespace CamelCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.ToCamelCase("gmvxhmdogu_pugwdmteya_xxywooueoe"));
        }
    }
    public class Kata
    {
        public static string ToCamelCase(string str)
        {
            string[] strArray;
            if (str.Contains("-"))
                strArray = str.Split("-");
            else
                strArray = str.Split("_");

            for (int i = 1; i < strArray.Length; i++)
                strArray[i] = Capitalize(strArray[i]);
            str = String.Join("", strArray);
            return str;
        }
        private static string Capitalize(string s)
        {
            char[] c = s.ToCharArray();
            c[0] = Convert.ToChar(c[0].ToString().ToUpper());
            return new string(c);
        }
    }
}
