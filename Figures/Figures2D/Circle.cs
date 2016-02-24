using Figures.Base;
using System;

namespace Figures.Figures2D
{
    public class Circle : BaseFigure
    {
        private readonly int radius;

        public Circle(int radius)
        {
            this.radius = radius;
        }

        public override int GetPerimeter()
        {
            return Convert.ToInt32(2 * Math.PI * (double)radius);
        }

        public override int GetArea()
        {
            return Convert.ToInt32(Math.PI * (double)(radius * radius));
        }
    }
}
