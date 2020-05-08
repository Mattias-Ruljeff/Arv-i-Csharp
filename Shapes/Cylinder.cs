using System;

namespace examination_2
{
    /// <summary>
    /// A cylinder shape that inherit "Shape3D".
    /// </summary>
    class Cylinder : Shape3D
    {
        /// <summary>
        /// The constructor for the Cylinder.
        /// </summary>
        /// <param name="hdiameter"></param> The hdiameter of the cylinder.
        /// <param name="vdiameter"></param> The vdiameter of the cylinder.
        /// <param name="height"></param> The height of the cylinder.
        public Cylinder(double hdiameter, double vdiameter, double height)
        :base(ShapeType.Cylinder, new Ellipse(hdiameter, vdiameter), height)
        {
            Length = hdiameter;
            Width = vdiameter;
        }
    }
}