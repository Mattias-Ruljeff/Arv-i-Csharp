using System;
using System.Collections.Generic;
using System.Linq;
using ConsoleTables;

namespace examination_2
{
    class PrintShapesInConsole
    {
        static int numberOfShapes;
        static int tableWidth = 10;

        public PrintShapesInConsole(){
        }

        static public List<String> createShapesList(bool is3D){
            List<String> shapeList = new List<String>();
            List<Shape2D> shape2dList = new List<Shape2D>();
            List<Shape3D> shape3dList = new List<Shape3D>();
            Random random = new Random();
            // Shape[] shapes2d = {Rectangle, Ellipse};
            
            Console.WriteLine("How many shapes?");
            numberOfShapes = Convert.ToInt32(Console.ReadLine());
            if (is3D) {
                for (int i = 0; i < numberOfShapes; i++)
                {
                shapeList.Add(new Cuboid(random.Next(1,100), random.Next(1,100), random.Next(1,100)).ToString());
                }
                printListToConsole(shapeList);
            } else {
                for (int i = 0; i < numberOfShapes; i++)
                {
                shapeList.Add(new Rectangle(random.Next(1,100), random.Next(1,100)).ToString());
                }
                printListToConsole(shapeList);
            }
            return shapeList;


        }
        static public void printListToConsole (List<String> shapeList) 
        {
            var table = new ConsoleTable("one", "two", "three");
            table.AddRow(1, 2, 3)
                .AddRow("this line should be longer", "yes it is", "oh");

            table.Write();
            Console.WriteLine();

            var rows = Enumerable.Repeat(shapeList, 10);

            ConsoleTable
                .From<List<String>>(rows)
                .Configure(o => o.NumberAlignment = Alignment.Right)
                .Write(Format.Alternative);

            Console.ReadKey();

            foreach (var item in shapeList)
            {
                Console.WriteLine(item);
            }
        }


    }
}