using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLibrary.Figures
{
    public class Circle : Figure
    {
        private readonly double _radius;

        public override double Area => Math.PI * _radius * _radius;

        public Circle(double radius)
        {
            if(radius < 0) throw new ArgumentOutOfRangeException(nameof(radius), "Radius should not be negative.");
            _radius = radius;
        }
    }
}
