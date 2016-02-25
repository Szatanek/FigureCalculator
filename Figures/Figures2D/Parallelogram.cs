using Figures.Base;

namespace Figures.Figures2D
{
    public class Parallelogram : BaseFigure2D
    {
        private readonly int _sideA;
        private readonly int _height;
        private int _sideB;

        public Parallelogram(int sideA, int sideB, int height)
        {
            _sideA = sideA;
            _sideB = sideB;
            _height = height;
        }

        protected override string FigureName
        {
            get { return "Parallelogram"; }
        }

        public override int GetPerimeter()
        {
            return 2 * (_sideA + _sideB);
        }

        public override int GetArea()
        {
            return _sideA * _height;
        }

        public override string GetFigureInfo()
        {
            return string.Format("{0}\t\ta: {1}\th: {2}\t\tArea:{3}", FigureName, _sideA, _height, GetArea());
        }
    }
}
