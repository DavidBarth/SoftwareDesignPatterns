using FacadePattern.IF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.Model
{
    class Square : IShape
    {
        //implements IShape draw method
        public void draw()
        {
            Console.WriteLine("Square::draw()");
        }
    }
}
