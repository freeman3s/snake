using System;
using System.Collections.Generic;
using System.Threading;

namespace snake
{
    internal class Program
    {
        public static void Main(string[] args)
        {   
            HorizontalLine upLine = new HorizontalLine(0, 20, 0, '+');
            HorizontalLine downLine = new HorizontalLine(0, 20, 5, '+');
            VerticalLine leftLine = new VerticalLine(0, 5, 0, '+');
            VerticalLine rightLine = new VerticalLine(0, 5, 20, '+');
            upLine.Draw();
            downLine.Draw();
            leftLine.Draw();
            rightLine.Draw();
            
            Point p = new Point(5, 4, '*');
            Snake snake = new Snake(p, 3, Direction.RIGHT);
            snake.Draw();
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
        }
    }
}