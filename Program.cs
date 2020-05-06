using System;

namespace examination_2
{
    class Program
    {
        static String shapeType = "";
        static bool is3d;

        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu () {
            Console.WriteLine("Create a list of Shapes");
            Console.WriteLine("Choose shape");
            Console.WriteLine("Enter \"2d\" for Shape 2D");
            Console.WriteLine("Enter \"3d\" for Shape 3D");
            shapeType = Console.ReadLine();

            switch (shapeType) 
            {
                case "2d":
                    is3d =  false;
                    PrintShapesInConsole.createShapes(is3d);
                    break;
                case "3d":
                    is3d = true;
                    PrintShapesInConsole.createShapes(is3d);
                    break;
                default :
                    throw new ArgumentException("Enter either \"2d\" or \"3d\"");
            }

        }
    }
}
