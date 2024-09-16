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
            Console.WriteLine("Welcome to Snake Game!");
            Console.WriteLine("1. Start Game");
            Console.WriteLine("2. Rules");
            Console.WriteLine("3. Exit");

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
            Console.WriteLine("Select difficulty level:");
            Console.WriteLine("1. Easy (Slow speed)");
            Console.WriteLine("2. Medium (Normal speed)");
            Console.WriteLine("3. Hard (Fast speed)");

            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.D1)
                return 300; // Easy speed
            else if (key.Key == ConsoleKey.D2)
                return 150; // Medium speed
            else if (key.Key == ConsoleKey.D3)
                return 50;  // Hard speed

            return 150; // Default to Medium
        }

        public static void ShowRules()
        {
            Console.Clear();
            Console.WriteLine("Game Rules:");
            Console.WriteLine("Eat food to gain points.");
            Console.WriteLine("Different foods give different points:");
            Console.WriteLine("1. Apple ($) = 1 point");
            Console.WriteLine("2. Banana (@) = 2 points");
            Console.WriteLine("3. Cherry (#) = 3 points");
            Console.WriteLine("Avoid hitting walls or your own tail.");
            Console.WriteLine("Press any key to return...");
            Console.ReadKey();
        }
    }
}