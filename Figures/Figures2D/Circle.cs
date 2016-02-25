using Figures.Base;
using System;

namespace Figures.Figures2D
{
    public class Circle : BaseFigure2D
    {
        private readonly int _radius;

        public Circle(int radius)
        {
            this._radius = radius;
        }

        protected override string FigureName
        {
            get { return "Circle"; }
        }

        public override int GetPerimeter()
        {
            return Convert.ToInt32(2 * Math.PI * (double)_radius);
        }

        public override int GetArea()
        {
            return Convert.ToInt32(Math.PI * (double)(_radius * _radius));
        }

        public override string GetFigureInfo()
        {
            return string.Format("{0}\t\tr: {1}\t\tArea:{2}", FigureName, _radius, GetArea());
        }
    }
}
