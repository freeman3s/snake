using System;

namespace snake
{
    public class Point
    {
        public int x;
        public int y;
        public char sym;

        public Point(int x, int y, char sym)
        {
            this.x = x;
            this.y = y;
            this.sym = sym;
        }
        
        public Point(Point p)
        {
            this.x = p.x;
            this.y = p.y;
            this.sym = p.sym;
        }

        public void Move(int offset, Direction direction)
        {
            if (direction == Direction.RIGHT)
            {
                this.x = x + offset;
            }
            else if (direction == Direction.LEFT) {
                this.x = x - offset;
            }
            else if (direction == Direction.UP) {
                this.y = y - offset;
            }
            else if (direction == Direction.DOWN) {
                this.y = y + offset;
            }
        }
        
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }

        public override string ToString()
        {
            return x + ", " + y + ", " + sym;
        }
    }
}