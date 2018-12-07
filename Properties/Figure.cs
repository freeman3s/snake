using System;
using System.Collections.Generic;

namespace snake.Properties
{
    public class Figure
    {
        protected List<Point> pList;
        
        public void Draw()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }
    }
}