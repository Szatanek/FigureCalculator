using Figures.Base;

namespace Figures.Factory
{
    public abstract class AbstractFactory
    {
        public abstract BaseFigure CreateFigure(ICalculateView view);
    }
}
