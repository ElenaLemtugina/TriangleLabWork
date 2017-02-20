using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Triangle
    {
        public Edge A { get; }
        public Edge B { get; }
        public Edge C { get; }

        public Triangle(Point a, Point b, Point c)
        {
            A = new Edge(a, b);
            B = new Edge(b, c);
            C = new Edge(a, c);
        }

        public double Perimeter 
        { 
            get 
            {
                return A.Length + B.Length + C.Length;
            }  
        }

        public double Area
        {
            get
            {
                double p = Perimeter / 2;
                return Math.Sqrt(p*(p-A.Length)*(p-B.Length)*(p-C.Length));
            }
        }

        public bool Right
        {
            get
            {
                return Math.Abs(A.Length - Math.Sqrt(Math.Pow(B.Length, 2) + Math.Pow(C.Length, 2))) < 1e-9 ||
                       Math.Abs(B.Length - Math.Sqrt(Math.Pow(A.Length, 2) + Math.Pow(C.Length, 2))) < 1e-9 ||
                       Math.Abs(C.Length - Math.Sqrt(Math.Pow(A.Length, 2) + Math.Pow(B.Length, 2))) < 1e-9;
            }
        }

        public bool Isosceles
        {
            get
            {
                return A.Length == B.Length && A.Length != C.Length ||
                       B.Length == C.Length && B.Length != A.Length ||
                       A.Length == C.Length && A.Length != B.Length;
            }
        }
    }
}
