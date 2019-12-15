namespace Course_v1.MessageBox
{
    partial class frmMessageYesNo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMessageYesNo));
            this.btYes = new MetroFramework.Controls.MetroButton();
            this.btNo = new MetroFramework.Controls.MetroButton();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btYes
            // 
            this.btYes.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btYes.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btYes.ForeColor = System.Drawing.Color.White;
            this.btYes.Location = new System.Drawing.Point(120, 150);
            this.btYes.Name = "btYes";
            this.btYes.Size = new System.Drawing.Size(80, 40);
            this.btYes.Style = MetroFramework.MetroColorStyle.Black;
            this.btYes.TabIndex = 26;
            this.btYes.Text = "Yes";
            this.btYes.UseCustomBackColor = true;
            this.btYes.UseCustomForeColor = true;
            this.btYes.UseSelectable = true;
            this.btYes.UseStyleColors = true;
            // 
            // btNo
            // 
            this.btNo.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btNo.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btNo.ForeColor = System.Drawing.Color.White;
            this.btNo.Location = new System.Drawing.Point(200, 150);
            this.btNo.Name = "btNo";
            this.btNo.Size = new System.Drawing.Size(80, 40);
            this.btNo.Style = MetroFramework.MetroColorStyle.Black;
            this.btNo.TabIndex = 27;
            this.btNo.Text = "No";
            this.btNo.UseCustomBackColor = true;
            this.btNo.UseCustomForeColor = true;
            this.btNo.UseSelectable = true;
            this.btNo.UseStyleColors = true;
            // 
            // pictureBox
            // 
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(25, 70);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(50, 50);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 28;
            this.pictureBox.TabStop = false;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(90, 70);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(131, 23);
            this.label.TabIndex = 29;
            this.label.Text = "Information";
            // 
            // frmMessageYesNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 200);
            this.Controls.Add(this.label);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.btNo);
            this.Controls.Add(this.btYes);
            this.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMessageYesNo";
            this.Padding = new System.Windows.Forms.Padding(24, 69, 24, 23);
            this.Resizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "Message";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btYes;
        private MetroFramework.Controls.MetroButton btNo;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label;
    }
}