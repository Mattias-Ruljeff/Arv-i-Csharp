using System;

namespace examination_2
{
    class Cuboid : Shape3D
    {
        public Cuboid(ShapeType shapeType, Shape2D _baseShape, double length, double width, double height)
        :base(shapeType, _baseShape, height)
        {
            Height = height;
        }
    }
}