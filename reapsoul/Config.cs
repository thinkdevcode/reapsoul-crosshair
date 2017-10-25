using System;
using System.Windows.Forms;

namespace reapsoul
{
    public partial class Config : Form
    {
        CH overlay;

        public Config()
        {
            InitializeComponent();
            overlay = new CH();
        }

        private void runBtn_Click(object sender, EventArgs e)
        {
            if (overlay.Visible)
            {
                runBtn.Text = "Activate";
                overlay.Hide();
            }
            else
            {
                runBtn.Text = "Deactivate";
                overlay.Show();
            }
        }

        private void Config_Enter(object sender, EventArgs e)
        {
            Cursor.Show();
        }

        private void Config_Leave(object sender, EventArgs e)
        {
            Cursor.Hide();
        }

        private void colorBtn_Click(object sender, EventArgs e)
        {
            var res = chColor.ShowDialog();
            overlay.crosshairColor = chColor.Color;

            reloadCrosshair();
        }

        private void reloadCrosshair()
        {
            overlay.Invalidate();
        }

        private void oneBtn_Click(object sender, EventArgs e)
        {
            overlay.crosshairThickness = 1;
            reloadCrosshair();
        }

        private void twoBtn_Click(object sender, EventArgs e)
        {
            overlay.crosshairThickness = 2;
            reloadCrosshair();
        }
    }
}
