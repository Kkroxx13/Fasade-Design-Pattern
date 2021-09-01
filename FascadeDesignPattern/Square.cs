using System;
using System.Collections.Generic;
using System.Text;

namespace FascadeDesignPattern
{
    public class Square : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Draw -> Square");
        }
    }
}
