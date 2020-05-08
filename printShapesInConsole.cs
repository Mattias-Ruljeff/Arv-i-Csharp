using System;
using System.Collections.Generic;
using System.Linq;
using ConsoleTables;

namespace examination_2
{
    static class PrintShapesInConsole
    {
        static private int numberOfShapes;
        static private String formatting;
        static private bool is3D;
        static public void chooseShape() {
            Console.WriteLine("Create a list of Shapes");
            Console.WriteLine("Choose shape");
            Console.WriteLine("Enter \"2d\" for Shape 2D");
            Console.WriteLine("Enter \"3d\" for Shape 3D");

            switch (Console.ReadLine())
            {
                case "2d":
                case "2D":
                    is3D =  false;
                    choosePrintFormatting();
                    break;
                case "3d":
                case "3D":
                    is3D = true;
                    choosePrintFormatting();
                    break;
                default :
                    throw new ArgumentException("Enter either \"2d\" or \"3d\"");
            }

        }
        static public void choosePrintFormatting() {
            Console.WriteLine("Witch formatting of the print?");
            Console.WriteLine("R = Minimal output");
            Console.WriteLine("G = Table output");

            switch (Console.ReadLine())
            {
                case "G":
                case "g":
                formatting = "G";
                createShapesList();
                break;

                case "R":
                case "r":
                formatting = "R";
                createShapesList();
                break;

                default:
                    throw new ArgumentException("Enter either \"G\" or \"R\"");
            }
        }

        static public void createShapesList(){
            Random random = new Random();

            List<Shape2D> shape2dList = new List<Shape2D>();
            List<Shape3D> shape3dList = new List<Shape3D>();
            
            numberOfShapes = random.Next(1,20);

            if (is3D) {
                for (int i = 0; i < numberOfShapes; i++)
                {
                List<Shape3D> shapesListFor3D = new List<Shape3D>()
                {
                    new Cuboid(random.Next(1,100), random.Next(1,100), random.Next(1,100)), new Cylinder(random.Next(1,100), random.Next(1,100), random.Next(1,100)),
                    new Sphere(random.Next(1,100))
                };
                shape3dList.Add(shapesListFor3D[random.Next(0,3)]);
                }
                print3DListToConsole(shape3dList);
            } else {
                for (int i = 0; i < numberOfShapes; i++)
                {
                List<Shape2D> shapesListFor2D = new List<Shape2D>()
                { 
                    new Rectangle(random.Next(1,100), random.Next(1,100)), new Ellipse(random.Next(1,100), random.Next(1,100))
                };
                shape2dList.Add(shapesListFor2D[random.Next(0,2)]);
                }
                print2DListToConsole(shape2dList);
            }

        }

        static public void print3DListToConsole (List<Shape3D> shapeList) 
        {
            var orderedList = shapeList.OrderBy(x => x.ShapeType)
                .ThenBy(x => x.Volume)
                .ToList();
            if ( formatting == "R") {
                foreach (var item in orderedList)
                {
                item.ToString("R");
                }
            } else {
            var table = new ConsoleTable("Figur", "Längd", "Bredd", "Höjd", "Mantelarea", "Begräns.area", "Volym");
            foreach (var item in orderedList)
            {
            Console.ResetColor();
            table.AddRow($"{item.ShapeType}", $"{item.Length}", $"{item.Width}", $"{item.Height}", $"{item.MantelArea:n1}", $"{item.TotalSurfaceArea:n1}", $"{item.Volume:n1}"); 
            }

            table.Write();
            }
        }

        static public void print2DListToConsole (List<Shape2D> shapeList) 
        {
            var orderedList = shapeList.OrderBy(x => x.ShapeType)
                .ThenBy(x => x.Area)
                .ToList();
            if ( formatting == "R") {
                foreach (var item in orderedList)
                {
                item.ToString("R");
                }
            } else {
            shapeList.OrderBy(x => x.ShapeType)
                .ThenBy(x => x.Area)
                .ToList();
            var table = new ConsoleTable("Figur", "Längd", "Bredd", "Area");
            foreach (var item in shapeList)
            {
            table.AddRow($"{item.ShapeType}", $"{item.Length}", $"{item.Width}", $"{item.Area}"); 
            }

            table.Write();
            }
        }

    }
}