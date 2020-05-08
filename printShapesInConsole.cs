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
            Console.WriteLine("Enter \"2D\" for Shape 2D");
            Console.WriteLine("Enter \"3D\" for Shape 3D");

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
                    throw new ArgumentException("Skriv antingen \"2D\" eller \"3D\"");
            }

        }
        static public void choosePrintFormatting() {
            Console.WriteLine("Välj utskriftsformatering?");
            Console.WriteLine("R = Minimal utskrift");
            Console.WriteLine("G = Tabell-utskrift");

            switch (Console.ReadLine())
            {
                case "G":
                case "g":
                    formatting = "G";
                    break;
                case "R":
                case "r":
                    formatting = "R";
                    break;
                default:
                    throw new ArgumentException("SKriv antingen \"G\" eller \"R\"");
            }
            createShapesList();
        }

        static public void createShapesList(){
            Random random = new Random();

            List<Shape2D> shape2dList = new List<Shape2D>();
            List<Shape3D> shape3dList = new List<Shape3D>();
            
            numberOfShapes = random.Next(3,30);

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
            
            // Print list in console, in minimal format.
            if ( formatting == "R") {
                Console.WriteLine("Figur Längd Bredd Höjd Mantelarea Begräns.area Volym");
                foreach (var shape in orderedList)
                {
                    Console.WriteLine(shape.ToString("R"));
                }
            } else {

                // Print list in console, in table format 
                var table = new ConsoleTable("Figur", "Längd", "Bredd", "Höjd", "Mantelarea", "Begräns.area", "Volym");
                foreach (var shape in orderedList)
                {
                    table.AddRow($"{shape.ShapeType}", $"{shape.Length}", $"{shape.Width}", $"{shape.Height}", $"{shape.MantelArea:n1}", $"{shape.TotalSurfaceArea:n1}", $"{shape.Volume:n1}"); 
                }
                table.Write();
            }
        }

        static public void print2DListToConsole (List<Shape2D> shapeList) 
        {
            var orderedList = shapeList.OrderByDescending(x => x.ShapeType)
                .ThenBy(x => x.Area)
                .ToList();
            
            // Print list in console, in minimal format. 
            if ( formatting == "R") {
                Console.WriteLine("Figur Längd Bredd Omkrets Area");
                foreach (var shape in orderedList)
                {
                    Console.WriteLine(shape.ToString("R"));
                }
            } else {

                // Print list in console, in table format 
                var table = new ConsoleTable("Figur", "Längd", "Bredd", "Omkrets", "Area");
                foreach (var shape in orderedList)
                {
                    table.AddRow($"{shape.ShapeType}", $"{shape.Length}", $"{shape.Width}", $"{shape.Perimeter}", $"{shape.Area}"); 
                }
                table.Write();
            }
        }

    }
}