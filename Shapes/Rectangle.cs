using System;

namespace examination_2
{
    class Rectangle : Shape2D
    {
        public override double Area {
            get{ return Length * Width ;}
            }
        public override double Perimeter {
            get{ return ( Length * 2 ) + ( Width * 2 );}
        }

        public Rectangle(double length, double width)
        : base(ShapeType.Rectangle, length, width)
        {
            Length = length;
            Width = width;
        }

    }
}