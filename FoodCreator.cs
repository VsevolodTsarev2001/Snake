using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class FoodCreator
    {
        int mapWidth;
        int mapHeight;
        Random random = new Random();

        public FoodCreator(int mapWidth, int mapHeight)
        {
            this.mapWidth = mapWidth;
            this.mapHeight = mapHeight;
        }

        public Point CreateFood()
        {
            int x = random.Next(2, mapWidth - 2);
            int y = random.Next(2, mapHeight - 2);

            char sym;
            int points;
            int randomFoodType = random.Next(1, 4); // Valige juhuslikult toidutüüp

            if (randomFoodType == 1)
            {
                sym = '$';  // õun
                points = 1;
            }
            else if (randomFoodType == 2)
            {
                sym = '@';  // Banaan
                points = 2;
            }
            else
            {
                sym = '#';  // Kirss
                points = 3;
            }

            return new FoodPoint(x, y, sym, points);
        }
    }
     
    public class FoodPoint : Point
    {
        public int Points { get; private set; }

        public FoodPoint(int x, int y, char sym, int points) : base(x, y, sym)
        {
            Points = points;
        }
    }

}