using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    class ColourFactory : AbstractFactory
    {
        public override Color getColor(string color)
        {
            if (color == null)
            {
                return null;
            }
            else if (color.Equals("red"))
            {
                return new Red();
            }
            else if (color.Equals("green"))
            {
                return new Green();
            }
            return null;
        }

        public override Shape getShape(string shape)
        {
            return null;
        }
    }
}
