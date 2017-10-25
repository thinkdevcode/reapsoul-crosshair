namespace reapsoul
{
    partial class Config
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
            this.runBtn = new System.Windows.Forms.Button();
            this.chColor = new System.Windows.Forms.ColorDialog();
            this.colorBtn = new System.Windows.Forms.Button();
            this.oneBtn = new System.Windows.Forms.Button();
            this.twoBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // runBtn
            // 
            this.runBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.runBtn.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runBtn.Location = new System.Drawing.Point(91, 1);
            this.runBtn.Name = "runBtn";
            this.runBtn.Size = new System.Drawing.Size(90, 30);
            this.runBtn.TabIndex = 0;
            this.runBtn.Text = "Activate";
            this.runBtn.UseVisualStyleBackColor = false;
            this.runBtn.Click += new System.EventHandler(this.runBtn_Click);
            // 
            // colorBtn
            // 
            this.colorBtn.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorBtn.ForeColor = System.Drawing.Color.SteelBlue;
            this.colorBtn.Location = new System.Drawing.Point(59, 1);
            this.colorBtn.Name = "colorBtn";
            this.colorBtn.Size = new System.Drawing.Size(30, 30);
            this.colorBtn.TabIndex = 1;
            this.colorBtn.Text = "C";
            this.colorBtn.UseVisualStyleBackColor = true;
            this.colorBtn.Click += new System.EventHandler(this.colorBtn_Click);
            // 
            // oneBtn
            // 
            this.oneBtn.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oneBtn.Location = new System.Drawing.Point(1, 1);
            this.oneBtn.Name = "oneBtn";
            this.oneBtn.Size = new System.Drawing.Size(30, 30);
            this.oneBtn.TabIndex = 2;
            this.oneBtn.Text = "1";
            this.oneBtn.UseVisualStyleBackColor = true;
            this.oneBtn.Click += new System.EventHandler(this.oneBtn_Click);
            // 
            // twoBtn
            // 
            this.twoBtn.Font = new System.Drawing.Font("Calibri", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twoBtn.Location = new System.Drawing.Point(30, 1);
            this.twoBtn.Name = "twoBtn";
            this.twoBtn.Size = new System.Drawing.Size(30, 30);
            this.twoBtn.TabIndex = 3;
            this.twoBtn.Text = "2";
            this.twoBtn.UseVisualStyleBackColor = true;
            this.twoBtn.Click += new System.EventHandler(this.twoBtn_Click);
            // 
            // Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(182, 32);
            this.Controls.Add(this.twoBtn);
            this.Controls.Add(this.oneBtn);
            this.Controls.Add(this.colorBtn);
            this.Controls.Add(this.runBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Config";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "reapsoul\'s helper";
            this.Enter += new System.EventHandler(this.Config_Enter);
            this.Leave += new System.EventHandler(this.Config_Leave);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button runBtn;
        private System.Windows.Forms.ColorDialog chColor;
        private System.Windows.Forms.Button colorBtn;
        private System.Windows.Forms.Button oneBtn;
        private System.Windows.Forms.Button twoBtn;
    }
}

