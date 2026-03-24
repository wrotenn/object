using System;
using System.Collections.Generic;
public class program
{
    public static void Main(string[] args)
    {
        List<string> imiona = new List<string>();
        imiona.Add("Arkadiusz");
        imiona.Add("Wiesław");
        imiona.Add("Stanisław");
        imiona.Add("Henryk");
        imiona.Add("Robert");
        imiona.Add("Władysław");
        imiona.Add("Ferdynand");
        imiona.Add("Marian");
        imiona.Add("Arnold");
        imiona.Add("Edward");

        for (int i = imiona.Count - 1; i >= 0; i--)
        {
            Console.WriteLine(imiona[i]);
        }
}
}