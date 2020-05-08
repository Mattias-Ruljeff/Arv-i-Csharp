using System;

namespace examination_2
{
    /// <summary>
    /// A Sphere shape that inherit "Shape2D"
    /// </summary>
    class Sphere : Shape3D
    {
        /// <summary>
        /// Calculates the Diameter of the Sphere.
        /// </summary>
        /// <value></value>
        public double Diameter {
            get { return Length ;}
            set { Length = value; Width = value;}
        }
        
        /// <summary>
        /// Calculates the Mantelarea of the Sphere.
        /// </summary>
        /// <value></value>
        public override double MantelArea 
        {
            get { return _baseShape.Area * 4; }
        }

        /// <summary>
        /// Calculates the Total sorface area of the Sphere.
        /// </summary>
        /// <value></value>
        public override double TotalSurfaceArea {
            get { return MantelArea;}
        }

        /// <summary>
        /// Calculates the Volume of the Sphere.
        /// </summary>
        /// <value></value>
        public override double Volume {
            get {return ( 4 / 3 ) * _baseShape.Area * ( Length / 2 );}
        }

        /// <summary>
        /// The constructor for the Shpere.
        /// </summary>
        /// <param name="diameter"></param> The Diameter of the Sphere
        public Sphere(double diameter)
        :base(ShapeType.Sphere, new Ellipse(diameter, diameter), diameter)
        {
            Diameter = diameter;
        }
    }
}