using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class ShapeFactory
    {
        public Shape getShape(string shapeType)
        {
            if (shapeType == null)
            {
                return null;
            }
            if (shapeType.Equals("circle"))
            {
                return new Circle();

            } else if (shapeType.Equals("square"))
            {
                return new Square();
            } else if (shapeType.Equals("rectangle"))
            {
                return new Rectangle();
            }
            return null;
        }
    }
}
