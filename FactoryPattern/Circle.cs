using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Circle : Shape
    {
        private int radius;
                                      
        public void calculateArea()
        {
            Console.WriteLine("Enter an integer for the circle's radius: ");
            radius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The circle's radius is: " + radius);
            Console.WriteLine("Area of circle is r*r*PI: " + radius*radius* Math.PI);

        }
    }
}
