using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._Point_in_Rectangle
{
    class Rectangle
    {
        
        public Rectangle(Point topLeft, Point bottomRight)
        {
            this.TopLeftCoordinates = topLeft;
            this.BottomRightCoordinates = bottomRight;
        }
       public Point TopLeftCoordinates { get; set; }
       public Point BottomRightCoordinates { get; set; }

        public bool Contains(Point point)
        {
            bool isInX = point.X >= TopLeftCoordinates.X &&
                point.X <= BottomRightCoordinates.X;

            bool isInY = point.Y <= TopLeftCoordinates.Y &&
                point.Y >= BottomRightCoordinates.Y;
            return isInX && isInY;
        }

    }
}
