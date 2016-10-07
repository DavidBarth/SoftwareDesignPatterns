using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacadePattern.IF;

namespace FacadePattern.Model
{
    class Rectangle : IShape
    {
        //implements IShape draw method
        public void draw()
        {
            Console.WriteLine("Rectangle::draw()");
        }
    }
}
