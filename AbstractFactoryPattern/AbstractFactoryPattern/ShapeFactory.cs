using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    class ShapeFactory : AbstractFactory
    {
       public override Shape getShape(string shapeType)
        {
            if(shapeType == null)
            {
                return null;
                
            }else if (shapeType.Equals("circle"))
            {
                return new Circle();

            }else if(shapeType.Equals("square"))
            {
                return new Square();
            }
            return null;
        }

        public override Color getColor(string color)
        {
            return null;
        }
    }
}
