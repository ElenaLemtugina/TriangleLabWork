using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Polygon
    {
        public readonly Point[] Points;
        private Edge[] edges;

        public Polygon(Point[] points)
        {
            Points = points;
            CreateEdges();
        }

        private void CreateEdges()
        {
            List<Edge> edgesList = new List<Edge>();
            for (int i = 0; i<Points.Length - 1; i++)
            {
                edgesList.Add(new Edge(Points[i], Points[i + 1]));
            }
            edgesList.Add(new Edge(Points[Points.Length - 1], Points[0]));
            edges = edgesList.ToArray();
        }

        public double Perimeter
        {
            get
            {
                return edges.Sum(x => x.Length);
            }
        }

        public double Area
        {
            get
            {
                double sum = 0;
                for (int i = 0; i < Points.Length - 1; i++)
                    sum += Determinant(Points[i], Points[i + 1]);
                sum += Determinant(Points[Points.Length - 1], Points[0]);

                return sum * 0.5;
            }
        }
        private int Determinant(Point a, Point b)
        {
            return a.X * b.Y - a.Y * b.X;
        }
    }
}
