using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareExamAnswers
{
    public class Line
    {
        // We need y-inter and slope becuase after we get the equation of the line (y=mx+n) we may evaluate the condition of the line.
        public double Slope { get; set; }
        public double YIntercept { get; set; }
        public Line(Point p1, Point p2) //It is the constructor of Line class and when an object of this class is created, this constructor will be called. The constructor takes two parameters from  Point class: p1 and p2. These two parameters represent the two points where the line passes.
        {
            // Calculating the slope of the line. y=mx+n is the general equation of sstraight line. m represents the slope.
            Slope = (double)(p2.Y - p1.Y) / (p2.X - p1.X); // m=(y2-y1)/(x2-x1)

            // Calculating the y-intercept. //n = y1-m*x1
            YIntercept = p1.Y - Slope * p1.X;
            
        }

        public bool IsParallelToY() // If true is returned here which means that the line is parallel to y-axis because if a line is parallel to the y-axis, its slope is infinite. 
        {
            return double.IsInfinity(Slope);
        }

        public bool IsParallelToX() // if slope returned as 0 which menas that the line is parallel to the x-axis, its because the slope is zero.
        {
            return Slope == 0;
        }
    }
}
