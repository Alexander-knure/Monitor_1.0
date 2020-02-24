namespace Course_v1
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.cCPU = new System.Diagnostics.PerformanceCounter();
            this.cRAM = new System.Diagnostics.PerformanceCounter();
            this.cTimer = new System.Windows.Forms.Timer(this.components);
            this.pbCPU = new MetroFramework.Controls.MetroProgressBar();
            this.lbCPU = new MetroFramework.Controls.MetroLabel();
            this.pbRAM = new MetroFramework.Controls.MetroProgressBar();
            this.pbTempMOBO = new MetroFramework.Controls.MetroProgressBar();
            this.pbTempCPU = new MetroFramework.Controls.MetroProgressBar();
            this.pbVoltage = new MetroFramework.Controls.MetroProgressBar();
            this.lbTempMOBO = new MetroFramework.Controls.MetroLabel();
            this.lbTempCPU = new MetroFramework.Controls.MetroLabel();
            this.lbRAM = new MetroFramework.Controls.MetroLabel();
            this.lbVoltage = new MetroFramework.Controls.MetroLabel();
            this.lbPCPU = new MetroFramework.Controls.MetroLabel();
            this.lbPRAM = new MetroFramework.Controls.MetroLabel();
            this.lbPTempMOBO = new MetroFramework.Controls.MetroLabel();
            this.lbPTempCPU = new MetroFramework.Controls.MetroLabel();
            this.lbPVoltage = new MetroFramework.Controls.MetroLabel();
            this.MainChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.сTCPU = new System.Diagnostics.PerformanceCounter();
            this.btMoreInfo = new MetroFramework.Controls.MetroButton();
            this.btSave = new MetroFramework.Controls.MetroButton();
            this.btSetThreshold = new MetroFramework.Controls.MetroButton();
            this.btTimer = new MetroFramework.Controls.MetroButton();
            this.cVOLTAGE = new System.Diagnostics.PerformanceCounter();
            this.lbThreshold = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.cCPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRAM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сTCPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cVOLTAGE)).BeginInit();
            this.SuspendLayout();
            // 
            // cCPU
            // 
            this.cCPU.CategoryName = "Процессор";
            this.cCPU.CounterName = "% загруженности процессора";
            this.cCPU.InstanceName = "_Total";
            // 
            // cRAM
            // 
            this.cRAM.CategoryName = "Память";
            this.cRAM.CounterName = "% использования выделенной памяти";
            // 
            // cTimer
            // 
            this.cTimer.Enabled = true;
            this.cTimer.Interval = 500;
            this.cTimer.Tick += new System.EventHandler(this.cTimer_Tick);
            // 
            // pbCPU
            // 
            this.pbCPU.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline;
            this.pbCPU.Location = new System.Drawing.Point(265, 90);
            this.pbCPU.Name = "pbCPU";
            this.pbCPU.Size = new System.Drawing.Size(350, 20);
            this.pbCPU.Style = MetroFramework.MetroColorStyle.Black;
            this.pbCPU.TabIndex = 2;
            this.pbCPU.Theme = MetroFramework.MetroThemeStyle.Light;
            this.pbCPU.UseCustomBackColor = true;
            // 
            // lbCPU
            // 
            this.lbCPU.AutoSize = true;
            this.lbCPU.BackColor = System.Drawing.Color.Black;
            this.lbCPU.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbCPU.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbCPU.ForeColor = System.Drawing.Color.White;
            this.lbCPU.Location = new System.Drawing.Point(23, 90);
            this.lbCPU.Name = "lbCPU";
            this.lbCPU.Size = new System.Drawing.Size(94, 25);
            this.lbCPU.TabIndex = 3;
            this.lbCPU.Text = "CPU load";
            this.lbCPU.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lbCPU.UseCustomForeColor = true;
            // 
            // pbRAM
            // 
            this.pbRAM.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline;
            this.pbRAM.Location = new System.Drawing.Point(265, 120);
            this.pbRAM.Name = "pbRAM";
            this.pbRAM.Size = new System.Drawing.Size(350, 20);
            this.pbRAM.Style = MetroFramework.MetroColorStyle.Black;
            this.pbRAM.TabIndex = 4;
            this.pbRAM.Theme = MetroFramework.MetroThemeStyle.Light;
            this.pbRAM.UseCustomBackColor = true;
            // 
            // pbTempMOBO
            // 
            this.pbTempMOBO.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline;
            this.pbTempMOBO.Location = new System.Drawing.Point(265, 179);
            this.pbTempMOBO.Name = "pbTempMOBO";
            this.pbTempMOBO.Size = new System.Drawing.Size(350, 20);
            this.pbTempMOBO.Style = MetroFramework.MetroColorStyle.Black;
            this.pbTempMOBO.TabIndex = 8;
            this.pbTempMOBO.Theme = MetroFramework.MetroThemeStyle.Light;
            this.pbTempMOBO.UseCustomBackColor = true;
            // 
            // pbTempCPU
            // 
            this.pbTempCPU.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline;
            this.pbTempCPU.Location = new System.Drawing.Point(265, 149);
            this.pbTempCPU.Name = "pbTempCPU";
            this.pbTempCPU.Size = new System.Drawing.Size(350, 20);
            this.pbTempCPU.Style = MetroFramework.MetroColorStyle.Black;
            this.pbTempCPU.TabIndex = 6;
            this.pbTempCPU.Theme = MetroFramework.MetroThemeStyle.Light;
            this.pbTempCPU.UseCustomBackColor = true;
            // 
            // pbVoltage
            // 
            this.pbVoltage.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline;
            this.pbVoltage.Location = new System.Drawing.Point(265, 208);
            this.pbVoltage.Name = "pbVoltage";
            this.pbVoltage.Size = new System.Drawing.Size(350, 20);
            this.pbVoltage.Style = MetroFramework.MetroColorStyle.Black;
            this.pbVoltage.TabIndex = 10;
            this.pbVoltage.Theme = MetroFramework.MetroThemeStyle.Light;
            this.pbVoltage.UseCustomBackColor = true;
            // 
            // lbTempMOBO
            // 
            this.lbTempMOBO.AutoSize = true;
            this.lbTempMOBO.BackColor = System.Drawing.Color.Black;
            this.lbTempMOBO.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbTempMOBO.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbTempMOBO.ForeColor = System.Drawing.Color.White;
            this.lbTempMOBO.Location = new System.Drawing.Point(23, 179);
            this.lbTempMOBO.Name = "lbTempMOBO";
            this.lbTempMOBO.Size = new System.Drawing.Size(248, 25);
            this.lbTempMOBO.TabIndex = 12;
            this.lbTempMOBO.Text = "Motherboard temperature";
            this.lbTempMOBO.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lbTempMOBO.UseCustomForeColor = true;
            // 
            // lbTempCPU
            // 
            this.lbTempCPU.AutoSize = true;
            this.lbTempCPU.BackColor = System.Drawing.Color.Black;
            this.lbTempCPU.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbTempCPU.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbTempCPU.ForeColor = System.Drawing.Color.White;
            this.lbTempCPU.Location = new System.Drawing.Point(23, 149);
            this.lbTempCPU.Name = "lbTempCPU";
            this.lbTempCPU.Size = new System.Drawing.Size(166, 25);
            this.lbTempCPU.TabIndex = 13;
            this.lbTempCPU.Text = "CPU temperature";
            this.lbTempCPU.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lbTempCPU.UseCustomForeColor = true;
            // 
            // lbRAM
            // 
            this.lbRAM.AutoSize = true;
            this.lbRAM.BackColor = System.Drawing.Color.Black;
            this.lbRAM.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbRAM.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbRAM.ForeColor = System.Drawing.Color.White;
            this.lbRAM.Location = new System.Drawing.Point(23, 120);
            this.lbRAM.Name = "lbRAM";
            this.lbRAM.Size = new System.Drawing.Size(99, 25);
            this.lbRAM.TabIndex = 14;
            this.lbRAM.Text = "RAM load";
            this.lbRAM.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lbRAM.UseCustomForeColor = true;
            // 
            // lbVoltage
            // 
            this.lbVoltage.AutoSize = true;
            this.lbVoltage.BackColor = System.Drawing.Color.Black;
            this.lbVoltage.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbVoltage.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbVoltage.ForeColor = System.Drawing.Color.White;
            this.lbVoltage.Location = new System.Drawing.Point(23, 208);
            this.lbVoltage.Name = "lbVoltage";
            this.lbVoltage.Size = new System.Drawing.Size(80, 25);
            this.lbVoltage.TabIndex = 15;
            this.lbVoltage.Text = "Voltage";
            this.lbVoltage.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lbVoltage.UseCustomForeColor = true;
            // 
            // lbPCPU
            // 
            this.lbPCPU.AutoSize = true;
            this.lbPCPU.BackColor = System.Drawing.Color.Black;
            this.lbPCPU.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbPCPU.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbPCPU.ForeColor = System.Drawing.Color.White;
            this.lbPCPU.Location = new System.Drawing.Point(622, 90);
            this.lbPCPU.Name = "lbPCPU";
            this.lbPCPU.Size = new System.Drawing.Size(66, 25);
            this.lbPCPU.TabIndex = 16;
            this.lbPCPU.Text = "0.00%";
            this.lbPCPU.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lbPCPU.UseCustomForeColor = true;
            // 
            // lbPRAM
            // 
            this.lbPRAM.AutoSize = true;
            this.lbPRAM.BackColor = System.Drawing.Color.Black;
            this.lbPRAM.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbPRAM.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbPRAM.ForeColor = System.Drawing.Color.White;
            this.lbPRAM.Location = new System.Drawing.Point(622, 120);
            this.lbPRAM.Name = "lbPRAM";
            this.lbPRAM.Size = new System.Drawing.Size(66, 25);
            this.lbPRAM.TabIndex = 17;
            this.lbPRAM.Text = "0.00%";
            this.lbPRAM.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lbPRAM.UseCustomForeColor = true;
            // 
            // lbPTempMOBO
            // 
            this.lbPTempMOBO.AutoSize = true;
            this.lbPTempMOBO.BackColor = System.Drawing.Color.Black;
            this.lbPTempMOBO.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbPTempMOBO.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbPTempMOBO.ForeColor = System.Drawing.Color.White;
            this.lbPTempMOBO.Location = new System.Drawing.Point(622, 179);
            this.lbPTempMOBO.Name = "lbPTempMOBO";
            this.lbPTempMOBO.Size = new System.Drawing.Size(66, 25);
            this.lbPTempMOBO.TabIndex = 19;
            this.lbPTempMOBO.Text = "0.00%";
            this.lbPTempMOBO.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lbPTempMOBO.UseCustomForeColor = true;
            // 
            // lbPTempCPU
            // 
            this.lbPTempCPU.AutoSize = true;
            this.lbPTempCPU.BackColor = System.Drawing.Color.Black;
            this.lbPTempCPU.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbPTempCPU.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbPTempCPU.ForeColor = System.Drawing.Color.White;
            this.lbPTempCPU.Location = new System.Drawing.Point(622, 149);
            this.lbPTempCPU.Name = "lbPTempCPU";
            this.lbPTempCPU.Size = new System.Drawing.Size(66, 25);
            this.lbPTempCPU.TabIndex = 18;
            this.lbPTempCPU.Text = "0.00%";
            this.lbPTempCPU.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lbPTempCPU.UseCustomForeColor = true;
            // 
            // lbPVoltage
            // 
            this.lbPVoltage.AutoSize = true;
            this.lbPVoltage.BackColor = System.Drawing.Color.Black;
            this.lbPVoltage.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbPVoltage.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbPVoltage.ForeColor = System.Drawing.Color.White;
            this.lbPVoltage.Location = new System.Drawing.Point(622, 208);
            this.lbPVoltage.Name = "lbPVoltage";
            this.lbPVoltage.Size = new System.Drawing.Size(66, 25);
            this.lbPVoltage.TabIndex = 20;
            this.lbPVoltage.Text = "0.00%";
            this.lbPVoltage.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lbPVoltage.UseCustomForeColor = true;
            // 
            // MainChart
            // 
            this.MainChart.BackColor = System.Drawing.Color.Transparent;
            this.MainChart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MainChart.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Top;
            this.MainChart.BorderSkin.BackColor = System.Drawing.Color.Maroon;
            this.MainChart.BorderSkin.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.DiagonalBrick;
            this.MainChart.BorderSkin.BackSecondaryColor = System.Drawing.Color.Transparent;
            this.MainChart.BorderSkin.BorderColor = System.Drawing.Color.Transparent;
            this.MainChart.BorderSkin.PageColor = System.Drawing.Color.Transparent;
            chartArea1.Area3DStyle.Inclination = 10;
            chartArea1.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
            chartArea1.Area3DStyle.PointDepth = 40;
            chartArea1.Area3DStyle.Rotation = 10;
            chartArea1.Area3DStyle.WallWidth = 5;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Angle = 1;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisX.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MajorGrid.LineWidth = 0;
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea1.AxisX2.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisX2.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX2.TitleForeColor = System.Drawing.Color.White;
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisY.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.Maximum = 100D;
            chartArea1.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea1.AxisY2.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisY2.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY2.TitleForeColor = System.Drawing.Color.White;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BackImageTransparentColor = System.Drawing.Color.Transparent;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.BorderWidth = 0;
            chartArea1.InnerPlotPosition.Auto = false;
            chartArea1.InnerPlotPosition.Height = 90F;
            chartArea1.InnerPlotPosition.Width = 90F;
            chartArea1.InnerPlotPosition.X = 10F;
            chartArea1.InnerPlotPosition.Y = 4.49097F;
            chartArea1.Name = "ChartArea1";
            chartArea1.ShadowColor = System.Drawing.Color.DarkGray;
            this.MainChart.ChartAreas.Add(chartArea1);
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.BorderWidth = 5;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Font = new System.Drawing.Font("Consolas", 12F);
            legend1.ForeColor = System.Drawing.Color.White;
            legend1.HeaderSeparator = System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle.Line;
            legend1.HeaderSeparatorColor = System.Drawing.Color.White;
            legend1.IsTextAutoFit = false;
            legend1.ItemColumnSeparatorColor = System.Drawing.Color.White;
            legend1.MaximumAutoSize = 10F;
            legend1.Name = "Legend1";
            legend1.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            legend1.TitleForeColor = System.Drawing.Color.White;
            legend1.TitleSeparatorColor = System.Drawing.Color.White;
            this.MainChart.Legends.Add(legend1);
            this.MainChart.Location = new System.Drawing.Point(-23, 275);
            this.MainChart.Name = "MainChart";
            this.MainChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.MainChart.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Cyan,
        System.Drawing.Color.Lime,
        System.Drawing.Color.Red,
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0))))),
        System.Drawing.Color.Yellow};
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.Font = new System.Drawing.Font("Consolas", 20F);
            series1.LabelBackColor = System.Drawing.Color.Transparent;
            series1.LabelBorderColor = System.Drawing.Color.Transparent;
            series1.LabelForeColor = System.Drawing.Color.White;
            series1.Legend = "Legend1";
            series1.Name = "CPU";
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series2.Font = new System.Drawing.Font("Consolas", 8F);
            series2.LabelBorderWidth = 2;
            series2.LabelForeColor = System.Drawing.Color.White;
            series2.Legend = "Legend1";
            series2.Name = "RAM";
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series3.Font = new System.Drawing.Font("Consolas", 8F);
            series3.LabelBorderWidth = 2;
            series3.LabelForeColor = System.Drawing.Color.White;
            series3.Legend = "Legend1";
            series3.Name = "t CPU";
            series4.BorderWidth = 2;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series4.Font = new System.Drawing.Font("Consolas", 8F);
            series4.LabelBorderWidth = 2;
            series4.LabelForeColor = System.Drawing.Color.White;
            series4.Legend = "Legend1";
            series4.Name = "t motherboard";
            series5.BorderWidth = 2;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series5.Font = new System.Drawing.Font("Consolas", 8F);
            series5.LabelBorderWidth = 2;
            series5.LabelForeColor = System.Drawing.Color.White;
            series5.Legend = "Legend1";
            series5.Name = "Voltage";
            this.MainChart.Series.Add(series1);
            this.MainChart.Series.Add(series2);
            this.MainChart.Series.Add(series3);
            this.MainChart.Series.Add(series4);
            this.MainChart.Series.Add(series5);
            this.MainChart.Size = new System.Drawing.Size(720, 350);
            this.MainChart.TabIndex = 21;
            this.MainChart.Text = "MainChart";
            // 
            // сTCPU
            // 
            this.сTCPU.CategoryName = "Данные термальной зоны";
            this.сTCPU.CounterName = "Температура";
            this.сTCPU.InstanceName = "\\_TZ.THRM";
            // 
            // btMoreInfo
            // 
            this.btMoreInfo.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btMoreInfo.ForeColor = System.Drawing.Color.White;
            this.btMoreInfo.Location = new System.Drawing.Point(180, 650);
            this.btMoreInfo.Name = "btMoreInfo";
            this.btMoreInfo.Size = new System.Drawing.Size(180, 100);
            this.btMoreInfo.Style = MetroFramework.MetroColorStyle.Black;
            this.btMoreInfo.TabIndex = 23;
            this.btMoreInfo.Text = "More information";
            this.btMoreInfo.UseCustomBackColor = true;
            this.btMoreInfo.UseCustomForeColor = true;
            this.btMoreInfo.UseSelectable = true;
            this.btMoreInfo.UseStyleColors = true;
            this.btMoreInfo.Click += new System.EventHandler(this.btMoreInfo_Click);
            // 
            // btSave
            // 
            this.btSave.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btSave.ForeColor = System.Drawing.Color.White;
            this.btSave.Location = new System.Drawing.Point(360, 650);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(180, 100);
            this.btSave.Style = MetroFramework.MetroColorStyle.Black;
            this.btSave.TabIndex = 24;
            this.btSave.Text = "Save";
            this.btSave.UseCustomBackColor = true;
            this.btSave.UseCustomForeColor = true;
            this.btSave.UseSelectable = true;
            this.btSave.UseStyleColors = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btSetThreshold
            // 
            this.btSetThreshold.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btSetThreshold.ForeColor = System.Drawing.Color.White;
            this.btSetThreshold.Location = new System.Drawing.Point(0, 650);
            this.btSetThreshold.Name = "btSetThreshold";
            this.btSetThreshold.Size = new System.Drawing.Size(180, 100);
            this.btSetThreshold.Style = MetroFramework.MetroColorStyle.Black;
            this.btSetThreshold.TabIndex = 25;
            this.btSetThreshold.Text = "Set threshold";
            this.btSetThreshold.UseCustomBackColor = true;
            this.btSetThreshold.UseCustomForeColor = true;
            this.btSetThreshold.UseSelectable = true;
            this.btSetThreshold.UseStyleColors = true;
            this.btSetThreshold.Click += new System.EventHandler(this.btSetThreshold_Click);
            // 
            // btTimer
            // 
            this.btTimer.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btTimer.ForeColor = System.Drawing.Color.White;
            this.btTimer.Location = new System.Drawing.Point(540, 650);
            this.btTimer.Name = "btTimer";
            this.btTimer.Size = new System.Drawing.Size(180, 100);
            this.btTimer.Style = MetroFramework.MetroColorStyle.Black;
            this.btTimer.TabIndex = 26;
            this.btTimer.Text = "Stop ";
            this.btTimer.UseCustomBackColor = true;
            this.btTimer.UseCustomForeColor = true;
            this.btTimer.UseSelectable = true;
            this.btTimer.UseStyleColors = true;
            this.btTimer.Click += new System.EventHandler(this.btTimer_Click);
            // 
            // cVOLTAGE
            // 
            this.cVOLTAGE.CategoryName = "Индикатор питания";
            this.cVOLTAGE.CounterName = "Питание";
            this.cVOLTAGE.InstanceName = "_Total";
            // 
            // lbThreshold
            // 
            this.lbThreshold.AutoSize = true;
            this.lbThreshold.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.lbThreshold.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbThreshold.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbThreshold.ForeColor = System.Drawing.Color.White;
            this.lbThreshold.Location = new System.Drawing.Point(265, 20);
            this.lbThreshold.Name = "lbThreshold";
            this.lbThreshold.Size = new System.Drawing.Size(0, 0);
            this.lbThreshold.TabIndex = 27;
            this.lbThreshold.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lbThreshold.UseCustomForeColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 750);
            this.Controls.Add(this.lbThreshold);
            this.Controls.Add(this.btTimer);
            this.Controls.Add(this.btSetThreshold);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btMoreInfo);
            this.Controls.Add(this.MainChart);
            this.Controls.Add(this.lbPVoltage);
            this.Controls.Add(this.lbPTempMOBO);
            this.Controls.Add(this.lbPTempCPU);
            this.Controls.Add(this.lbPRAM);
            this.Controls.Add(this.lbPCPU);
            this.Controls.Add(this.lbVoltage);
            this.Controls.Add(this.lbRAM);
            this.Controls.Add(this.lbTempCPU);
            this.Controls.Add(this.lbTempMOBO);
            this.Controls.Add(this.pbVoltage);
            this.Controls.Add(this.pbTempMOBO);
            this.Controls.Add(this.pbTempCPU);
            this.Controls.Add(this.pbRAM);
            this.Controls.Add(this.lbCPU);
            this.Controls.Add(this.pbCPU);
            this.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(20, 60, 20, 19);
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "Monitor v1.0";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cCPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRAM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сTCPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cVOLTAGE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Diagnostics.PerformanceCounter cCPU;
        private System.Diagnostics.PerformanceCounter cRAM;
        private System.Windows.Forms.Timer cTimer;
        private MetroFramework.Controls.MetroProgressBar pbCPU;
        private MetroFramework.Controls.MetroLabel lbCPU;
        private MetroFramework.Controls.MetroProgressBar pbRAM;
        private MetroFramework.Controls.MetroProgressBar pbTempMOBO;
        private MetroFramework.Controls.MetroProgressBar pbTempCPU;
        private MetroFramework.Controls.MetroProgressBar pbVoltage;
        private MetroFramework.Controls.MetroLabel lbTempMOBO;
        private MetroFramework.Controls.MetroLabel lbTempCPU;
        private MetroFramework.Controls.MetroLabel lbRAM;
        private MetroFramework.Controls.MetroLabel lbVoltage;
        private MetroFramework.Controls.MetroLabel lbPCPU;
        private MetroFramework.Controls.MetroLabel lbPRAM;
        private MetroFramework.Controls.MetroLabel lbPTempMOBO;
        private MetroFramework.Controls.MetroLabel lbPTempCPU;
        private MetroFramework.Controls.MetroLabel lbPVoltage;
        private System.Windows.Forms.DataVisualization.Charting.Chart MainChart;
        private System.Diagnostics.PerformanceCounter сTCPU;
        private MetroFramework.Controls.MetroButton btMoreInfo;
        private MetroFramework.Controls.MetroButton btSave;
        private MetroFramework.Controls.MetroButton btSetThreshold;
        private MetroFramework.Controls.MetroButton btTimer;
        private System.Diagnostics.PerformanceCounter cVOLTAGE;
        private MetroFramework.Controls.MetroLabel lbThreshold;
    }
}

