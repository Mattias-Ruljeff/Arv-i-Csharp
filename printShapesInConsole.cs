using System;
using System.Collections.Generic;
using System.Linq;
using ConsoleTables;

namespace examination_2
{
    /// <summary>
    /// The class that checks what kind of shapes the user
    /// wants to create and print out in the console.
    /// </summary>
    static class PrintShapesInConsole
    {
        /// <summary>
        /// The number of shapes that will be created in the Shapes-list.
        /// </summary>
        static private int numberOfShapes;

        /// <summary>
        /// A string that the user chooses, to format the print of the shape-list.
        /// </summary>
        static private String formatting;

        /// <summary>
        /// True if the user chooses to print out 3D-shapes.
        /// </summary>
        static private bool is3D;

        /// <summary>
        /// The user chooses between 2D and 3D shapes.
        /// </summary>
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
        /// <summary>
        ///  The user chooses the kind of print-formatting the list of
        ///  shapes will have when printing in the console.
        /// </summary>
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
                    throw new ArgumentException("Skriv antingen \"G\" eller \"R\"");
            }
            createShapesList();
        }

        /// <summary>
        /// Creates a list of shapes (between 3 and 29 random shapes) depending on the choices of the user.
        /// </summary>
        static public void createShapesList(){
            Random random = new Random();

            List<Shape2D> shape2dList = new List<Shape2D>();
            List<Shape3D> shape3dList = new List<Shape3D>();
            
            numberOfShapes = random.Next(3,30);

            if (is3D) {

                // Creates a list of 3D-shapes. 
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

                // Creates a list of 2D-shapes.
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

        /// <summary>
        /// Orders the list of shapes by "Type" and "Volume" and prints it to the console
        /// in the chosen formatting.
        /// </summary>
        /// <param name="shapeList"></param> A list of 3D-shapes.
        static public void print3DListToConsole (List<Shape3D> shapeList) 
        {
            List<Shape3D> orderedList = shapeList.OrderBy(x => x.ShapeType)
                .ThenBy(x => x.Volume)
                .ToList();
            
            // Print list in console, in minimal format.
            if ( formatting == "R") {
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

        /// <summary>
        /// Orders the list of shapes by "Type" and "Area" and prints it to the console
        /// in the chosen formatting.
        /// </summary>
        /// <param name="shapeList"></param>
        static public void print2DListToConsole (List<Shape2D> shapeList) 
        {
            List<Shape2D> orderedList = shapeList.OrderByDescending(x => x.ShapeType)
                .ThenBy(x => x.Area)
                .ToList();
            
            // Print list in console, in minimal format. 
            if ( formatting == "R") {
                foreach (var shape in orderedList)
                {
                    Console.WriteLine(shape.ToString("R"));
                }
            } else {

                // Print list in console, in table format 
                var table = new ConsoleTable("Figur", "Längd", "Bredd", "Omkrets", "Area");
                foreach (var shape in orderedList)
                {
                    table.AddRow($"{shape.ShapeType}", $"{shape.Length}", $"{shape.Width}", $"{shape.Perimeter:n}", $"{shape.Area:n}"); 
                }
                table.Write();
            }
        }

    }
}