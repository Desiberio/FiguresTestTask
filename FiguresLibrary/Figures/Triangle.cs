using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLibrary.Figures
{
    public class Triangle : Figure
    {
        private readonly double _firstSide;
        private readonly double _secondSide;
        private readonly double _thirdSide;

        public override double Area
        {
            get
            {
                double semiperimeter = (_firstSide + _secondSide + _thirdSide) / 2;
                return Math.Sqrt(semiperimeter * (semiperimeter - _firstSide) * (semiperimeter - _secondSide) * (semiperimeter - _thirdSide));
            }
        }

        public bool IsRightAngled {
            get
            {
                return _firstSide * _firstSide == _secondSide * _secondSide + _thirdSide * _thirdSide ||
                       _secondSide * _secondSide == _firstSide * _firstSide + _thirdSide * _thirdSide ||
                       _thirdSide * _thirdSide == _firstSide * _firstSide + _secondSide * _secondSide;
            }
        }

        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            if(firstSide <= 0 || secondSide <= 0 || thirdSide <= 0) throw new ArgumentOutOfRangeException(nameof(firstSide), "Sides should not be negative.");

            if (IsValid(firstSide, secondSide, thirdSide) == false) throw new ArgumentException("Triangle is not valid.");
            
            _firstSide = firstSide;
            _secondSide = secondSide;
            _thirdSide = thirdSide;
        }

        private bool IsValid(double firstSide, double secondSide, double thirdSide)
        {
            return firstSide + secondSide > thirdSide &&
                   firstSide + thirdSide > secondSide &&
                   secondSide + thirdSide > firstSide;
            
        }
    }
}
