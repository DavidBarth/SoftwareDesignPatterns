using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacadePattern.Model;
using FacadePattern.IF;

namespace FacadePattern.Facade
{
    class ShapeMaker
    {
        //composition use of IShape 
        private IShape circle;
        private IShape square;
        private IShape rectangle;

        //constructor
        public ShapeMaker()
        {
            
            circle = new Circle();
            square = new Square();
            rectangle = new Rectangle();
        }

        public void drawCircle() { circle.draw(); }

        public void drawSquare() { square.draw(); }

        public void drawRectangle() { rectangle.draw(); }



    }
}
