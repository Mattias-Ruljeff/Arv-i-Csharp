using System;

namespace examination_2
{
    /// <summary>
    /// The basic class of all shapes.
    /// </summary>
    abstract class Shape
    {
        /// <summary>
        /// Checks if the shape is a 2D or 3D shape.
        /// </summary>
        /// <value></value>
        public bool is3d 
        {
            get {
               return ShapeType > ShapeType.Ellipse;
            }
        }

        /// <summary>
        /// The type of shape.
        /// </summary>
        /// <value></value>
        public ShapeType ShapeType {get; private set;}

        /// <summary>
        /// Constructor for the Shape.
        /// </summary>
        /// <param name="shapeType"></param>
        protected Shape(ShapeType shapeType)
        {
            ShapeType = shapeType;
        }

        /// <summary>
        /// Overrides the ToString-method fron the Object-class.
        /// </summary>
        /// <param name="format"></param> The format for the print in the console-window.
        /// <returns></returns>
        public abstract string ToString(string format);
    }
}