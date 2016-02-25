using Figures.Base;

namespace Figures.Figures2D
{
    public class Triangle : BaseFigure2D
    {
        private readonly int _side;
        private readonly int _height;

        public Triangle(int Side, int Height)
        {
            _side = Side;
            _height = Height;
        }

        protected override string FigureName
        {
            get { return "Triangle"; }
        }

        public override int GetPerimeter()
        {
            return 3 * _side;
        }

        public override int GetArea()
        {
            return _side * _height / 2;
        }

        public override string GetFigureInfo()
        {
            return string.Format("{0}\t\ta: {1}\th: {2}\t\tArea:{3}", FigureName, _side, _height, GetArea());
        }
    }
}
