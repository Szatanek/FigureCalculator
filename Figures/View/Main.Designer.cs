namespace Figures.View
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CalculateBtn = new System.Windows.Forms.Button();
            this.ExportBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SelectShapeCmb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Radio3DBtn = new System.Windows.Forms.RadioButton();
            this.Radio2DBtn = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.FigureParamsContainer = new System.Windows.Forms.GroupBox();
            this.VolumeValue = new System.Windows.Forms.Label();
            this.AreaValue = new System.Windows.Forms.Label();
            this.VolumeLabel = new System.Windows.Forms.Label();
            this.AreaLabel = new System.Windows.Forms.Label();
            this.RadiusVal = new System.Windows.Forms.NumericUpDown();
            this.LabelR = new System.Windows.Forms.Label();
            this.HeightVal = new System.Windows.Forms.NumericUpDown();
            this.LabelH = new System.Windows.Forms.Label();
            this.SideDVal = new System.Windows.Forms.NumericUpDown();
            this.SideCVal = new System.Windows.Forms.NumericUpDown();
            this.SideBVal = new System.Windows.Forms.NumericUpDown();
            this.SideAVal = new System.Windows.Forms.NumericUpDown();
            this.LabelD = new System.Windows.Forms.Label();
            this.LabelC = new System.Windows.Forms.Label();
            this.LabelB = new System.Windows.Forms.Label();
            this.LabelA = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BrowseBtn = new System.Windows.Forms.Button();
            this.SelectedFileName = new System.Windows.Forms.TextBox();
            this.SelectedFilePath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BrowseFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.PerimeterValue = new System.Windows.Forms.Label();
            this.PerimeterLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.FigureParamsContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RadiusVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SideDVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SideCVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SideBVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SideAVal)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CalculateBtn
            // 
            this.CalculateBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CalculateBtn.Location = new System.Drawing.Point(460, 201);
            this.CalculateBtn.Name = "CalculateBtn";
            this.CalculateBtn.Size = new System.Drawing.Size(105, 23);
            this.CalculateBtn.TabIndex = 0;
            this.CalculateBtn.Text = "Calculate";
            this.CalculateBtn.UseVisualStyleBackColor = true;
            this.CalculateBtn.Click += new System.EventHandler(this.CalculateClicked);
            // 
            // ExportBtn
            // 
            this.ExportBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ExportBtn.Location = new System.Drawing.Point(460, 89);
            this.ExportBtn.Name = "ExportBtn";
            this.ExportBtn.Size = new System.Drawing.Size(105, 23);
            this.ExportBtn.TabIndex = 1;
            this.ExportBtn.Text = "Export";
            this.ExportBtn.UseVisualStyleBackColor = true;
            this.ExportBtn.Click += new System.EventHandler(this.ExportClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SelectShapeCmb);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Radio3DBtn);
            this.groupBox1.Controls.Add(this.Radio2DBtn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 30, 3, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(571, 137);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // SelectShapeCmb
            // 
            this.SelectShapeCmb.FormattingEnabled = true;
            this.SelectShapeCmb.Location = new System.Drawing.Point(208, 86);
            this.SelectShapeCmb.Name = "SelectShapeCmb";
            this.SelectShapeCmb.Size = new System.Drawing.Size(185, 21);
            this.SelectShapeCmb.TabIndex = 11;
            this.SelectShapeCmb.SelectedIndexChanged += new System.EventHandler(this.SelectedShapeChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(50, 30, 10, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Select shape:  ";
            // 
            // Radio3DBtn
            // 
            this.Radio3DBtn.AutoSize = true;
            this.Radio3DBtn.Location = new System.Drawing.Point(318, 44);
            this.Radio3DBtn.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.Radio3DBtn.Name = "Radio3DBtn";
            this.Radio3DBtn.Size = new System.Drawing.Size(76, 17);
            this.Radio3DBtn.TabIndex = 9;
            this.Radio3DBtn.Text = "3D Figures";
            this.Radio3DBtn.UseVisualStyleBackColor = true;
            this.Radio3DBtn.Click += new System.EventHandler(this.FiguresTypeCheckedChanged);
            // 
            // Radio2DBtn
            // 
            this.Radio2DBtn.AutoSize = true;
            this.Radio2DBtn.Checked = true;
            this.Radio2DBtn.Location = new System.Drawing.Point(208, 44);
            this.Radio2DBtn.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.Radio2DBtn.Name = "Radio2DBtn";
            this.Radio2DBtn.Size = new System.Drawing.Size(76, 17);
            this.Radio2DBtn.TabIndex = 8;
            this.Radio2DBtn.TabStop = true;
            this.Radio2DBtn.Text = "2D Figures";
            this.Radio2DBtn.UseVisualStyleBackColor = true;
            this.Radio2DBtn.Click += new System.EventHandler(this.FiguresTypeCheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(50, 30, 10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Select type of shapes: ";
            // 
            // FigureParamsContainer
            // 
            this.FigureParamsContainer.Controls.Add(this.PerimeterValue);
            this.FigureParamsContainer.Controls.Add(this.PerimeterLabel);
            this.FigureParamsContainer.Controls.Add(this.VolumeValue);
            this.FigureParamsContainer.Controls.Add(this.AreaValue);
            this.FigureParamsContainer.Controls.Add(this.VolumeLabel);
            this.FigureParamsContainer.Controls.Add(this.CalculateBtn);
            this.FigureParamsContainer.Controls.Add(this.AreaLabel);
            this.FigureParamsContainer.Controls.Add(this.RadiusVal);
            this.FigureParamsContainer.Controls.Add(this.LabelR);
            this.FigureParamsContainer.Controls.Add(this.HeightVal);
            this.FigureParamsContainer.Controls.Add(this.LabelH);
            this.FigureParamsContainer.Controls.Add(this.SideDVal);
            this.FigureParamsContainer.Controls.Add(this.SideCVal);
            this.FigureParamsContainer.Controls.Add(this.SideBVal);
            this.FigureParamsContainer.Controls.Add(this.SideAVal);
            this.FigureParamsContainer.Controls.Add(this.LabelD);
            this.FigureParamsContainer.Controls.Add(this.LabelC);
            this.FigureParamsContainer.Controls.Add(this.LabelB);
            this.FigureParamsContainer.Controls.Add(this.LabelA);
            this.FigureParamsContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.FigureParamsContainer.Location = new System.Drawing.Point(4, 141);
            this.FigureParamsContainer.Name = "FigureParamsContainer";
            this.FigureParamsContainer.Size = new System.Drawing.Size(571, 230);
            this.FigureParamsContainer.TabIndex = 8;
            this.FigureParamsContainer.TabStop = false;
            this.FigureParamsContainer.Text = "Figure parameters";
            // 
            // VolumeValue
            // 
            this.VolumeValue.AutoSize = true;
            this.VolumeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.VolumeValue.ForeColor = System.Drawing.Color.OliveDrab;
            this.VolumeValue.Location = new System.Drawing.Point(350, 147);
            this.VolumeValue.Margin = new System.Windows.Forms.Padding(20, 30, 10, 0);
            this.VolumeValue.Name = "VolumeValue";
            this.VolumeValue.Size = new System.Drawing.Size(19, 20);
            this.VolumeValue.TabIndex = 23;
            this.VolumeValue.Text = "0";
            // 
            // AreaValue
            // 
            this.AreaValue.AutoSize = true;
            this.AreaValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AreaValue.ForeColor = System.Drawing.Color.OliveDrab;
            this.AreaValue.Location = new System.Drawing.Point(350, 97);
            this.AreaValue.Margin = new System.Windows.Forms.Padding(20, 30, 10, 0);
            this.AreaValue.Name = "AreaValue";
            this.AreaValue.Size = new System.Drawing.Size(19, 20);
            this.AreaValue.TabIndex = 22;
            this.AreaValue.Text = "0";
            // 
            // VolumeLabel
            // 
            this.VolumeLabel.AutoSize = true;
            this.VolumeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.VolumeLabel.Location = new System.Drawing.Point(269, 147);
            this.VolumeLabel.Margin = new System.Windows.Forms.Padding(50, 30, 10, 0);
            this.VolumeLabel.Name = "VolumeLabel";
            this.VolumeLabel.Size = new System.Drawing.Size(71, 20);
            this.VolumeLabel.TabIndex = 21;
            this.VolumeLabel.Text = "Volume: ";
            // 
            // AreaLabel
            // 
            this.AreaLabel.AutoSize = true;
            this.AreaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AreaLabel.Location = new System.Drawing.Point(269, 97);
            this.AreaLabel.Margin = new System.Windows.Forms.Padding(50, 30, 10, 0);
            this.AreaLabel.Name = "AreaLabel";
            this.AreaLabel.Size = new System.Drawing.Size(51, 20);
            this.AreaLabel.TabIndex = 9;
            this.AreaLabel.Text = "Area: ";
            // 
            // RadiusVal
            // 
            this.RadiusVal.Location = new System.Drawing.Point(86, 44);
            this.RadiusVal.Margin = new System.Windows.Forms.Padding(10, 3, 20, 3);
            this.RadiusVal.Name = "RadiusVal";
            this.RadiusVal.Size = new System.Drawing.Size(84, 20);
            this.RadiusVal.TabIndex = 19;
            this.RadiusVal.Visible = false;
            // 
            // LabelR
            // 
            this.LabelR.AutoSize = true;
            this.LabelR.Location = new System.Drawing.Point(56, 46);
            this.LabelR.Margin = new System.Windows.Forms.Padding(50, 30, 10, 0);
            this.LabelR.Name = "LabelR";
            this.LabelR.Size = new System.Drawing.Size(10, 13);
            this.LabelR.TabIndex = 18;
            this.LabelR.Text = "r";
            this.LabelR.Visible = false;
            // 
            // HeightVal
            // 
            this.HeightVal.Location = new System.Drawing.Point(273, 44);
            this.HeightVal.Margin = new System.Windows.Forms.Padding(10, 3, 20, 3);
            this.HeightVal.Name = "HeightVal";
            this.HeightVal.Size = new System.Drawing.Size(84, 20);
            this.HeightVal.TabIndex = 17;
            // 
            // LabelH
            // 
            this.LabelH.AutoSize = true;
            this.LabelH.Location = new System.Drawing.Point(240, 46);
            this.LabelH.Margin = new System.Windows.Forms.Padding(50, 30, 10, 0);
            this.LabelH.Name = "LabelH";
            this.LabelH.Size = new System.Drawing.Size(13, 13);
            this.LabelH.TabIndex = 16;
            this.LabelH.Text = "h";
            // 
            // SideDVal
            // 
            this.SideDVal.Location = new System.Drawing.Point(86, 173);
            this.SideDVal.Margin = new System.Windows.Forms.Padding(10, 3, 20, 3);
            this.SideDVal.Name = "SideDVal";
            this.SideDVal.Size = new System.Drawing.Size(84, 20);
            this.SideDVal.TabIndex = 15;
            // 
            // SideCVal
            // 
            this.SideCVal.Location = new System.Drawing.Point(86, 130);
            this.SideCVal.Margin = new System.Windows.Forms.Padding(10, 3, 20, 3);
            this.SideCVal.Name = "SideCVal";
            this.SideCVal.Size = new System.Drawing.Size(84, 20);
            this.SideCVal.TabIndex = 14;
            // 
            // SideBVal
            // 
            this.SideBVal.Location = new System.Drawing.Point(86, 87);
            this.SideBVal.Margin = new System.Windows.Forms.Padding(10, 3, 20, 3);
            this.SideBVal.Name = "SideBVal";
            this.SideBVal.Size = new System.Drawing.Size(84, 20);
            this.SideBVal.TabIndex = 13;
            // 
            // SideAVal
            // 
            this.SideAVal.Location = new System.Drawing.Point(86, 44);
            this.SideAVal.Margin = new System.Windows.Forms.Padding(10, 3, 20, 3);
            this.SideAVal.Name = "SideAVal";
            this.SideAVal.Size = new System.Drawing.Size(84, 20);
            this.SideAVal.TabIndex = 12;
            // 
            // LabelD
            // 
            this.LabelD.AutoSize = true;
            this.LabelD.Location = new System.Drawing.Point(53, 175);
            this.LabelD.Margin = new System.Windows.Forms.Padding(50, 30, 10, 0);
            this.LabelD.Name = "LabelD";
            this.LabelD.Size = new System.Drawing.Size(13, 13);
            this.LabelD.TabIndex = 11;
            this.LabelD.Text = "d";
            // 
            // LabelC
            // 
            this.LabelC.AutoSize = true;
            this.LabelC.Location = new System.Drawing.Point(53, 132);
            this.LabelC.Margin = new System.Windows.Forms.Padding(50, 30, 10, 0);
            this.LabelC.Name = "LabelC";
            this.LabelC.Size = new System.Drawing.Size(13, 13);
            this.LabelC.TabIndex = 10;
            this.LabelC.Text = "c";
            // 
            // LabelB
            // 
            this.LabelB.AutoSize = true;
            this.LabelB.Location = new System.Drawing.Point(53, 89);
            this.LabelB.Margin = new System.Windows.Forms.Padding(50, 30, 10, 0);
            this.LabelB.Name = "LabelB";
            this.LabelB.Size = new System.Drawing.Size(13, 13);
            this.LabelB.TabIndex = 9;
            this.LabelB.Text = "b";
            // 
            // LabelA
            // 
            this.LabelA.AutoSize = true;
            this.LabelA.Location = new System.Drawing.Point(53, 46);
            this.LabelA.Margin = new System.Windows.Forms.Padding(50, 30, 10, 0);
            this.LabelA.Name = "LabelA";
            this.LabelA.Size = new System.Drawing.Size(13, 13);
            this.LabelA.TabIndex = 8;
            this.LabelA.Text = "a";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BrowseBtn);
            this.groupBox2.Controls.Add(this.SelectedFileName);
            this.groupBox2.Controls.Add(this.SelectedFilePath);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.ExportBtn);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(4, 371);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(571, 118);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Export";
            // 
            // BrowseBtn
            // 
            this.BrowseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BrowseBtn.Location = new System.Drawing.Point(392, 29);
            this.BrowseBtn.Margin = new System.Windows.Forms.Padding(0);
            this.BrowseBtn.Name = "BrowseBtn";
            this.BrowseBtn.Size = new System.Drawing.Size(26, 22);
            this.BrowseBtn.TabIndex = 24;
            this.BrowseBtn.Text = "...";
            this.BrowseBtn.UseVisualStyleBackColor = true;
            this.BrowseBtn.Click += new System.EventHandler(this.SelectPathClicked);
            // 
            // SelectedFileName
            // 
            this.SelectedFileName.Location = new System.Drawing.Point(171, 68);
            this.SelectedFileName.Name = "SelectedFileName";
            this.SelectedFileName.Size = new System.Drawing.Size(247, 20);
            this.SelectedFileName.TabIndex = 11;
            this.SelectedFileName.Leave += new System.EventHandler(this.SelectedPathChanged);
            // 
            // SelectedFilePath
            // 
            this.SelectedFilePath.Location = new System.Drawing.Point(171, 30);
            this.SelectedFilePath.Name = "SelectedFilePath";
            this.SelectedFilePath.Size = new System.Drawing.Size(222, 20);
            this.SelectedFilePath.TabIndex = 10;
            this.SelectedFilePath.Click += new System.EventHandler(this.SelectPathClicked);
            this.SelectedFilePath.TextChanged += new System.EventHandler(this.SelectedPathChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 71);
            this.label4.Margin = new System.Windows.Forms.Padding(50, 30, 10, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "File name: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 33);
            this.label3.Margin = new System.Windows.Forms.Padding(50, 30, 10, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Select directory: ";
            // 
            // PerimeterValue
            // 
            this.PerimeterValue.AutoSize = true;
            this.PerimeterValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PerimeterValue.ForeColor = System.Drawing.Color.OliveDrab;
            this.PerimeterValue.Location = new System.Drawing.Point(350, 147);
            this.PerimeterValue.Margin = new System.Windows.Forms.Padding(20, 30, 10, 0);
            this.PerimeterValue.Name = "PerimeterValue";
            this.PerimeterValue.Size = new System.Drawing.Size(19, 20);
            this.PerimeterValue.TabIndex = 25;
            this.PerimeterValue.Text = "0";
            // 
            // PerimeterLabel
            // 
            this.PerimeterLabel.AutoSize = true;
            this.PerimeterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PerimeterLabel.Location = new System.Drawing.Point(269, 147);
            this.PerimeterLabel.Margin = new System.Windows.Forms.Padding(50, 30, 10, 0);
            this.PerimeterLabel.Name = "PerimeterLabel";
            this.PerimeterLabel.Size = new System.Drawing.Size(85, 20);
            this.PerimeterLabel.TabIndex = 24;
            this.PerimeterLabel.Text = "Perimeter: ";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 495);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.FigureParamsContainer);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Figures calculator";
            this.Load += new System.EventHandler(this.MainLoaded);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.FigureParamsContainer.ResumeLayout(false);
            this.FigureParamsContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RadiusVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SideDVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SideCVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SideBVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SideAVal)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CalculateBtn;
        private System.Windows.Forms.Button ExportBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox SelectShapeCmb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton Radio3DBtn;
        private System.Windows.Forms.RadioButton Radio2DBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox FigureParamsContainer;
        private System.Windows.Forms.NumericUpDown SideAVal;
        private System.Windows.Forms.Label LabelD;
        private System.Windows.Forms.Label LabelC;
        private System.Windows.Forms.Label LabelB;
        private System.Windows.Forms.Label LabelA;
        private System.Windows.Forms.NumericUpDown SideDVal;
        private System.Windows.Forms.NumericUpDown SideCVal;
        private System.Windows.Forms.NumericUpDown SideBVal;
        private System.Windows.Forms.NumericUpDown RadiusVal;
        private System.Windows.Forms.Label LabelR;
        private System.Windows.Forms.NumericUpDown HeightVal;
        private System.Windows.Forms.Label LabelH;
        private System.Windows.Forms.Label VolumeValue;
        private System.Windows.Forms.Label AreaValue;
        private System.Windows.Forms.Label VolumeLabel;
        private System.Windows.Forms.Label AreaLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BrowseBtn;
        private System.Windows.Forms.TextBox SelectedFileName;
        private System.Windows.Forms.TextBox SelectedFilePath;
        private System.Windows.Forms.FolderBrowserDialog BrowseFolderDialog;
        private System.Windows.Forms.Label PerimeterValue;
        private System.Windows.Forms.Label PerimeterLabel;
    }
}

