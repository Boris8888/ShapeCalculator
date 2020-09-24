using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Model.Triangle
{
    class EquilateralTriangle : Triangle
    {
        public EquilateralTriangle(double side) : base(side, side, side)
        {
            Name = "равносторонний треугольник";
        }

        public override double GetPerimeter()
        {
            return _firstSide * 3;
        }

        public override double GetSquare()
        {
            return Math.Sqrt(3) / 4 * Math.Pow(_firstSide, 2);
        }
    }
}
