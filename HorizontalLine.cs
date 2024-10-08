﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class HorizontalLine : Figure
    {
        public HorizontalLine(int xleft, int xRight, int y, char sym)
        {
            pList = new List<Point>();
            for (int x = xleft; x <= xRight; x++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }
    }
}
