using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Polygon
    {
        public readonly Point[] points;

        public Polygon(Point[] points)
        {
            this.points = points;            
        }

        public double Perimeter
        {
            get
            {
                List<Edge> edges = new List<Edge>();
                for (int i = 0; i < points.Length-1; i++)
                {
                    edges.Add(new Edge(points[i], points[i+1]));
                }
                edges.Add(new Edge(points[points.Length - 1], points[0]));
                return edges.Sum(x => x.Length);
            }
        }

        public double Area
        {
            get
            {
                double sum = 0;
                for (int i = 0; i < points.Length - 1; i++)
                    sum += Determinant(points[i], points[i + 1]);
                sum += Determinant(points[points.Length - 1], points[0]);

                return sum * 0.5;
            }
        }
        private int Determinant(Point a, Point b)
        {
            return a.X * b.Y - a.Y * b.X;
        }
    }
}
