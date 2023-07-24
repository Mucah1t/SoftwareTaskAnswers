using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareExamAnswers
{
    public class Point //We created new simple class called "Point" and this class contains two properties to represent X and Y coordinates.
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y) //It is a constructor method called "Point". It provides a constructor method to set X and Y values when the object of the class is created. When the method called x and y variiables will be created.
        {
            X = x;
            Y = y;
        }
    }
}
