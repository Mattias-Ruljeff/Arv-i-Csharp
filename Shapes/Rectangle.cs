using System;

namespace examination_2
{
    /// <summary>
    /// A Rectangle shape that inherit "Shape2D".
    /// </summary>
    class Rectangle : Shape2D
    {
        /// <summary>
        /// Calculates the Area of the Rectangle.
        /// </summary>
        /// <value></value>
        public override double Area {
            get{ return Length * Width ;}
            }

        /// <summary>
        /// Calculates the Perimeter of the Rectangle.
        /// </summary>
        /// <value></value>
        public override double Perimeter {
            get{ return ( Length * 2 ) + ( Width * 2 );}
        }

        /// <summary>
        /// The constructor for the Rectangle.
        /// </summary>
        /// <param name="length"></param>
        /// <param name="width"></param>
        public Rectangle(double length, double width)
        : base(ShapeType.Rectangle, length, width)
        {
        }

    }
}