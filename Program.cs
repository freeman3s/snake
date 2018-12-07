using System;
using System.Collections.Generic;

namespace snake
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Point p1 = new Point(1,3,'*');
            Point p2 = new Point(4,5,'#');
            
            List<int> numList = new List<int>();
            numList.Add(0);
            numList.Add(1);
            numList.Add(2);

            int x = numList[0];
            int y = numList[1];
            int z = numList[2];

            foreach (int i in numList)
            {
                Console.WriteLine(i);
            }
            
            List<Point> pList = new List<Point>();
            pList.Add(p1);
            pList.Add(p2);
        }
        
        public static void Func1( int value )
        {
			
        }

        public static void Func2( int value )
        {
            value = value + 1;
        }

        public static void Func3( int x )
        {
            x = x + 1;
        }

        public static void Move( Point p, int dx, int dy )
        {
            p.x += dx;
            p.y += dy;
        }

        public static void Update( Point p )
        {
            Point p2 = new Point(0, 0, '.');
            p = p2;
            Console.WriteLine( "Call Update. p1.x = " + p.x + ", p1.y = " + p.y  + ", p1.sym = " + p.sym );
        }

        
    }
}