using FacadePattern.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate ShapeMaker facade object
            ShapeMaker SM = new ShapeMaker();

            SM.drawCircle();
            SM.drawRectangle();
            SM.drawSquare();
        }
    }
}
