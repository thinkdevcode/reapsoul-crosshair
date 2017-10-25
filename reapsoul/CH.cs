using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace reapsoul
{
    public partial class CH : Form
    {
        private static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);
        private const UInt32 SWP_NOSIZE = 0x0001;
        private const UInt32 SWP_NOMOVE = 0x0002;
        private const UInt32 TOPMOST_FLAGS = SWP_NOMOVE | SWP_NOSIZE;

        public enum GWL { ExStyle = -20 }
        public enum WS_EX {
            Transparent = 0x20,
            Layered = 0x80000
        }
        public enum LWA {
            ColorKey = 0x1,
            Alpha = 0x2
        }

        public Color crosshairColor { get; set; }
        public float crosshairThickness { get; set; }

        public CH() {
            InitializeComponent();
            crosshairColor = Color.White;
            crosshairThickness = 1;
        }

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

        [DllImport("user32.dll", EntryPoint = "GetWindowLong")]
        public static extern int GetWindowLong(IntPtr hWnd, GWL nIndex);

        [DllImport("user32.dll", EntryPoint = "SetWindowLong")]
        public static extern int SetWindowLong(IntPtr hWnd, GWL nIndex, int dwNewLong);

        private void CH_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.LimeGreen;
            this.TransparencyKey = Color.LimeGreen;
            SetWindowPos(this.Handle, HWND_TOPMOST, 0, 0, 0, 0, TOPMOST_FLAGS);
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            int wl = GetWindowLong(this.Handle, GWL.ExStyle);
            wl = wl | 0x80000 | 0x20;
            SetWindowLong(this.Handle, GWL.ExStyle, wl);
        }

        private void CH_Resize(object sender, EventArgs e)
        {
            crosshair.Left = (ActiveForm.Width / 2) - (crosshair.Width / 2);
            crosshair.Top = (ActiveForm.Height / 2) - (crosshair.Height / 2);
        }

        private void crosshair_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawLine(new Pen(crosshairColor, crosshairThickness), 12, 4, 12, 20);
            e.Graphics.DrawLine(new Pen(crosshairColor, crosshairThickness), 4, 12, 20, 12);
        }
    }
}
