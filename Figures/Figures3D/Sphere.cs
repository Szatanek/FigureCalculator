using Figures.Base;
using System;

namespace Figures.Figures3D
{
    public class Sphere : BaseFigure3D
    {
        private readonly int _radius;

        public Sphere(int radius)
        {
            _radius = radius;
        }

        protected override string FigureName
        {
            get { return "Sphere"; }
        }

        public override int GetVolume()
        {
            return Convert.ToInt32(4 * Math.PI * (double)(_radius * _radius * _radius) / 3);
        }

        public override int GetArea()
        {
            return Convert.ToInt32(4 * Math.PI * (double)(_radius * _radius));
        }

        public override string GetFigureInfo()
        {
            return string.Format("{0}\t\tr: {1}\t\tArea:{2}\tVolume:{3}", FigureName, _radius, GetArea(), GetVolume());
        }
    }
}
