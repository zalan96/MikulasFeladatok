using System.Threading.Channels;

namespace MikulasFeladatok
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/*
			elso();
			masodik();
			harmadik();
			*/
			Console.ReadLine();
		}
		static void elso()
		{
			Console.WriteLine("Adja meg a gyerek nevét: ");
			string nev = Console.ReadLine();

			Console.WriteLine($"Hány ajándékot kapjon {nev}?");
			try
			{
				int ajandekSzam = Convert.ToInt32(Console.ReadLine());
				if (ajandekSzam < 0)
					throw new Exception("Az ajándékok száma nem lehet negatív!");

				Console.WriteLine($"{nev} {ajandekSzam} ajándékot fog kapni!");
			}
			catch (FormatException)
			{
				Console.WriteLine("Csak számot lehet megadni!");
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Hiba: {ex.Message}");
			}
		}
		static void masodik()
		{
			int[] raktar = { 10, 5, 0 };//ajándékok: játékok, édességek, ruhák
			string[] ajandekTipusok = { "játék", "édesség", "ruha" };

            for (int i = 0; i < raktar.Length; i++)
            {
                Console.WriteLine($"Nincs elég {ajandekTipusok[i]}! Töltsd fel a raktárat!");
				try
				{
					int feltoltes = Convert.ToInt32(Console.ReadLine());
					if (feltoltes < 0)
						throw new Exception("A feltöltés mennyiségének pozitívnak kell lennie!");

					raktar[i] = feltoltes;
                    Console.WriteLine($"A raktár feltöltve: {raktar[i]} db {ajandekTipusok[i]}.");
                }
				catch(FormatException)
				{
					Console.WriteLine("Csak számot lehet megadni!");
				}
				catch(Exception ex)
				{
                    Console.WriteLine($"Hiba: {ex.Message}");
                }
            }
        }
		static void harmadik()
		{
            Console.WriteLine("Hány gyerk kapott játékot:");
			int gyerekekSzama = 0;
			int osszErtek = 0;
            for (int i = 0; i < gyerekekSzama; i++)
            {
                Console.WriteLine($"Mennyi az {i}. gyerekek ajándékának értéke?");
				try
				{
					int ertek = Convert.ToInt32(Console.ReadLine());
					if (ertek < 0)
						throw new Exception("Az ajándék értéke nem lehet negatív");
					osszErtek += ertek;
				}catch(Exception ex)
				{
                    Console.WriteLine($"Hiba: {ex.Message}");
                }
            }
            Console.WriteLine($"Az ajándékok összértéke: {osszErtek}Ft");
        }
		static void negyedik()
		{
			List<string> nevek = new List<string>();
			List<int> numbers = new List<int>();
			bool ertek =false;
			while (ertek==false)
			{

			}


		}
	}
}
