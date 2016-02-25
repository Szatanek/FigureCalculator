using Figures.Base;
using Figures.Factory;
using Figures.FileRepository;
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
        private const string DefaultFileName = "Figure calculation results";
        private static readonly string DesktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        private AbstractFactory _factory = new Figure2DFactory();
        private FileWriter _fileWriter;

        public Main()
        {
            InitializeComponent();
        }

        #region ICalculateView Members

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

        #endregion

        #region Events

        private void MainLoaded(object sender, EventArgs e)
        {
            SetFigureTypes();
            InitializeFileProperties();
        }

        private void FiguresTypeCheckedChanged(object sender, EventArgs e)
        {
            var senderRadioButton = sender as RadioButton;
            Radio2DBtn.Checked = false;
            Radio3DBtn.Checked = false;
            senderRadioButton.Checked = true;
            SetFigureTypes();
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

        private void CalculateClicked(object sender, EventArgs e)
        {
            var figure = _factory.CreateFigure(this);
            ShowResults(figure);
        }

        private void SelectPathClicked(object sender, EventArgs e)
        {
            if (BrowseFolderDialog.ShowDialog() == DialogResult.OK)
            {
                SelectedFilePath.Text = BrowseFolderDialog.SelectedPath;
            }
        }

        private void SelectedPathChanged(object sender, EventArgs e)
        {
            _fileWriter = new FileWriter(SelectedFilePath.Text, SelectedFileName.Text);
        }

        private void ExportClicked(object sender, EventArgs e)
        {
            var figure = _factory.CreateFigure(this);
            _fileWriter.SaveFigurePropertiesToFile(figure);
        }

        #endregion

        #region Helper Methods

        private void ShowResults(BaseFigure figure)
        {
            AreaValue.Text = figure.GetArea().ToString();
            if (figure is BaseFigure3D)
            {
                VolumeValue.Text = (figure as BaseFigure3D).GetVolume().ToString();
            }
            else if (figure is BaseFigure2D)
            {
                PerimeterValue.Text = (figure as BaseFigure2D).GetPerimeter().ToString();
            }
        }

        private void InitializeFileProperties()
        {
            SelectedFileName.Text = DefaultFileName;
            SelectedFilePath.Text = DesktopPath;
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
                _factory = new Figure3DFactory();
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
            VolumeValue.Text = "0";
            PerimeterValue.Text = "0";
        }

        private void ShowControls(Figure3DType figure3D)
        {
            VolumeLabel.Visible = true;
            VolumeValue.Visible = true;
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
            PerimeterLabel.Visible = true;
            PerimeterValue.Visible = true;
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
            VolumeLabel.Visible = false;
            VolumeValue.Visible = false;
            PerimeterLabel.Visible = false;
            PerimeterValue.Visible = false;
        }

        #endregion
    }
}
