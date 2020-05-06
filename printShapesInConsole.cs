using System;
using System.Collections.Generic;

namespace examination_2
{
    class PrintShapesInConsole
    {
        static int numberOfShapes;

        public PrintShapesInConsole(){
        }

        static public void printer(bool is3D){
            List<String> shapeList = new List<String>();
            List<String> shape2dList = new List<String>();
            List<String> shape3dList = new List<String>();
            
            Console.WriteLine("How many shapes?");
            numberOfShapes = Convert.ToInt32(Console.ReadLine());
            if (is3D) {

            } else {

            }

        }
    }
    
}