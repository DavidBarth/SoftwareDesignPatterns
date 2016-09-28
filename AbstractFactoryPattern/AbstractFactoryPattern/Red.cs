using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    class Red : Color
    {
        public void fill()
        {
            Console.WriteLine("Iside Red:: fill() method.");
        }
    }
}
