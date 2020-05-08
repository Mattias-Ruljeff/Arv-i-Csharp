using System;

namespace examination_2
{
    /// <summary>
    /// A cuboid shape that inherit "Shape3D".
    /// </summary>
    class Cuboid : Shape3D
    {
        /// <summary>
        /// The constructor for the Cuboid.
        /// </summary>
        /// <param name="length"></param> The length of the cuboid.
        /// <param name="width"></param> The width of the cuboid.
        /// <param name="height"></param> The height of the cuboid.
        public Cuboid(double length, double width, double height)
        :base(ShapeType.Cuboid, new Rectangle(length, width), height)
        {
            Length = length;
            Width = width;
            Height = height;
        }
    }
}