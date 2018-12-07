using System;
using System.Collections.Generic;

namespace snake
{
    internal class Program
    {
        public static void Main(string[] args)
        {   
            HorizontalLine upLine = new HorizontalLine(0, 5, 0, '+');
            HorizontalLine downLine = new HorizontalLine(0, 5, 5, '+');
            VerticalLine leftLine = new VerticalLine(0, 5, 0, '+');
            VerticalLine rightLine = new VerticalLine(0, 5, 5, '+');
            upLine.Draw();
            downLine.Draw();
            leftLine.Draw();
            rightLine.Draw();
            
            Point p = new Point(4, 5, '*');
            p.Draw();
        }
    }
}