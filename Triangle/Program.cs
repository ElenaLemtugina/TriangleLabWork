using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            var myTriangle = new Triangle(new Point(1, 1), new Point(4, 1), new Point(4, 5));

            Polygon nAngles = new Polygon ( new[] { new Point(1, 1), new Point(4, 1), new Point(4, 5) });
            Console.WriteLine(nAngles.Perimeter + " " + nAngles.Area);

            Console.WriteLine("Периметр заданного треугольника = " + myTriangle.Perimeter);
            Console.WriteLine("Площадь заданного треугольника = " + myTriangle.Area);
            Console.WriteLine("Треугольник прямой? " + myTriangle.Right);
            Console.WriteLine("Треугольник равнобедренный? " + myTriangle.Isosceles);

            Triangle[] trngls = new[] { new Triangle(new Point(1, 1), new Point(4, 1), new Point(4, 5)),
                                        new Triangle(new Point(2, 5), new Point(6, 7), new Point(4, 8)),
                                        new Triangle(new Point(1, 1), new Point(1, 6), new Point(6, 6)),
                                        new Triangle(new Point(5, 1), new Point(7, 5), new Point(9, 1))};

            double countRight = 0;
            double perimetrRight = 0;
            double countIsosceles = 0;
            double areaIsosceles = 0;
            foreach(var i in trngls)
            {
                if(i.Right)
                {
                    countRight++;
                    perimetrRight += i.Perimeter;
                }

                if(i.Isosceles)
                {
                    countIsosceles++;
                    areaIsosceles += i.Area;
                }
            }
            double avgPerimetr = perimetrRight/countRight;
            double avgArea = areaIsosceles/countIsosceles;

            Console.WriteLine("Средний периметр прямых треугольников = {0},\nСредняя площадь равнобедренных треугольников = {1}", avgPerimetr, avgArea);

        }
    }
}
