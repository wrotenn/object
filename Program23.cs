using System;
public class Program
{
	public static void Main(string[] args)
	{
		Console.WriteLine("Ile liczb calkowitych chcesz podac?:");
		int ilosc = Convert.ToInt32(Console.ReadLine());
		int[] tabLiczb = new int[ilosc];
		for (int i = 0; i < tabLiczb.Length; i++)
		{
			Console.WriteLine("Podaj liczbe");
			tabLiczb[i] = Convert.ToInt32(Console.ReadLine());
		}
		
		Console.WriteLine("Wypisuję liczby parzyste: ");
		
		foreach (var parzystosc in tabLiczb)
		{
			if(parzystosc % 2 == 0)
			{
				Console.Write(parzystosc + ", ");
			}
		}
	}
}