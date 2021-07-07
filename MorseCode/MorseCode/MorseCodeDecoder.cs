using System.Text;
using System.IO;
using System;
using System.Collections.Generic;

class MorseCodeDecoder
{
    public static string Decode(string morseCode)
    {
        Dictionary<string, string> MorseCode = new Dictionary<string, string>();
        MorseCode.Add("A", ".-");
        MorseCode.Add("B", "-...");
        MorseCode.Add("C", "-.-.");
        MorseCode.Add("D", "-..");
        MorseCode.Add("E", ".");
        MorseCode.Add("F", "..-.");
        MorseCode.Add("G", "--.");
        MorseCode.Add("H", "....");
        MorseCode.Add("I", ".. ");
        MorseCode.Add("J", ".---");
        MorseCode.Add("K", "-.-");
        MorseCode.Add("L", ".-..");
        MorseCode.Add("M", "--");
        MorseCode.Add("N", "-.");
        MorseCode.Add("O", "---");
        MorseCode.Add("P", ".--.");
        MorseCode.Add("Q", "--.-");
        MorseCode.Add("R", ".-.");
        MorseCode.Add("S", "...");
        MorseCode.Add("T", "-");
        MorseCode.Add("U", "..-");
        MorseCode.Add("V", "...-");
        MorseCode.Add("W", ".--");
        MorseCode.Add("X", "-..-");
        MorseCode.Add("Y", "-.--");
        MorseCode.Add("Z", "--.."       ;
        string MCLine = morseCode.Trim();
        string[] codedLetters = MCLine.Split(" ");
        StringBuilder sb = new StringBuilder();
        foreach (var cl in codedLetters)
        {
            Console.WriteLine(cl);
            if (cl != " ")
                sb.Append(MorseCode[cl]);
            else
                sb.Append(cl);
        }
        return sb.ToString();
    }
}