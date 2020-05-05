using System;

namespace examination_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape rectangle = new Rectangle(ShapeType.Rectangle, 10.0, 10.0);
            Shape ellipse = new Ellipse(ShapeType.Ellipse, 10.0, 10.0, 10.0);
            rectangle.ToString();
            ellipse.ToString();

        }
    }
}
