using System;

namespace snake
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int x = 1;
            Func1( x );
            Console.WriteLine( "Call Func1. x = " + x );

            x = 1;
            Func2( x );
            Console.WriteLine( "Call Func2. x = " + x );

            x = 1;
            Func3( x );
            Console.WriteLine( "Call Func3. x = " + x );

            Point p1 = new Point( 1, 3, '*' );
            Move( p1, 10, 10 );
            Console.WriteLine( "Call Move. p1.x = " + p1.x + ", p1.y = " + p1.y );

            Point p2 = new Point( 4, 5, '#' );
            p1 = new Point( 4, 5, '#' );
            p2.x = 8;
            p2.y = 8;
            Console.WriteLine( "p1 = p2. p1.x = " + p1.x + ", p1.y = " + p1.y + "; p2.x = "/* + p2.x + ", p2.y = " + p2.y*/ );

            p1 = new Point( 1, 3, '*' );
            Update( p1 );
            Console.WriteLine( "Call Update. p1.x = " + p1.x + ", p1.y = " + p1.y  + ", p1.sym = " + p1.sym );
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