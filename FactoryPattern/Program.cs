using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeFactory sf = new ShapeFactory();

            Shape c = sf.getShape("circle");
            Shape r = sf.getShape("rectangle");
            Shape s = sf.getShape("square");
                    
            c.calculateArea();
            r.calculateArea();
            s.calculateArea();
            Console.ReadKey();

        }
    }
}
