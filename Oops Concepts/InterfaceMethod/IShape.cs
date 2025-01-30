using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceMethod
{
    //By default, interface is publlic and abstract
    internal interface IShape
    {
        void CalculateArea();

        void DefaultSquare(int side)
        {
            Console.WriteLine("area of square: " +Math.Pow(side,2));
        }
    }

    //void DefaultSquareArea()
    //{

    //}
    class Circle : IShape
    {
        public int radius { get; set; }
        public void CalculateArea()
        {
            Console.WriteLine($"Area of circle: {Math.PI * Math.Pow(radius, 2)}");
        }

    }
    class Rect : IShape
    {
        public int l { get; set; }
        public int b { get; set; }
        public void CalculateArea()
        {
            Console.WriteLine($"Area of Rectangle: {l*b}");
        }
    }
}
