using System;

namespace examination_2
{
    class Rectangle : Shape2D
    {
        public override double Area {get;}
        public override double Perimeter {get;}

        public Rectangle(ShapeType shapeType, double length, double width)
        :base(shapeType, length, width)
        {

        }

    }
}