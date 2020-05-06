using System;

namespace examination_2
{
    class Program
    {
        static String shapeType = "";
        static int numberOfShapes;

        static void Main(string[] args)
        {

            Menu();


        }

            static void Menu () {
            Console.WriteLine("Create a list of Shapes");
            Console.WriteLine("Choose shape");
            Console.WriteLine("\t2d - Shape 2D");
            Console.WriteLine("\t3d - Shape 3D");
            shapeType = Console.ReadLine();

            Console.WriteLine("How many shapes?");
            numberOfShapes = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{shapeType} {numberOfShapes}");

            switch (shapeType) 
            {
                case "2d":
                    Console.WriteLine("");
                    break;
                
                case "3d":
                    Console.WriteLine("");
                    break;
                default :
                    throw new ArgumentException("Enter either \"2d\" or \"3d\"");
            }

            }
    }
}
