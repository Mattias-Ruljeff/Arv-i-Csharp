using System;

namespace examination_2
{
    class Cylinder : Shape3D
    {
        public Cylinder(ShapeType shapeType, Shape2D _baseShape, double height, double hdiameter, double vdiameter)
        :base(shapeType, _baseShape, height)
        {

        }
    }
}