using Figures.Factory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figures.View
{
    public partial class Main : Form, ICalculateView
    {
        private AbstractFactory _factory = new Figure2DFactory();

        public Main()
        {
            InitializeComponent();
        }

        public int SideA
        {
            get { return (int)SideAVal.Value; }
        }

        public int SideB
        {
            get { return (int)SideBVal.Value; }
        }

        public int SideC
        {
            get { return (int)SideCVal.Value; }
        }

        public int SideD
        {
            get { return (int)SideDVal.Value; }
        }

        public int Radius
        {
            get { return (int)RadiusVal.Value; }
        }

        public int FlatHeight
        {
            get { return (int)HeightVal.Value; }
        }

        public Figure2DType Figure2D
        {
            get { return (Figure2DType)this.SelectShapeCmb.SelectedIndex; }
        }

        public Figure3DType Figure3D
        {
            get { return (Figure3DType)this.SelectShapeCmb.SelectedIndex; }
        }

        private void FiguresTypeCheckedChanged(object sender, EventArgs e)
        {
            var senderRadioButton = sender as RadioButton;
            Radio2DBtn.Checked = false;
            Radio3DBtn.Checked = false;
            senderRadioButton.Checked = true;
            SetFigureTypes();
        }

        private void MainLoaded(object sender, EventArgs e)
        {
            SetFigureTypes();
        }

        private void SetFigureTypes()
        {
            Type enumType = null;
            if (Radio2DBtn.Checked)
            {
                enumType = typeof(Figure2DType);
                _factory = new Figure2DFactory();
            }
            else
            {
                enumType = typeof(Figure3DType);
            }

            SelectShapeCmb.DataSource = Enum.GetValues(enumType);
        }

        private void ClearAll()
        {
            SideAVal.Value = 0;
            SideBVal.Value = 0;
            SideCVal.Value = 0;
            SideDVal.Value = 0;
            RadiusVal.Value = 0;
            HeightVal.Value = 0;
            AreaValue.Text = "0";
        }

        private void SelectedShapeChanged(object sender, EventArgs e)
        {
            ClearAll();
            HideAll();
            if (Radio2DBtn.Checked)
            {
                ShowControls(Figure2D);
            }
            else
            {
                ShowControls(Figure3D);
            }

            FigureParamsContainer.Update();
        }

        private void ShowControls(Figure3DType figure3D)
        {
            switch (figure3D)
            {
                case Figure3DType.Cube:
                    LabelA.Visible = true;
                    SideAVal.Visible = true;
                    break;
                case Figure3DType.Sphere:
                    LabelR.Visible = true;
                    RadiusVal.Visible = true;
                    break;
                default:
                    break;
            }
        }

        private void ShowControls(Figure2DType figure2D)
        {
            switch (figure2D)
            {
                case Figure2DType.Square:
                    LabelA.Visible = true;
                    SideAVal.Visible = true;
                    break;
                case Figure2DType.Rectangle:
                    LabelA.Visible = true;
                    SideAVal.Visible = true;
                    LabelB.Visible = true;
                    SideBVal.Visible = true;
                    break;
                case Figure2DType.Triangle:
                    LabelA.Visible = true;
                    SideAVal.Visible = true;
                    LabelH.Visible = true;
                    HeightVal.Visible = true;
                    break;
                case Figure2DType.Trapeze:
                    LabelA.Visible = true;
                    SideAVal.Visible = true;
                    LabelB.Visible = true;
                    SideBVal.Visible = true;
                    LabelC.Visible = true;
                    SideCVal.Visible = true;
                    LabelD.Visible = true;
                    SideDVal.Visible = true;
                    LabelH.Visible = true;
                    HeightVal.Visible = true;
                    break;
                case Figure2DType.Parallelogram:
                    LabelA.Visible = true;
                    SideAVal.Visible = true;
                    LabelH.Visible = true;
                    HeightVal.Visible = true;
                    break;
                case Figure2DType.Circle:
                    LabelR.Visible = true;
                    RadiusVal.Visible = true;
                    break;
                default:
                    break;
            }
        }

        private void HideAll()
        {
            SideAVal.Visible = false;
            SideBVal.Visible = false;
            SideCVal.Visible = false;
            SideDVal.Visible = false;
            RadiusVal.Visible = false;
            HeightVal.Visible = false;
            LabelA.Visible = false;
            LabelB.Visible = false;
            LabelC.Visible = false;
            LabelD.Visible = false;
            LabelR.Visible = false;
            LabelH.Visible = false;

        }

        private void CalculateClicked(object sender, EventArgs e)
        {
            var figure = _factory.CreateFigure(this);
            AreaValue.Text = figure.GetArea().ToString();
        }
    }
}
