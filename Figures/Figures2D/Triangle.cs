using Figures.Base;

namespace Figures.Figures2D
{
    public class Triangle : BaseFigure
    {
        private readonly int _side;
        private readonly int _height;

        public Triangle(int Side, int Height)
        {
            _side = Side;
            _height = Height;
        }

        public override int GetPerimeter()
        {
            return 3 * _side;
        }

        public override int GetArea()
        {
            return _side * _height / 2;
        }
    }
}
