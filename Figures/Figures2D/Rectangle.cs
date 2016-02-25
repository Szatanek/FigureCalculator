using Figures.Base;

namespace Figures.Figures2D
{
    public class Rectangle : BaseFigure2D
    {
        private readonly int _sideA;
        private readonly int _sideB;

        public Rectangle(int SideA, int SideB)
        {
            _sideA = SideA;
            _sideB = SideB;
        }

        protected override string FigureName
        {
            get { return "Rectangle"; }
        }

        public override int GetPerimeter()
        {
            return 2 * _sideA + 2 * _sideB;
        }

        public override int GetArea()
        {
            return _sideA * _sideB;
        }

        public override string GetFigureInfo()
        {
            return string.Format("{0}\t\ta: {1}\tb: {2}\t\tArea:{3}", FigureName, _sideA, _sideB, GetArea());
        }
    }
}
