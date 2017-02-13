using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Edge
    {
        public Edge(Point begin, Point end)
        {
            Begin = begin;
            End = end;
        }

        public Point Begin { get; }
        public Point End { get; }

        public double Length
        {
            get
            {
                return 1;
            }
        }
    }
}
