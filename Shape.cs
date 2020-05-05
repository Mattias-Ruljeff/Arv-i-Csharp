using System;

namespace examination_2
{
    abstract class Shape
    {
        public bool is3d {get;}
        public ShapeType Shapetype {get; private set;}

        protected Shape(ShapeType shapeType)
        {
            Shapetype = shapeType;
        }

        public abstract string ToString(string format);
        
    }


}