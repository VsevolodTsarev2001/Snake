using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {
        public int x;
        public int y;
        public char sym;

        public Point()
        {

        }
        //Принемает 3 аргумента кординаты по оси x по оси y и символ
        public Point(int _x, int _y, char _sym)
        {
            x = _x;
            y = _y;
            sym = _sym;
        }

        public void Draw(  )
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }

}
