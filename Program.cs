using System;
using System.Collections.Generic;

namespace snake
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, '*');
            Point p2 = new Point(4,5,'#');
            
            HorizontalLine hLine = new HorizontalLine(0, 10, 1, '+');
            hLine.Draw();
            VerticalLine vLine = new VerticalLine(1, 3, 11, '+');
            vLine.Draw();
        }
    }
}