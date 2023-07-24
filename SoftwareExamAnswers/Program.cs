using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareExamAnswers
{ 
   //First of all, we should create a list containing our points, however before that we must also teach to the software which of our points is x and which are y. After that, in order to evaluate the condition of two points with respect to the axes, we must create the lines with related points. In this regard, I created 2 public classes Point and Line.
    public class Program
    {
        public static void Main()
        {
            List<Point> points = new List<Point>  // We create a new list from our Point class.
        {
            new Point(1, 2),
            new Point(3, 7),
            new Point(0, 6),
            new Point(1, 1),
            new Point(-5, 2),
            new Point(1, 5),
            new Point(3, -5)
            // ...
        };

            List<Line> lines = new List<Line>(); // We create a new list from our Line class.

            
            for (int i = 0; i < points.Count; i++) // Here each point is putted into the for loop. 
            {
                for (int j = i + 1; j < points.Count; j++) // The related point entering the first for loop is combined with every points in the points list one by one to created the line.
                {
                    lines.Add(new Line(points[i], points[j]));
                }
            }

            //defining counters for the answers
            int parallelToYAxisCount = 0; 
            int parallelToXAxisCount = 0;

         
            foreach (var line in lines) //calling our methods from Line class
            {
                if (line.IsParallelToY())
                    parallelToYAxisCount++;

                if (line.IsParallelToX())
                    parallelToXAxisCount++;
            }

            Console.WriteLine("Number of lines parallel to the y-axis: " + parallelToYAxisCount);
            Console.WriteLine("Number of lines parallel to the x-axis: " + parallelToXAxisCount);
            Console.ReadKey();
        }
    }

}



    