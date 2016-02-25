
namespace Figures.Base
{
    public abstract class BaseFigure
    {
        protected abstract string FigureName { get; }
        public abstract int GetArea();
        public abstract string GetFigureInfo();
    }
}
