using Figures.Base;

namespace Figures.Figures2D
{
    public class Square : BaseFigure
    {
        private int _side;

        public Square(int side)
        {
            _side = side;
        }

        public override int GetPerimeter()
        {
            return 4 * _side;
        }

        public override int GetArea()
        {
            return _side * _side;
        }
    }
}
