using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    class FactoryProducer
    {
        public static AbstractFactory getFactory(string choice)
        {
            if (choice.Equals("shape"))
            {
                return new ShapeFactory();
            }else if (choice.Equals("color"))
            {
                return new ColourFactory();
            }return null;
        }
    }
}
