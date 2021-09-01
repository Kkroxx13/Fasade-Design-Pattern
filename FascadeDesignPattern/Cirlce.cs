using System;
using System.Collections.Generic;
using System.Text;

namespace FascadeDesignPattern
{
    public class Cirlce : IShape
    {
        public void Draw()
        {

            Console.WriteLine("Draw -> Circle");
        }
    }
}
