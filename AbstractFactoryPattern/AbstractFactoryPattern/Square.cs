using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    class Square : Shape
    {
       public void draw()
        {
            Console.WriteLine("Iside Square:: draw() method.");
        }
    }
}
