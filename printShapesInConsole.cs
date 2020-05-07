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
            Random random = new Random();
            List<String> shapeList = new List<String>();
            List<Shape2D> shape2dList = new List<Shape2D>(){ new Ellipse(random.Next(1,100), random.Next(1,100)), new Rectangle(random.Next(1,100), random.Next(1,100))};
            List<Shape3D> shape3dList = new List<Shape3D>() { new Cuboid(random.Next(1,100), random.Next(1,100), random.Next(1,100)), new Cylinder(random.Next(1,100), random.Next(1,100), random.Next(1,100)), new Sphere(random.Next(1,100)) };
            
            Console.WriteLine("How many shapes?");
            numberOfShapes = Convert.ToInt32(Console.ReadLine());
            if (is3D) {
                for (int i = 0; i < numberOfShapes; i++)
                {
                shapeList.Add(shape3dList[random.Next(0,2)].ToString());
                }
                printListToConsole(shapeList);
            } else {
                for (int i = 0; i < numberOfShapes; i++)
                {
                shapeList.Add(shape2dList[random.Next(0,2)].ToString());
                }
                printListToConsole(shapeList);
            }
            return shapeList;


        }
        static public void printListToConsole (List<String> shapeList) 
        {

            foreach (var item in shapeList)
            {
                Console.WriteLine(item);
            }
        }


    }
}