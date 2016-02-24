using Figures.Base;
using Figures.Figures2D;
using System;

namespace Figures.Factory
{
    public class Figure2DFactory : AbstractFactory
    {
        public override BaseFigure CreateFigure(ICalculateView view)
        {
            switch (view.Figure2D)
            {
                case Figure2DType.Square:
                    return new Square(view.SideA);
                case Figure2DType.Rectangle:
                    return new Rectangle(view.SideA, view.SideB);
                case Figure2DType.Triangle:
                    return new Triangle(view.SideA, view.FlatHeight);
                case Figure2DType.Trapeze:
                    return new Trapeze(view.SideA, view.SideB, view.SideC, view.SideD, view.FlatHeight);
                case Figure2DType.Parallelogram:
                    return new Parallelogram(view.SideA, view.SideB, view.FlatHeight);
                case Figure2DType.Circle:
                    return new Circle(view.Radius);
                default:
                    throw new NotImplementedException();;
            }
        }
    }
}
