using System;

namespace snake
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, '*');
            
            Point p2 = new Point(4, 5, '#');

            p1 = p2;
            p1.x = 8;
            p1.y = 1;
            p2.Draw();
        }

        
    }
}