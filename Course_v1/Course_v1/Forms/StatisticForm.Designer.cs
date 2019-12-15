namespace Course_v1
{
    partial class StatisticForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatisticForm));
            this.ListViewInfo = new System.Windows.Forms.ListView();
            this.Time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CPULoad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RAMLoad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TCPU = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TMOBO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.VOLTAGE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // ListViewInfo
            // 
            this.ListViewInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.ListViewInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListViewInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Time,
            this.CPULoad,
            this.RAMLoad,
            this.TCPU,
            this.TMOBO,
            this.VOLTAGE});
            this.ListViewInfo.Font = new System.Drawing.Font("Consolas", 10F);
            this.ListViewInfo.ForeColor = System.Drawing.Color.White;
            this.ListViewInfo.Location = new System.Drawing.Point(10, 70);
            this.ListViewInfo.Name = "ListViewInfo";
            this.ListViewInfo.Size = new System.Drawing.Size(700, 670);
            this.ListViewInfo.TabIndex = 1;
            this.ListViewInfo.UseCompatibleStateImageBehavior = false;
            this.ListViewInfo.View = System.Windows.Forms.View.Details;
            // 
            // Time
            // 
            this.Time.Text = " Time";
            // 
            // CPULoad
            // 
            this.CPULoad.Text = "CPU load";
            this.CPULoad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CPULoad.Width = 120;
            // 
            // RAMLoad
            // 
            this.RAMLoad.Text = "RAM load";
            this.RAMLoad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RAMLoad.Width = 120;
            // 
            // TCPU
            // 
            this.TCPU.Text = "t CPU";
            this.TCPU.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TCPU.Width = 100;
            // 
            // TMOBO
            // 
            this.TMOBO.Text = "t Motherboard";
            this.TMOBO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TMOBO.Width = 160;
            // 
            // VOLTAGE
            // 
            this.VOLTAGE.Text = "Voltage";
            this.VOLTAGE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.VOLTAGE.Width = 125;
            // 
            // StatisticForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 750);
            this.Controls.Add(this.ListViewInfo);
            this.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StatisticForm";
            this.Padding = new System.Windows.Forms.Padding(24, 69, 24, 23);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "Statistic";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.StatisticForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView ListViewInfo;
        private System.Windows.Forms.ColumnHeader Time;
        private System.Windows.Forms.ColumnHeader CPULoad;
        private System.Windows.Forms.ColumnHeader RAMLoad;
        private System.Windows.Forms.ColumnHeader TCPU;
        private System.Windows.Forms.ColumnHeader TMOBO;
        private System.Windows.Forms.ColumnHeader VOLTAGE;
    }
}