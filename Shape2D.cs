using System;

namespace examination_2 
{
    abstract class Shape2D : Shape
    {
        private double _length;
        private double _width;

        public abstract double Area { get; }
        public double Length 
        {
            get { return _length; }
            set { 
                value = _length;
                // if (value > 0){
                //     value = _length; 
                // } else {
                //     throw new ArgumentOutOfRangeException("Insert a number larger than 0");
                // }
            }
        }
        public abstract double Perimeter {get;}
        public double Width 
        { 
            get{ return _width;}
            set {
                if (value > 0) {
                    value = _width; 
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


        //Fixa-----------------------
        public override string ToString()
        {
            Console.WriteLine(Width);
            Console.WriteLine(Length);
            Console.WriteLine(Area);
            Console.WriteLine(Perimeter);

            return "Rectangel";
        }

        public override string ToString(string format)
        {
            System.Console.WriteLine(format);
            return format;
        }

    }


}