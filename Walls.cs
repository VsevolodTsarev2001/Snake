using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Walls
    {
        private List<Figure> wallList;
        private ConsoleColor wallColor;

        public Walls(int mapWidth, int mapHeight, ConsoleColor wallColor)
        {
            wallList = new List<Figure>();
            this.wallColor = wallColor;

            // Создание рамки
            HorizontalLine upLine = new HorizontalLine(0, mapWidth - 2, 0, '+');
            HorizontalLine downLine = new HorizontalLine(0, mapWidth - 2, mapHeight - 1, '+');
            VerticalLine leftLine = new VerticalLine(0, mapHeight - 1, 0, '+');
            VerticalLine rightLine = new VerticalLine(0, mapHeight - 1, mapWidth - 2, '+');

            wallList.Add(upLine);
            wallList.Add(downLine);
            wallList.Add(leftLine);
            wallList.Add(rightLine);
        }

        public void Draw()
        {
            Console.ForegroundColor = wallColor;
            foreach (var wall in wallList)
            {
                wall.Draw();
            }
            Console.ResetColor();
        }

        internal bool IsHit(Figure figure)
        {
            foreach (var wall in wallList)
            {
                if (wall.IsHit(figure))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
