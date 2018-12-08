using System;
using System.Collections.Generic;
using System.Threading;
using System.Text;

namespace snake
{
    internal class Program
    {
        public static void Main(string[] args)
        {   
            // Отрисовка рамочки
            HorizontalLine upLine = new HorizontalLine(0, 150, 0, '+');
            HorizontalLine downLine = new HorizontalLine(0, 150, 15, '+');
            VerticalLine leftLine = new VerticalLine(0, 15, 0, '+');
            VerticalLine rightLine = new VerticalLine(0, 15, 150, '+');
//            upLine.Draw();
//            downLine.Draw();
//            leftLine.Draw();
//            rightLine.Draw();
            
            // Отрисовка точек
            Point p = new Point(5, 4, '*');
            Snake snake = new Snake(p, 3, Direction.RIGHT);
            snake.Draw();

            FoodCreator foodCreator = new FoodCreator( 80, 25, '$' );
            Point food = foodCreator.CreateFood();
            food.Draw();
            
            while (true)
            {
                if(snake.Eat( food ) )
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }					

                Thread.Sleep( 100 );

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey( key.Key );
                }
            }
        }
    }
}