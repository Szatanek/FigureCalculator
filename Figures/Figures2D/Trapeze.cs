using Figures.Base;

namespace Figures.Figures2D
{
    public class Trapeze : BaseFigure2D
    {
        private readonly int _sideA;
        private readonly int _sideB;
        private readonly int _sideC;
        private readonly int _sideD;
        private readonly int _height;

        public Trapeze(int sideA, int sideB, int sideC, int sideD, int height)
        {
            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
            _sideD = sideD;
            _height = height;
        }

        protected override string FigureName
        {
            get { return "Trapeze"; }
        }

        public override int GetPerimeter()
        {
            return _sideA + _sideB + _sideC + _sideD;
        }

        public override int GetArea()
        {
            return (_sideA + _sideB) * _height / 2;
        }

        public override string GetFigureInfo()
        {
            return string.Format("{0}\t\ta: {1}\tb: {2}\tc: {3}\td: {4}\th: {5}\t\tArea:{6}", FigureName, _sideA, _sideB, _sideC, _sideD, _height, GetArea());
        }
    }
}
