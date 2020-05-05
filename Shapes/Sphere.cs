using System;

namespace examination_2
{
    class Sphere : Shape3D
    {
        public double Diameter {
            get {return ((_baseShape.Length/2) * (_baseShape.Length/2) * Math.PI );}
            set {;}
        }
        public Sphere(ShapeType shapeType, Shape2D _baseShape, double height, double diameter)
        :base(shapeType, _baseShape, height)
        {

        }
    }
}