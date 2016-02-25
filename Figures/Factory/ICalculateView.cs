
namespace Figures.Factory
{
    public interface ICalculateView
    {
        int SideA { get; }
        int SideB { get; }
        int SideC { get; }
        int SideD { get; }
        int FlatHeight { get; }
        int Radius { get; }

        Figure2DType Figure2D { get; }
        Figure3DType Figure3D { get; }
    }
}
