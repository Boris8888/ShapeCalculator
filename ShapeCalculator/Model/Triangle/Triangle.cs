using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Model.Triangle
{
    class Triangle : ShapeBase
    {
        protected double _firstSide;

        protected double _secondSide;

        protected double _thirdSide;

        public Triangle(double firstSide, double secondSide,
            double thirdSide) : base()
        {
            Name = "треугольник";
            _firstSide = firstSide;
            _secondSide = secondSide;
            _thirdSide = thirdSide;
        }

        public override double GetPerimeter()
        {
            return _firstSide + _secondSide + _thirdSide;
        }

        public override double GetSquare()
        {
            double halfPerimeter = GetPerimeter() / 2;
            return Math.Sqrt(halfPerimeter * 
                (halfPerimeter - _firstSide) *
                (halfPerimeter - _secondSide) *
                (halfPerimeter - _thirdSide));
        }
    }
}
