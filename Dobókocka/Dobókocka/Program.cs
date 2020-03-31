using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dobókocka
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Dobókocka");
			Console.WriteLine("Kezdéshez nyomj entert!:)");
			Console.ReadLine();

			string igen = "I";
			string igen_egy = "i";
			string nem = "N";
			string nem_egy = "n";
			bool a = true;
	

			while (a == true)
			{
				
				Console.WriteLine("A dobáshoz nyomj I betűt!\nKilépéshez N betűt");
				string valasz = Console.ReadLine();
				Console.Clear();

				if (valasz == igen)
				{	
					Random randomszam = new Random();
					int dobas = randomszam.Next(1, 7);
					Console.WriteLine("\n   {0}\n", dobas);
				}
				else if (valasz == igen_egy)
				{
					Random randomszam = new Random();
					int dobas = randomszam.Next(1, 7);
					Console.WriteLine("\n   {0}\n", dobas);
				}
				else if (valasz == nem)
				{
					Console.WriteLine("Köszönöm a játékot:)");
					a = false;

				}
				else if (valasz == nem_egy)
				{
					Console.WriteLine("Köszönöm a játékot!");
					a = false;
				}
				else
				{
					Console.WriteLine("Kérem pontosan írjon");
					Console.WriteLine("\nDobjunk újat? (I/N)");
					Console.ReadLine();
					Console.Clear();
				}
			}
				Console.ReadLine();
		}
	}
}
