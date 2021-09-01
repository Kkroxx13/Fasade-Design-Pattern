using System;
using System.Collections.Generic;
using System.Text;

namespace FascadeDesignPattern
{
    public class Rectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Draw -> Rectangle");
        }
    }
}
