using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Triangle
    {
        public Triangle(Point a, Point b, Point c)
        {
            A = a;
            B = b;
            C = c;
        }

        public Point A { get; }
        public Point B { get; }
        public Point C { get; }

        public double Perimeter 
        { 
            get 
            {
                return 0;
            } 
        }
    }
}
