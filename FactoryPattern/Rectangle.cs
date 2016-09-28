using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Rectangle : Shape
    {
        private int aSide;
        private int bSide;

        public void calculateArea()
        {
            Console.WriteLine("Enter an integer for the rectangles 'a' side: ");
            aSide = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The rectangle's 'a' side is: " + aSide);

            Console.WriteLine("Enter an integer for the rectangles 'b' side: ");
            bSide = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The rectangle's 'b' side is: " + bSide);
           
            Console.WriteLine("Area of rectangle is a*b: "+ aSide*bSide);
        }
    }
}
