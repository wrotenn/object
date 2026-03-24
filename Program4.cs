using System;
using System.Collections.Generic;
public class Program
{
    public static void Main(string[] args)
    {
        Dictionary<string, string> dictionary = new Dictionary<string, string>();
        dictionary.Add("Policja", "997");
        dictionary.Add("Straż Pożarna", "998");
        dictionary.Add("Pogotowie ratunkowe", "999");
        dictionary.Add("Numer Alarmowy", "112");
        dictionary.Add("Pogotowie gazowe", "992");
        dictionary.Add("Choroszcz", "(85) 719 10 91");

        foreach (KeyValuePair<string, string> pair in dictionary)
        {
            Console.WriteLine("{0}:{1}", pair.Key,pair.Value);
        }
    }
}