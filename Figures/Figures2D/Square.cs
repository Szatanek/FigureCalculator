using Figures.Base;

namespace Figures.Figures2D
{
    public class Square : BaseFigure2D
    {
        private int _side;

        public Square(int side)
        {
            _side = side;
        }

        protected override string FigureName
        {
            get { return "Square"; }
        }

        public override int GetPerimeter()
        {
            return 4 * _side;
        }

        public override int GetArea()
        {
            return _side * _side;
        }

        public override string GetFigureInfo()
        {
            return string.Format("{0}\t\ta: {1}\t\tArea:{2}", FigureName, _side, GetArea());
        }
    }
}
