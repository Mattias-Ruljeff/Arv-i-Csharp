using System;

namespace examination_2
{
    abstract class Shape
    {
        public bool is3d 
        {
            get {
               return ShapeType > ShapeType.Ellipse;
            }
        }
        public ShapeType ShapeType {get; private set;}

        protected Shape(ShapeType shapeType)
        {
            ShapeType = shapeType;
        }

        public abstract string ToString(string format);
        
    }


}