using System;

namespace examination_2 
{
    abstract class Shape3D : Shape
    {
        protected Shape2D _baseShape;
        private double _height;

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
        public double Length {get; set;}
        public virtual double MantelArea {
            get { return _baseShape.Perimeter * Height;}
        }
        public virtual double TotalSurfaceArea {
            get{ return MantelArea + 2 * _baseShape.Area; }
        
        }
        public double Width {get; set;}
        public virtual double Volume {
            get{return _baseShape.Area * Height;}
        }

        protected Shape3D(ShapeType shapeType, Shape2D baseShape, double height) 
        : base(shapeType)
        {
            _baseShape = baseShape;
            Height = height;
        }


        //Fixa-----------------------
        public override string ToString() => ToString("G");

        public override string ToString(string format)
        {
            switch (format)
            {
                case null:
                case "":
                case "G":
                    return $"Figur: {ShapeType}\nLängd: {_baseShape.Length}\nBredd: {_baseShape.Width}\nHöjd: {Height}\nMantelarea: {MantelArea}\nBegränsningsarea: {TotalSurfaceArea}\nVolym: {Volume}\n";
                case "R":
                    return $"{ShapeType}{_baseShape.Length, 10}{_baseShape.Width, 10}{Height, 10}{MantelArea, 20:n1}{TotalSurfaceArea, 20:n1}{Volume:, 20:n1}";
                default:
                    throw new FormatException();
            }
        }

    }


}