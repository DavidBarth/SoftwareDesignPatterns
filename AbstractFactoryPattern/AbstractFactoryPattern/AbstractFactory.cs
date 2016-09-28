using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public abstract class AbstractFactory
    {
        public abstract Color getColor(string color);
        public abstract Shape getShape(string shape);
    }
}
