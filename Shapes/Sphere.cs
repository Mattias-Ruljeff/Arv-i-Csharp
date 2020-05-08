using System;

namespace examination_2
{
    class Sphere : Shape3D
    {
        public double Diameter {
            get { return Length ;}
            set { Length = value; Width = value;}
        }

        public override double MantelArea 
        {
            get { return _baseShape.Area * 4; }
        }
        public override double TotalSurfaceArea {
            get { return MantelArea;}
        }
        public override double Volume {
            get {return ( 4 / 3 ) * _baseShape.Area * ( Length / 2 );}
        }
        public Sphere(double diameter)
        :base(ShapeType.Sphere, new Ellipse(diameter, diameter), diameter)
        {
            Diameter = diameter;
        }
    }
}