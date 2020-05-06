using System;

namespace examination_2
{
    class Ellipse : Shape2D
    {

        public override double Area {
            get { 
                double a = Length/2;
                double b = Width/2;
                return Math.PI * a * b;
                ;}
        }
        public override double Perimeter {
            get{
                double a = Length/2;
                double b = Width/2;
                double aPow = Math.Pow((a + a), 2);
                double bPow = Math.Pow((b + b), 2);
                return Math.PI * Math.Sqrt(aPow + bPow);
            ;}
        }

        public Ellipse(double length, double width) 
        : base(ShapeType.Ellipse, length, width)
        {
            Length = length;
            Width = width;
            
        }
        public Ellipse(ShapeType shapeType, double length, double width, double hdiameter, double vdiameter) 
        : base(shapeType, length, width)
        {
            
        }
    }
    
}