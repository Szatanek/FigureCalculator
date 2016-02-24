using Figures.Base;

namespace Figures.Figures2D
{
    public class Trapeze : BaseFigure
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

        public override int GetPerimeter()
        {
            return _sideA + _sideB + _sideC + _sideD;
        }

        public override int GetArea()
        {
            return (_sideA + _sideB) * _height / 2;
        }
    }
}
