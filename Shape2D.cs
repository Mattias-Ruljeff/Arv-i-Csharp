using System;
using System.Collections.Generic;

namespace examination_2 
{
    abstract class Shape2D : Shape
    {
        private double _length = 0;
        private double _width = 0;

        public abstract double Area { get; }
        public double Length 
        {
            get { return _length; }
            set { 
                if (value > 0){
                    _length = value; 
                } else {
                    throw new ArgumentOutOfRangeException("Insert a number larger than 0");
                }
            }
        }
        public abstract double Perimeter {get;}
        public double Width 
        { 
            get{ return _width;}
            set {
                if (value > 0) {
                    _width = value; 
                } else {
                    throw new ArgumentOutOfRangeException("Insert a number larger than 0");
                }
             }
        }


        protected Shape2D(ShapeType shapeType, double length, double width) 
        : base(shapeType)
        {
            Length = length;
            Width = width;
        }

        public override string ToString() => ToString("G");

        public override string ToString(string format)
        {
            switch (format)
            {
                case null:
                case "":
                case "G":
                    return $"Figur: {ShapeType}\nLängd: {Length}\nBredd: {Width}\nOmkrets: {Perimeter}\nArea: {Area}\n";
                case "R":
                    return $"{ShapeType} {Length}    {Width}    {Perimeter:n1}   {Area:n1}";
                default:
                    throw new FormatException();
            }
        }

    }


}