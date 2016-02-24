using Figures.Base;

namespace Figures.Figures2D
{
    public class Parallelogram : BaseFigure
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

        public override int GetPerimeter()
        {
            return 2 * (_sideA + _sideB);
        }

        public override int GetArea()
        {
            return _sideA * _height;
        }
    }
}
