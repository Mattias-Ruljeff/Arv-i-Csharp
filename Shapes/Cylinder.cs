using System;

namespace examination_2
{
    class Cylinder : Shape3D
    {
        public Cylinder(double hdiameter, double vdiameter, double height)
        :base(ShapeType.Cylinder, new Ellipse(hdiameter, vdiameter), height)
        {
            Length = hdiameter;
            Width = vdiameter;
        }
    }
}