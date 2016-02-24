using Figures.Base;

namespace Figures.Figures2D
{
    public class Rectangle : BaseFigure
    {
        private readonly int _sideA;
        private readonly int _sideB;

        public Rectangle(int SideA, int SideB)
        {
            _sideA = SideA;
            _sideB = SideB;
        }

        public override int GetPerimeter()
        {
            return 2 * _sideA + 2 * _sideB;
        }

        public override int GetArea()
        {
            return _sideA * _sideB;
        }
    }
}
