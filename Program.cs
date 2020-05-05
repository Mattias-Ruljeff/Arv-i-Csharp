using System;

namespace examination_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(ShapeType.Rectangle, 10.0, 10.0);
            Console.WriteLine(rectangle);
        }
    }
}
