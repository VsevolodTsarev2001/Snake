using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class GameMenu
    {
        public static int ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("Tere tulemast Snake mängu!");
            Console.WriteLine("1. Alusta mängu");
            Console.WriteLine("2. Reeglid");
            Console.WriteLine("3. Välju");

            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.D1)
            {
                return SelectDifficulty();
            }
            else if (key.Key == ConsoleKey.D2)
            {
                ShowRules();
                return ShowMenu();
            }
            else if (key.Key == ConsoleKey.D3)
            {
                Environment.Exit(0);
            }

            return ShowMenu();
        }

        public static int SelectDifficulty()
        {
            Console.Clear();
            Console.WriteLine("Valige raskusaste:");
            Console.WriteLine("1. Lihtne (aeglane kiirus)");
            Console.WriteLine("2. Keskmine (tavaline kiirus)");
            Console.WriteLine("3. Raske (kiire kiirus)");

            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.D1)
                return 300; // Lihtne kiirus
            else if (key.Key == ConsoleKey.D2)
                return 150; // Keskmine kiirus
            else if (key.Key == ConsoleKey.D3)
                return 50;  // Raske kiirus

            return 150; // Default to Medium
        }

        public static void ShowRules()
        {
            Console.Clear();
            Console.WriteLine("Mängureeglid:");
            Console.WriteLine("Punktide kogumiseks sööge toitu.");
            Console.WriteLine("Erinevad toidud annavad erinevaid punkte:");
            Console.WriteLine("1. õun ($) = 1 punkt");
            Console.WriteLine("2. Banaan (@) = 2 punktid");
            Console.WriteLine("3. Kirss (#) = 3 punktid");
            Console.WriteLine("Vältige seina või enda saba löömist.");
            Console.WriteLine("Naasmiseks vajutage suvalist klahvi...");
            Console.ReadKey();
        }
    }
}