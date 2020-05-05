using System;

namespace examination_2
{
    abstract class Shape
    {
        public bool is3d {get;}
        public ShapeType Shapetype {get; private set;}


        protected Shape(ShapeType shapeType)
        {
            shapeType = Shapetype;
        }

        public abstract string ToString(string format);
        
    }


}