using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class FoodCreator
    {
        private int mapWidth;
        private int mapHeight;
        private Random random = new Random();

        public FoodCreator(int mapWidth, int mapHeight)
        {
            this.mapWidth = mapWidth;
            this.mapHeight = mapHeight;
        }

        public FoodPoint CreateFood()
        {
            int x = random.Next(2, mapWidth - 2);
            int y = random.Next(2, mapHeight - 2);

            char sym;
            int points;
            ConsoleColor color;
            int randomFoodType = random.Next(1, 4); // Выбор случайного типа еды

            if (randomFoodType == 1)
            {
                sym = '$';  // Яблоко
                points = 1;
                color = ConsoleColor.Green;
            }
            else if (randomFoodType == 2)
            {
                sym = '@';  // Банан
                points = 2;
                color = ConsoleColor.Yellow;
            }
            else
            {
                sym = '#';  // Вишня
                points = 3;
                color = ConsoleColor.Red;
            }

            return new FoodPoint(x, y, sym, points, color);
        }
    }

    public class FoodPoint : Point
    {
        public int Points { get; private set; }
        public ConsoleColor FoodColor { get; private set; }

        public FoodPoint(int x, int y, char sym, int points, ConsoleColor color) : base(x, y, sym)
        {
            Points = points;
            FoodColor = color;
        }

        public new void Draw()
        {
            Console.ForegroundColor = FoodColor;
            base.Draw();
            Console.ResetColor();
        }
    }
}
