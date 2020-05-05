using System;

namespace examination_2
{
    class Rectangle : Shape2D
    {
        protected Shape2D _base2D;
        public override double Area {
            get{ return Length * Width ;}
            }
        public override double Perimeter {
            get{ return ( Length * 2 ) + ( Width * 2 );}
        }

        public Rectangle(ShapeType shapeType, double length, double width)
        : base(shapeType, length, width)
        {
            Length = length;
            Width = width;
        }

    }
}