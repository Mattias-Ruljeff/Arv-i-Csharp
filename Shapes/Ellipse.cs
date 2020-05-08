using System;

namespace examination_2
{
    /// <summary>
    /// A Ellipse shape that inherit "Shape2D".
    /// </summary>
    class Ellipse : Shape2D
    {

        /// <summary>
        /// Calculates the Area of the Ellipse.
        /// </summary>
        /// <value></value>
        public override double Area {
            get { 
                double a = Length/2;
                double b = Width/2;
                return Math.PI * a * b;
                ;}
        }
        /// <summary>
        /// Calculates the Perimeter of the Ellipse.
        /// </summary>
        /// <value></value>
        public override double Perimeter {
            get{
                double a = Length/2;
                double b = Width/2;
                double aPow = Math.Pow((a + a), 2);
                double bPow = Math.Pow((b + b), 2);
                return Math.PI * Math.Sqrt(aPow + bPow);
            ;}
        }

        /// <summary>
        /// The constructor for the Ellipse.
        /// </summary>
        /// <param name="length"></param> The length of the Ellipse.
        /// <param name="width"></param> The width of the Ellipse.
        public Ellipse(double length, double width) 
        : base(ShapeType.Ellipse, length, width)
        {
            Length = length;
            Width = width;
            
        }

        /// <summary>
        /// The constructor for the Ellipse with additional parameters, "hdiameter" and "vdiameter".
        /// </summary>
        /// <param name="length"></param> The length of the Ellipse.
        /// <param name="width"></param> The width of the Ellipse.
        /// <param name="hdiameter"></param> The hdiameter of the Ellipse.
        /// <param name="vdiameter"></param> The vdiameter of the Ellipse.
        public Ellipse(double length, double width, double hdiameter, double vdiameter) 
        : base(ShapeType.Ellipse, length, width)
        {
            
        }
    }
    
}