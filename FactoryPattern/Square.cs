using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    
    class Square : Shape
    {
        private int side;

        public void calculateArea()
        {
            Console.WriteLine("Enter an integer for the square's side: ");
            side = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The square'side is: " + side);
            Console.WriteLine("The area of a square is a*a : " + side*side);
        }
    }
}
