namespace Course_v1
{
    partial class InfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoForm));
            this.ListViewInfo = new System.Windows.Forms.ListView();
            this.ComponentName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ComponentValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btLoad = new MetroFramework.Controls.MetroButton();
            this.btSave = new MetroFramework.Controls.MetroButton();
            this.btLoadStatistic = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // ListViewInfo
            // 
            this.ListViewInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.ListViewInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListViewInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ComponentName,
            this.ComponentValue});
            this.ListViewInfo.Font = new System.Drawing.Font("Consolas", 10F);
            this.ListViewInfo.ForeColor = System.Drawing.Color.White;
            this.ListViewInfo.Location = new System.Drawing.Point(10, 70);
            this.ListViewInfo.Name = "ListViewInfo";
            this.ListViewInfo.Size = new System.Drawing.Size(700, 670);
            this.ListViewInfo.TabIndex = 0;
            this.ListViewInfo.UseCompatibleStateImageBehavior = false;
            this.ListViewInfo.View = System.Windows.Forms.View.Details;
            // 
            // ComponentName
            // 
            this.ComponentName.Text = "Component name";
            this.ComponentName.Width = 275;
            // 
            // ComponentValue
            // 
            this.ComponentValue.Text = "Component value";
            this.ComponentValue.Width = 425;
            // 
            // btLoad
            // 
            this.btLoad.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btLoad.ForeColor = System.Drawing.Color.White;
            this.btLoad.Location = new System.Drawing.Point(335, -1);
            this.btLoad.Margin = new System.Windows.Forms.Padding(0);
            this.btLoad.Name = "btLoad";
            this.btLoad.Size = new System.Drawing.Size(170, 71);
            this.btLoad.Style = MetroFramework.MetroColorStyle.Black;
            this.btLoad.TabIndex = 25;
            this.btLoad.Text = "Load";
            this.btLoad.UseCustomBackColor = true;
            this.btLoad.UseCustomForeColor = true;
            this.btLoad.UseSelectable = true;
            this.btLoad.UseStyleColors = true;
            this.btLoad.Click += new System.EventHandler(this.btLoad_Click);
            // 
            // btSave
            // 
            this.btSave.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btSave.ForeColor = System.Drawing.Color.White;
            this.btSave.Location = new System.Drawing.Point(165, -1);
            this.btSave.Margin = new System.Windows.Forms.Padding(0);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(170, 71);
            this.btSave.Style = MetroFramework.MetroColorStyle.Black;
            this.btSave.TabIndex = 26;
            this.btSave.Text = "Save";
            this.btSave.UseCustomBackColor = true;
            this.btSave.UseCustomForeColor = true;
            this.btSave.UseSelectable = true;
            this.btSave.UseStyleColors = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btLoadStatistic
            // 
            this.btLoadStatistic.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btLoadStatistic.ForeColor = System.Drawing.Color.White;
            this.btLoadStatistic.Location = new System.Drawing.Point(505, -1);
            this.btLoadStatistic.Margin = new System.Windows.Forms.Padding(0);
            this.btLoadStatistic.Name = "btLoadStatistic";
            this.btLoadStatistic.Size = new System.Drawing.Size(170, 71);
            this.btLoadStatistic.Style = MetroFramework.MetroColorStyle.Black;
            this.btLoadStatistic.TabIndex = 27;
            this.btLoadStatistic.Text = "Load \r\nstatistic";
            this.btLoadStatistic.UseCustomBackColor = true;
            this.btLoadStatistic.UseCustomForeColor = true;
            this.btLoadStatistic.UseSelectable = true;
            this.btLoadStatistic.UseStyleColors = true;
            this.btLoadStatistic.Click += new System.EventHandler(this.btLoadStatistic_Click);
            // 
            // InfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 750);
            this.Controls.Add(this.btLoadStatistic);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btLoad);
            this.Controls.Add(this.ListViewInfo);
            this.Font = new System.Drawing.Font("Consolas", 10F);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InfoForm";
            this.Padding = new System.Windows.Forms.Padding(24, 69, 24, 23);
            this.Resizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "Information";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TransparencyKey = System.Drawing.Color.DeepSkyBlue;
            this.Load += new System.EventHandler(this.InfoForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView ListViewInfo;
        private System.Windows.Forms.ColumnHeader ComponentName;
        private System.Windows.Forms.ColumnHeader ComponentValue;
        private MetroFramework.Controls.MetroButton btLoad;
        private MetroFramework.Controls.MetroButton btSave;
        private MetroFramework.Controls.MetroButton btLoadStatistic;
    }
}