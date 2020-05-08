using System;
using System.Collections.Generic;

namespace examination_2 
{
    /// <summary>
    /// The class that 2D shapes inherit from.static The 2D class inherit from Shape.
    /// </summary>
    abstract class Shape2D : Shape
    {
        /// <summary>
        /// The length value of the shape.
        /// </summary>
        private double _length = 0;

        /// <summary>
        /// The width value of the shape.
        /// </summary>
        private double _width = 0;

        /// <summary>
        /// The abstract Area calculation.
        /// </summary>
        /// <value></value>
        public abstract double Area { get; }

        /// <summary>
        /// Sets the "_length" value, if the value is greater than 0, else throws an error.
        /// </summary>
        /// <value></value>
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

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        public abstract double Perimeter {get;}

        /// <summary>
        /// Sets the "_width" value, if the value is greater than 0, else throws an error.
        /// </summary>
        /// <value></value>
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

        /// <summary>
        /// The constructor for Shape2D.
        /// </summary>
        /// <param name="shapeType"></param> She type of shape for the 2D-shape.
        /// <param name="length"></param> The length of the shape.
        /// <param name="width"></param> The width of the shape.
        protected Shape2D(ShapeType shapeType, double length, double width) 
        : base(shapeType)
        {
            Length = length;
            Width = width;
        }

        /// <summary>
        /// The Standard printing format if no formatting argument is given.
        /// </summary>
        /// <returns></returns>
        public override string ToString() => ToString("G");

        /// <summary>
        /// Print returns the given string formatting for the print to the console.
        /// If the wrong argument is given, an error is thrown.
        /// </summary>
        /// <param name="format"></param> A string that formats the print of the shape.
        /// <returns></returns>
        public override string ToString(string format)
        {
            switch (format)
            {
                case null:
                case "":
                case "G":
                    return $"Figur: {ShapeType}\nLängd: {Length}\nBredd: {Width}\nOmkrets: {Perimeter:n1}\nArea: {Area:n1}\n";
                case "R":
                    return $"{ShapeType}  {Length}  {Width}  {Perimeter:n1}  {Area:n1}";
                default:
                    throw new FormatException();
            }
        }

    }


}