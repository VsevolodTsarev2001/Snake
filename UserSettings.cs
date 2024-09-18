using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class UserSettings
    {
        public string PlayerName { get; private set; }
        public ConsoleColor WallColor { get; private set; }

        public UserSettings()
        {
            // Ввод имени пользователя
            Console.WriteLine("Sisestage oma nimi: ");
            PlayerName = Console.ReadLine();

            // Выбор цвета стен
            Console.WriteLine("Valige seina värv: ");
            Console.WriteLine("1. Valge");
            Console.WriteLine("2. Kollane");
            Console.WriteLine("3. Sinnine");
            ConsoleKeyInfo wallColorKey = Console.ReadKey();
            WallColor = ConsoleColor.White;
            if (wallColorKey.Key == ConsoleKey.D1)
                WallColor = ConsoleColor.White;
            else if (wallColorKey.Key == ConsoleKey.D2)
                WallColor = ConsoleColor.Yellow;
            else if (wallColorKey.Key == ConsoleKey.D3)
                WallColor = ConsoleColor.Blue;
        }
    }
}