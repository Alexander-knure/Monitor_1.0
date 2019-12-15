namespace Course_v1
{
    partial class ThresholdForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThresholdForm));
            this.btSCPU = new MetroFramework.Controls.MetroButton();
            this.btSRAM = new MetroFramework.Controls.MetroButton();
            this.btSMOBO = new MetroFramework.Controls.MetroButton();
            this.btSTCPU = new MetroFramework.Controls.MetroButton();
            this.btSVOLTAGE = new MetroFramework.Controls.MetroButton();
            this.tbCPU = new MetroFramework.Controls.MetroTextBox();
            this.tbRAM = new MetroFramework.Controls.MetroTextBox();
            this.tbTMOBO = new MetroFramework.Controls.MetroTextBox();
            this.tbTCPU = new MetroFramework.Controls.MetroTextBox();
            this.tbVOLTAGE = new MetroFramework.Controls.MetroTextBox();
            this.rbtA_CPU = new MetroFramework.Controls.MetroRadioButton();
            this.rbtP_CPU = new MetroFramework.Controls.MetroRadioButton();
            this.rbtP_RAM = new MetroFramework.Controls.MetroRadioButton();
            this.rbtA_RAM = new MetroFramework.Controls.MetroRadioButton();
            this.rbtP_TCPU = new MetroFramework.Controls.MetroRadioButton();
            this.rbtA_TCPU = new MetroFramework.Controls.MetroRadioButton();
            this.rbtP_TMOBO = new MetroFramework.Controls.MetroRadioButton();
            this.rbtA_TMOBO = new MetroFramework.Controls.MetroRadioButton();
            this.rbtP_VOLTAGE = new MetroFramework.Controls.MetroRadioButton();
            this.rbtA_VOLTAGE = new MetroFramework.Controls.MetroRadioButton();
            this.SuspendLayout();
            // 
            // btSCPU
            // 
            this.btSCPU.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btSCPU.ForeColor = System.Drawing.Color.White;
            this.btSCPU.Location = new System.Drawing.Point(515, 80);
            this.btSCPU.Name = "btSCPU";
            this.btSCPU.Size = new System.Drawing.Size(180, 100);
            this.btSCPU.Style = MetroFramework.MetroColorStyle.Black;
            this.btSCPU.TabIndex = 25;
            this.btSCPU.Text = "Set CPU load";
            this.btSCPU.UseCustomBackColor = true;
            this.btSCPU.UseCustomForeColor = true;
            this.btSCPU.UseSelectable = true;
            this.btSCPU.UseStyleColors = true;
            this.btSCPU.Click += new System.EventHandler(this.btSCPU_Click);
            // 
            // btSRAM
            // 
            this.btSRAM.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btSRAM.ForeColor = System.Drawing.Color.White;
            this.btSRAM.Location = new System.Drawing.Point(515, 180);
            this.btSRAM.Name = "btSRAM";
            this.btSRAM.Size = new System.Drawing.Size(180, 100);
            this.btSRAM.Style = MetroFramework.MetroColorStyle.Black;
            this.btSRAM.TabIndex = 26;
            this.btSRAM.Text = "Set RAM load";
            this.btSRAM.UseCustomBackColor = true;
            this.btSRAM.UseCustomForeColor = true;
            this.btSRAM.UseSelectable = true;
            this.btSRAM.UseStyleColors = true;
            this.btSRAM.Click += new System.EventHandler(this.btSRAM_Click);
            // 
            // btSMOBO
            // 
            this.btSMOBO.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btSMOBO.ForeColor = System.Drawing.Color.White;
            this.btSMOBO.Location = new System.Drawing.Point(515, 380);
            this.btSMOBO.Name = "btSMOBO";
            this.btSMOBO.Size = new System.Drawing.Size(180, 100);
            this.btSMOBO.Style = MetroFramework.MetroColorStyle.Black;
            this.btSMOBO.TabIndex = 28;
            this.btSMOBO.Text = "Set motherboard\r\ntemperature\r\n";
            this.btSMOBO.UseCustomBackColor = true;
            this.btSMOBO.UseCustomForeColor = true;
            this.btSMOBO.UseSelectable = true;
            this.btSMOBO.UseStyleColors = true;
            this.btSMOBO.Click += new System.EventHandler(this.btSMOBO_Click);
            // 
            // btSTCPU
            // 
            this.btSTCPU.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btSTCPU.ForeColor = System.Drawing.Color.White;
            this.btSTCPU.Location = new System.Drawing.Point(515, 280);
            this.btSTCPU.Name = "btSTCPU";
            this.btSTCPU.Size = new System.Drawing.Size(180, 100);
            this.btSTCPU.Style = MetroFramework.MetroColorStyle.Black;
            this.btSTCPU.TabIndex = 27;
            this.btSTCPU.Text = "Set CPU\r\nTemperature\r\n";
            this.btSTCPU.UseCustomBackColor = true;
            this.btSTCPU.UseCustomForeColor = true;
            this.btSTCPU.UseSelectable = true;
            this.btSTCPU.UseStyleColors = true;
            this.btSTCPU.Click += new System.EventHandler(this.btSTCPU_Click);
            // 
            // btSVOLTAGE
            // 
            this.btSVOLTAGE.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btSVOLTAGE.ForeColor = System.Drawing.Color.White;
            this.btSVOLTAGE.Location = new System.Drawing.Point(515, 480);
            this.btSVOLTAGE.Name = "btSVOLTAGE";
            this.btSVOLTAGE.Size = new System.Drawing.Size(180, 100);
            this.btSVOLTAGE.Style = MetroFramework.MetroColorStyle.Black;
            this.btSVOLTAGE.TabIndex = 29;
            this.btSVOLTAGE.Text = "Set voltage\r\n";
            this.btSVOLTAGE.UseCustomBackColor = true;
            this.btSVOLTAGE.UseCustomForeColor = true;
            this.btSVOLTAGE.UseSelectable = true;
            this.btSVOLTAGE.UseStyleColors = true;
            this.btSVOLTAGE.Click += new System.EventHandler(this.btSVOLTAGE_Click);
            // 
            // tbCPU
            // 
            this.tbCPU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            // 
            // 
            // 
            this.tbCPU.CustomButton.Image = null;
            this.tbCPU.CustomButton.Location = new System.Drawing.Point(222, 2);
            this.tbCPU.CustomButton.Name = "";
            this.tbCPU.CustomButton.Size = new System.Drawing.Size(95, 95);
            this.tbCPU.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbCPU.CustomButton.TabIndex = 1;
            this.tbCPU.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbCPU.CustomButton.UseSelectable = true;
            this.tbCPU.CustomButton.Visible = false;
            this.tbCPU.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tbCPU.ForeColor = System.Drawing.Color.White;
            this.tbCPU.Lines = new string[0];
            this.tbCPU.Location = new System.Drawing.Point(192, 83);
            this.tbCPU.MaxLength = 32767;
            this.tbCPU.Name = "tbCPU";
            this.tbCPU.PasswordChar = '\0';
            this.tbCPU.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbCPU.SelectedText = "";
            this.tbCPU.SelectionLength = 0;
            this.tbCPU.SelectionStart = 0;
            this.tbCPU.ShortcutsEnabled = true;
            this.tbCPU.Size = new System.Drawing.Size(320, 100);
            this.tbCPU.Style = MetroFramework.MetroColorStyle.Black;
            this.tbCPU.TabIndex = 31;
            this.tbCPU.UseCustomBackColor = true;
            this.tbCPU.UseCustomForeColor = true;
            this.tbCPU.UseSelectable = true;
            this.tbCPU.UseStyleColors = true;
            this.tbCPU.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbCPU.WaterMarkFont = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // tbRAM
            // 
            this.tbRAM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            // 
            // 
            // 
            this.tbRAM.CustomButton.Image = null;
            this.tbRAM.CustomButton.Location = new System.Drawing.Point(222, 2);
            this.tbRAM.CustomButton.Name = "";
            this.tbRAM.CustomButton.Size = new System.Drawing.Size(95, 95);
            this.tbRAM.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbRAM.CustomButton.TabIndex = 1;
            this.tbRAM.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbRAM.CustomButton.UseSelectable = true;
            this.tbRAM.CustomButton.Visible = false;
            this.tbRAM.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tbRAM.ForeColor = System.Drawing.Color.White;
            this.tbRAM.Lines = new string[0];
            this.tbRAM.Location = new System.Drawing.Point(192, 183);
            this.tbRAM.MaxLength = 32767;
            this.tbRAM.Name = "tbRAM";
            this.tbRAM.PasswordChar = '\0';
            this.tbRAM.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbRAM.SelectedText = "";
            this.tbRAM.SelectionLength = 0;
            this.tbRAM.SelectionStart = 0;
            this.tbRAM.ShortcutsEnabled = true;
            this.tbRAM.Size = new System.Drawing.Size(320, 100);
            this.tbRAM.Style = MetroFramework.MetroColorStyle.Black;
            this.tbRAM.TabIndex = 33;
            this.tbRAM.UseCustomBackColor = true;
            this.tbRAM.UseCustomForeColor = true;
            this.tbRAM.UseSelectable = true;
            this.tbRAM.UseStyleColors = true;
            this.tbRAM.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbRAM.WaterMarkFont = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // tbTMOBO
            // 
            this.tbTMOBO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            // 
            // 
            // 
            this.tbTMOBO.CustomButton.Image = null;
            this.tbTMOBO.CustomButton.Location = new System.Drawing.Point(222, 2);
            this.tbTMOBO.CustomButton.Name = "";
            this.tbTMOBO.CustomButton.Size = new System.Drawing.Size(95, 95);
            this.tbTMOBO.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbTMOBO.CustomButton.TabIndex = 1;
            this.tbTMOBO.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbTMOBO.CustomButton.UseSelectable = true;
            this.tbTMOBO.CustomButton.Visible = false;
            this.tbTMOBO.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tbTMOBO.ForeColor = System.Drawing.Color.White;
            this.tbTMOBO.Lines = new string[0];
            this.tbTMOBO.Location = new System.Drawing.Point(192, 383);
            this.tbTMOBO.MaxLength = 32767;
            this.tbTMOBO.Name = "tbTMOBO";
            this.tbTMOBO.PasswordChar = '\0';
            this.tbTMOBO.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbTMOBO.SelectedText = "";
            this.tbTMOBO.SelectionLength = 0;
            this.tbTMOBO.SelectionStart = 0;
            this.tbTMOBO.ShortcutsEnabled = true;
            this.tbTMOBO.Size = new System.Drawing.Size(320, 100);
            this.tbTMOBO.Style = MetroFramework.MetroColorStyle.Black;
            this.tbTMOBO.TabIndex = 35;
            this.tbTMOBO.UseCustomBackColor = true;
            this.tbTMOBO.UseCustomForeColor = true;
            this.tbTMOBO.UseSelectable = true;
            this.tbTMOBO.UseStyleColors = true;
            this.tbTMOBO.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbTMOBO.WaterMarkFont = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // tbTCPU
            // 
            this.tbTCPU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            // 
            // 
            // 
            this.tbTCPU.CustomButton.Image = null;
            this.tbTCPU.CustomButton.Location = new System.Drawing.Point(222, 2);
            this.tbTCPU.CustomButton.Name = "";
            this.tbTCPU.CustomButton.Size = new System.Drawing.Size(95, 95);
            this.tbTCPU.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbTCPU.CustomButton.TabIndex = 1;
            this.tbTCPU.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbTCPU.CustomButton.UseSelectable = true;
            this.tbTCPU.CustomButton.Visible = false;
            this.tbTCPU.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tbTCPU.ForeColor = System.Drawing.Color.White;
            this.tbTCPU.Lines = new string[0];
            this.tbTCPU.Location = new System.Drawing.Point(192, 283);
            this.tbTCPU.MaxLength = 32767;
            this.tbTCPU.Name = "tbTCPU";
            this.tbTCPU.PasswordChar = '\0';
            this.tbTCPU.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbTCPU.SelectedText = "";
            this.tbTCPU.SelectionLength = 0;
            this.tbTCPU.SelectionStart = 0;
            this.tbTCPU.ShortcutsEnabled = true;
            this.tbTCPU.Size = new System.Drawing.Size(320, 100);
            this.tbTCPU.Style = MetroFramework.MetroColorStyle.Black;
            this.tbTCPU.TabIndex = 34;
            this.tbTCPU.UseCustomBackColor = true;
            this.tbTCPU.UseCustomForeColor = true;
            this.tbTCPU.UseSelectable = true;
            this.tbTCPU.UseStyleColors = true;
            this.tbTCPU.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbTCPU.WaterMarkFont = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // tbVOLTAGE
            // 
            this.tbVOLTAGE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            // 
            // 
            // 
            this.tbVOLTAGE.CustomButton.Image = null;
            this.tbVOLTAGE.CustomButton.Location = new System.Drawing.Point(222, 2);
            this.tbVOLTAGE.CustomButton.Name = "";
            this.tbVOLTAGE.CustomButton.Size = new System.Drawing.Size(95, 95);
            this.tbVOLTAGE.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbVOLTAGE.CustomButton.TabIndex = 1;
            this.tbVOLTAGE.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbVOLTAGE.CustomButton.UseSelectable = true;
            this.tbVOLTAGE.CustomButton.Visible = false;
            this.tbVOLTAGE.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tbVOLTAGE.ForeColor = System.Drawing.Color.White;
            this.tbVOLTAGE.Lines = new string[0];
            this.tbVOLTAGE.Location = new System.Drawing.Point(192, 483);
            this.tbVOLTAGE.MaxLength = 32767;
            this.tbVOLTAGE.Name = "tbVOLTAGE";
            this.tbVOLTAGE.PasswordChar = '\0';
            this.tbVOLTAGE.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbVOLTAGE.SelectedText = "";
            this.tbVOLTAGE.SelectionLength = 0;
            this.tbVOLTAGE.SelectionStart = 0;
            this.tbVOLTAGE.ShortcutsEnabled = true;
            this.tbVOLTAGE.Size = new System.Drawing.Size(320, 100);
            this.tbVOLTAGE.Style = MetroFramework.MetroColorStyle.Black;
            this.tbVOLTAGE.TabIndex = 36;
            this.tbVOLTAGE.UseCustomBackColor = true;
            this.tbVOLTAGE.UseCustomForeColor = true;
            this.tbVOLTAGE.UseSelectable = true;
            this.tbVOLTAGE.UseStyleColors = true;
            this.tbVOLTAGE.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbVOLTAGE.WaterMarkFont = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // rbtA_CPU
            // 
            this.rbtA_CPU.AutoSize = true;
            this.rbtA_CPU.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rbtA_CPU.ForeColor = System.Drawing.Color.White;
            this.rbtA_CPU.Location = new System.Drawing.Point(24, 83);
            this.rbtA_CPU.Name = "rbtA_CPU";
            this.rbtA_CPU.Size = new System.Drawing.Size(79, 19);
            this.rbtA_CPU.Style = MetroFramework.MetroColorStyle.Black;
            this.rbtA_CPU.TabIndex = 37;
            this.rbtA_CPU.Text = "Absolute";
            this.rbtA_CPU.UseCustomBackColor = true;
            this.rbtA_CPU.UseCustomForeColor = true;
            this.rbtA_CPU.UseSelectable = true;
            this.rbtA_CPU.UseStyleColors = true;
            this.rbtA_CPU.CheckedChanged += new System.EventHandler(this.rbtA_CPU_CheckedChanged);
            // 
            // rbtP_CPU
            // 
            this.rbtP_CPU.AutoSize = true;
            this.rbtP_CPU.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rbtP_CPU.ForeColor = System.Drawing.Color.White;
            this.rbtP_CPU.Location = new System.Drawing.Point(24, 133);
            this.rbtP_CPU.Name = "rbtP_CPU";
            this.rbtP_CPU.Size = new System.Drawing.Size(92, 19);
            this.rbtP_CPU.Style = MetroFramework.MetroColorStyle.Black;
            this.rbtP_CPU.TabIndex = 38;
            this.rbtP_CPU.Text = "Percentage";
            this.rbtP_CPU.UseCustomBackColor = true;
            this.rbtP_CPU.UseCustomForeColor = true;
            this.rbtP_CPU.UseSelectable = true;
            this.rbtP_CPU.UseStyleColors = true;
            this.rbtP_CPU.CheckedChanged += new System.EventHandler(this.rbtP_CPU_CheckedChanged);
            // 
            // rbtP_RAM
            // 
            this.rbtP_RAM.AutoSize = true;
            this.rbtP_RAM.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rbtP_RAM.ForeColor = System.Drawing.Color.White;
            this.rbtP_RAM.Location = new System.Drawing.Point(24, 233);
            this.rbtP_RAM.Name = "rbtP_RAM";
            this.rbtP_RAM.Size = new System.Drawing.Size(92, 19);
            this.rbtP_RAM.Style = MetroFramework.MetroColorStyle.Black;
            this.rbtP_RAM.TabIndex = 40;
            this.rbtP_RAM.Text = "Percentage";
            this.rbtP_RAM.UseCustomBackColor = true;
            this.rbtP_RAM.UseCustomForeColor = true;
            this.rbtP_RAM.UseSelectable = true;
            this.rbtP_RAM.UseStyleColors = true;
            this.rbtP_RAM.CheckedChanged += new System.EventHandler(this.rbtP_RAM_CheckedChanged);
            // 
            // rbtA_RAM
            // 
            this.rbtA_RAM.AutoSize = true;
            this.rbtA_RAM.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rbtA_RAM.ForeColor = System.Drawing.Color.White;
            this.rbtA_RAM.Location = new System.Drawing.Point(24, 183);
            this.rbtA_RAM.Name = "rbtA_RAM";
            this.rbtA_RAM.Size = new System.Drawing.Size(79, 19);
            this.rbtA_RAM.Style = MetroFramework.MetroColorStyle.Black;
            this.rbtA_RAM.TabIndex = 39;
            this.rbtA_RAM.Text = "Absolute";
            this.rbtA_RAM.UseCustomBackColor = true;
            this.rbtA_RAM.UseCustomForeColor = true;
            this.rbtA_RAM.UseSelectable = true;
            this.rbtA_RAM.UseStyleColors = true;
            this.rbtA_RAM.CheckedChanged += new System.EventHandler(this.rbtA_RAM_CheckedChanged);
            // 
            // rbtP_TCPU
            // 
            this.rbtP_TCPU.AutoSize = true;
            this.rbtP_TCPU.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rbtP_TCPU.ForeColor = System.Drawing.Color.White;
            this.rbtP_TCPU.Location = new System.Drawing.Point(24, 333);
            this.rbtP_TCPU.Name = "rbtP_TCPU";
            this.rbtP_TCPU.Size = new System.Drawing.Size(92, 19);
            this.rbtP_TCPU.Style = MetroFramework.MetroColorStyle.Black;
            this.rbtP_TCPU.TabIndex = 42;
            this.rbtP_TCPU.Text = "Percentage";
            this.rbtP_TCPU.UseCustomBackColor = true;
            this.rbtP_TCPU.UseCustomForeColor = true;
            this.rbtP_TCPU.UseSelectable = true;
            this.rbtP_TCPU.UseStyleColors = true;
            this.rbtP_TCPU.CheckedChanged += new System.EventHandler(this.rbtP_TCPU_CheckedChanged);
            // 
            // rbtA_TCPU
            // 
            this.rbtA_TCPU.AutoSize = true;
            this.rbtA_TCPU.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rbtA_TCPU.ForeColor = System.Drawing.Color.White;
            this.rbtA_TCPU.Location = new System.Drawing.Point(24, 283);
            this.rbtA_TCPU.Name = "rbtA_TCPU";
            this.rbtA_TCPU.Size = new System.Drawing.Size(79, 19);
            this.rbtA_TCPU.Style = MetroFramework.MetroColorStyle.Black;
            this.rbtA_TCPU.TabIndex = 41;
            this.rbtA_TCPU.Text = "Absolute";
            this.rbtA_TCPU.UseCustomBackColor = true;
            this.rbtA_TCPU.UseCustomForeColor = true;
            this.rbtA_TCPU.UseSelectable = true;
            this.rbtA_TCPU.UseStyleColors = true;
            this.rbtA_TCPU.CheckedChanged += new System.EventHandler(this.rbtA_TCPU_CheckedChanged);
            // 
            // rbtP_TMOBO
            // 
            this.rbtP_TMOBO.AutoSize = true;
            this.rbtP_TMOBO.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rbtP_TMOBO.ForeColor = System.Drawing.Color.White;
            this.rbtP_TMOBO.Location = new System.Drawing.Point(24, 433);
            this.rbtP_TMOBO.Name = "rbtP_TMOBO";
            this.rbtP_TMOBO.Size = new System.Drawing.Size(92, 19);
            this.rbtP_TMOBO.Style = MetroFramework.MetroColorStyle.Black;
            this.rbtP_TMOBO.TabIndex = 44;
            this.rbtP_TMOBO.Text = "Percentage";
            this.rbtP_TMOBO.UseCustomBackColor = true;
            this.rbtP_TMOBO.UseCustomForeColor = true;
            this.rbtP_TMOBO.UseSelectable = true;
            this.rbtP_TMOBO.UseStyleColors = true;
            this.rbtP_TMOBO.CheckedChanged += new System.EventHandler(this.rbtP_TMOBO_CheckedChanged);
            // 
            // rbtA_TMOBO
            // 
            this.rbtA_TMOBO.AutoSize = true;
            this.rbtA_TMOBO.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rbtA_TMOBO.ForeColor = System.Drawing.Color.White;
            this.rbtA_TMOBO.Location = new System.Drawing.Point(24, 383);
            this.rbtA_TMOBO.Name = "rbtA_TMOBO";
            this.rbtA_TMOBO.Size = new System.Drawing.Size(79, 19);
            this.rbtA_TMOBO.Style = MetroFramework.MetroColorStyle.Black;
            this.rbtA_TMOBO.TabIndex = 43;
            this.rbtA_TMOBO.Text = "Absolute";
            this.rbtA_TMOBO.UseCustomBackColor = true;
            this.rbtA_TMOBO.UseCustomForeColor = true;
            this.rbtA_TMOBO.UseSelectable = true;
            this.rbtA_TMOBO.UseStyleColors = true;
            this.rbtA_TMOBO.CheckedChanged += new System.EventHandler(this.rbtA_TMOBO_CheckedChanged);
            // 
            // rbtP_VOLTAGE
            // 
            this.rbtP_VOLTAGE.AutoSize = true;
            this.rbtP_VOLTAGE.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rbtP_VOLTAGE.ForeColor = System.Drawing.Color.White;
            this.rbtP_VOLTAGE.Location = new System.Drawing.Point(24, 533);
            this.rbtP_VOLTAGE.Name = "rbtP_VOLTAGE";
            this.rbtP_VOLTAGE.Size = new System.Drawing.Size(92, 19);
            this.rbtP_VOLTAGE.Style = MetroFramework.MetroColorStyle.Black;
            this.rbtP_VOLTAGE.TabIndex = 46;
            this.rbtP_VOLTAGE.Text = "Percentage";
            this.rbtP_VOLTAGE.UseCustomBackColor = true;
            this.rbtP_VOLTAGE.UseCustomForeColor = true;
            this.rbtP_VOLTAGE.UseSelectable = true;
            this.rbtP_VOLTAGE.UseStyleColors = true;
            this.rbtP_VOLTAGE.CheckedChanged += new System.EventHandler(this.rbtP_VOLTAGE_CheckedChanged);
            // 
            // rbtA_VOLTAGE
            // 
            this.rbtA_VOLTAGE.AutoSize = true;
            this.rbtA_VOLTAGE.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rbtA_VOLTAGE.ForeColor = System.Drawing.Color.White;
            this.rbtA_VOLTAGE.Location = new System.Drawing.Point(24, 483);
            this.rbtA_VOLTAGE.Name = "rbtA_VOLTAGE";
            this.rbtA_VOLTAGE.Size = new System.Drawing.Size(79, 19);
            this.rbtA_VOLTAGE.Style = MetroFramework.MetroColorStyle.Black;
            this.rbtA_VOLTAGE.TabIndex = 45;
            this.rbtA_VOLTAGE.Text = "Absolute";
            this.rbtA_VOLTAGE.UseCustomBackColor = true;
            this.rbtA_VOLTAGE.UseCustomForeColor = true;
            this.rbtA_VOLTAGE.UseSelectable = true;
            this.rbtA_VOLTAGE.UseStyleColors = true;
            this.rbtA_VOLTAGE.CheckedChanged += new System.EventHandler(this.rbtA_VOLTAGE_CheckedChanged);
            // 
            // ThresholdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 595);
            this.Controls.Add(this.rbtP_VOLTAGE);
            this.Controls.Add(this.rbtA_VOLTAGE);
            this.Controls.Add(this.rbtP_TMOBO);
            this.Controls.Add(this.rbtA_TMOBO);
            this.Controls.Add(this.rbtP_TCPU);
            this.Controls.Add(this.rbtA_TCPU);
            this.Controls.Add(this.rbtP_RAM);
            this.Controls.Add(this.rbtA_RAM);
            this.Controls.Add(this.rbtP_CPU);
            this.Controls.Add(this.rbtA_CPU);
            this.Controls.Add(this.tbVOLTAGE);
            this.Controls.Add(this.tbTMOBO);
            this.Controls.Add(this.tbTCPU);
            this.Controls.Add(this.tbRAM);
            this.Controls.Add(this.tbCPU);
            this.Controls.Add(this.btSVOLTAGE);
            this.Controls.Add(this.btSMOBO);
            this.Controls.Add(this.btSTCPU);
            this.Controls.Add(this.btSRAM);
            this.Controls.Add(this.btSCPU);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ThresholdForm";
            this.Resizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "Threshold";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Threshold_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btSCPU;
        private MetroFramework.Controls.MetroButton btSRAM;
        private MetroFramework.Controls.MetroButton btSMOBO;
        private MetroFramework.Controls.MetroButton btSTCPU;
        private MetroFramework.Controls.MetroButton btSVOLTAGE;
        private MetroFramework.Controls.MetroTextBox tbCPU;
        private MetroFramework.Controls.MetroTextBox tbRAM;
        private MetroFramework.Controls.MetroTextBox tbTMOBO;
        private MetroFramework.Controls.MetroTextBox tbTCPU;
        private MetroFramework.Controls.MetroTextBox tbVOLTAGE;
        private MetroFramework.Controls.MetroRadioButton rbtA_CPU;
        private MetroFramework.Controls.MetroRadioButton rbtP_CPU;
        private MetroFramework.Controls.MetroRadioButton rbtP_RAM;
        private MetroFramework.Controls.MetroRadioButton rbtA_RAM;
        private MetroFramework.Controls.MetroRadioButton rbtP_TCPU;
        private MetroFramework.Controls.MetroRadioButton rbtA_TCPU;
        private MetroFramework.Controls.MetroRadioButton rbtP_TMOBO;
        private MetroFramework.Controls.MetroRadioButton rbtA_TMOBO;
        private MetroFramework.Controls.MetroRadioButton rbtP_VOLTAGE;
        private MetroFramework.Controls.MetroRadioButton rbtA_VOLTAGE;
    }
}