using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Model.Triangle
{
    class IsoscelesTriangle : Triangle
    {
        public IsoscelesTriangle(double side, double baseSide)
            : base(side, side, baseSide)
        {
            Name = "равнобедренный треугольник";
        }

        public override double GetPerimeter()
        {
            return _firstSide * 2 + _thirdSide;
        }

        public override double GetSquare()
        {            
            return _thirdSide * Math.Sqrt(
                Math.Pow(_firstSide, 2) - 
                Math.Pow(_thirdSide, 2)/4)/ 2;
        }
    }
}
