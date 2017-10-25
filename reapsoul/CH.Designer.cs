namespace reapsoul
{
    partial class CH
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
            this.crosshair = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // crosshair
            // 
            this.crosshair.BackColor = System.Drawing.Color.Transparent;
            this.crosshair.ForeColor = System.Drawing.Color.White;
            this.crosshair.Location = new System.Drawing.Point(11, 11);
            this.crosshair.Name = "crosshair";
            this.crosshair.Size = new System.Drawing.Size(24, 24);
            this.crosshair.TabIndex = 0;
            this.crosshair.Paint += new System.Windows.Forms.PaintEventHandler(this.crosshair_Paint);
            // 
            // CH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(48, 48);
            this.ControlBox = false;
            this.Controls.Add(this.crosshair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CH";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CH";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CH_Load);
            this.Resize += new System.EventHandler(this.CH_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel crosshair;
    }
}