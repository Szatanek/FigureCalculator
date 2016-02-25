using Figures.Base;
using Figures.Figures3D;
using System;

namespace Figures.Factory
{
    public class Figure3DFactory : AbstractFactory
    {
        public override BaseFigure CreateFigure(ICalculateView view)
        {
            switch (view.Figure3D)
            {
                case Figure3DType.Cube:
                    return new Cube(view.SideA);
                case Figure3DType.Sphere:
                    return new Sphere(view.Radius);
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
