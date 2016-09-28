using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //get a shape factory
            AbstractFactory shapeFactory = FactoryProducer.getFactory("shape");
            //get an object of shape circle
            Shape shape1 = shapeFactory.getShape("circle");
            //call draw method of Shape Circle
            shape1.draw();

            //get a color factory
            AbstractFactory colorFactory = FactoryProducer.getFactory("color");
            //get an object of color green
            Color color1 = colorFactory.getColor("green");
            //call fill method of Color Green
            color1.fill();

            Console.ReadKey();
        }
    }
}
