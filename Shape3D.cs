using System;

namespace examination_2 
{
    abstract class Shape3D : Shape
    {
        protected Shape2D _baseShape;
        private double _height = 0;

        public double Height 
        {
            get { return _height; } 
            set { 
                if (value > 0){
                    _height = value;
                } else {
                    throw new ArgumentOutOfRangeException("Insert a number larger than 0");
                }
            }
        }
        public double Lenght 
        { 
            get { return _baseShape.Length; } 
            set { 
                if (value > 0){
                    _baseShape.Length = value; 
                } else {
                    throw new ArgumentOutOfRangeException("Insert a number larger than 0");
                }
            }
         }
        public double MantelArea {get;}
        public double TotalSurfaceArea {get;}
        public double Width 
        { 
            get { return _baseShape.Width; } 
            set { 
                if (value > 0){
                    _baseShape.Width = value; 
                } else {
                    throw new ArgumentOutOfRangeException("Insert a number larger than 0");
                }
            }
        }
        public double Volume {get;}

        protected Shape3D(ShapeType shapeType, Shape2D _baseShape, double height) 
        : base(shapeType)
        {
            Height = height;
        }


        //Fixa-----------------------
        public override string ToString()
        {
            return "hej";
        }

        public override string ToString(string format)
        {
            return format;
        }

    }


}