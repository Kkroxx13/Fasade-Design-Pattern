using System;
using System.Collections.Generic;
using System.Text;

namespace FascadeDesignPattern
{
   public class ShapeMaker
    {
        private IShape circle;
        private IShape rectangle;
        private IShape square;
        public ShapeMaker()
        {
            circle = new Cirlce();
            rectangle = new Rectangle();
            square = new Square();
        }
        public void DrawCircle()
        {
            circle.Draw();
        }
        public void DrawRectangle()
        {
            rectangle.Draw();
        }
        public void DrawSquare()
        {
            square.Draw();
        }
    }
}
