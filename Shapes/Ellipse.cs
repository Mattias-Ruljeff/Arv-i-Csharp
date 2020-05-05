

namespace examination_2
{
    class Ellipse : Shape2D
    {

        public override double Area {get;}
        public override double Perimeter {get;}

        public Ellipse(ShapeType shapeType, double length, double width, double diameter) 
        : base(shapeType, length, width)
        {
            
        }
        public Ellipse(ShapeType shapeType, double length, double width, double hdiameter, double vdiameter) 
        : base(shapeType, length, width)
        {
            
        }
    }
    
}