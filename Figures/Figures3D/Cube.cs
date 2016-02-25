using Figures.Base;

namespace Figures.Figures3D
{
    public class Cube : BaseFigure3D
    {
        private readonly int _side;

        public Cube(int side)
        {
            _side = side;
        }

        protected override string FigureName
        {
            get { return "Cube"; }
        }

        public override int GetVolume()
        {
            return _side * _side * _side;
        }

        public override int GetArea()
        {
            return 6 * _side * _side;
        }

        public override string GetFigureInfo()
        {
            return string.Format("{0}\t\ta: {1}\t\tArea:{2}\tVolume:{3}", FigureName, _side, GetArea(), GetVolume());
        }
    }
}
