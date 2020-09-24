using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Model.Triangle
{
    class RectangularTriangle : Triangle
    {
        public RectangularTriangle(double firstCathet, double secondCathet)
            : base(firstCathet, secondCathet, GetHypotenuse(firstCathet, secondCathet))
        {
            Name = "прямоугольный треугольник";
        }

        private static double GetHypotenuse(double firstCathet, double secondCathet)
        {
            return Math.Sqrt(Math.Pow(firstCathet, 2) + Math.Pow(secondCathet, 2));
        }

        public override double GetSquare()
        {
            return _firstSide * _secondSide / 2;
        }

    }
}
