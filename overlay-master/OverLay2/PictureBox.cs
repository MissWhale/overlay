using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
namespace OverLay2
{
    public partial class PictureBox : Form
    {
        [DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
        [DllImport("user32.dll")]
        private static extern IntPtr WindowFromPoint(Point Point);
        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();
        [DllImport("user32.dll")]
        private static extern bool GetWindowRect(IntPtr hWnd, out Rectangle lpRect);
        Point destinationPosition;
        bool captureBySpecifyingRegion = false;
        bool ishold = false;
        public static int idxcheck = 0;
        public static int imagenumber = 1;

        Rectangle rect = new Rectangle();
        public PictureBox()
        {
            InitializeComponent();
            SetProcessDPIAware();
            DoubleBuffered = true;
            StartPosition = FormStartPosition.CenterScreen;
            TransparencyKey = Color.Black;
        }
        #region 영역을 지정하여 캡처
        public void domaincapture()
        {
            Hide();
            captureBySpecifyingRegion = true;
            Rectangle r = Screen.PrimaryScreen.Bounds;
            Bitmap b = new Bitmap(r.Width, r.Height);
            Graphics g = Graphics.FromImage(b);
            g.CopyFromScreen(r.Left, r.Top, 0, 0, b.Size);
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            pictureBox1.Size= new Size(r.Width, r.Height);
            pictureBox1.Image = b;
            Show();
        }
        #endregion

        #region 영역을 지정하여 캡처, 고정된 사각 영역 캡처를 위한 오버레이
        Pen p = new Pen(Color.Red, 1);
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(p, rect);
        }
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            rect.Location = e.Location;
            ishold = true;
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (ishold)
            {
                destinationPosition = e.Location;
                int width = e.Location.X - rect.Location.X;
                int height = e.Location.Y - rect.Location.Y;
                rect.Width = width;
                rect.Height = height;
                pictureBox1.Invalidate();
            }
        }
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (captureBySpecifyingRegion)
            {
                if (ishold)
                {
                    Hide();
                    string imagename;
                    ishold = false;
                    Rectangle r = rect;
                    Bitmap b = new Bitmap(r.Width, r.Height);
                    Graphics g = Graphics.FromImage(b);
                    g.CopyFromScreen(r.Left, r.Top, 0, 0, b.Size);
                    pictureBox1.Size = new Size(0, 0);
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Title = "저장경로 지정하세요";
                    saveFileDialog.OverwritePrompt = true;
                    saveFileDialog.Filter = "PNG File(*.png) | *.png";
                    if (idxcheck == 1)
                    {
                        saveFileDialog.FileName = imagenumber.ToString()+".png";
                        imagename = saveFileDialog.FileName.ToString();
                        b.Save(imagename);
                        imagenumber++;
                    }
                    else
                    {
                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            imagename = saveFileDialog.FileName.ToString();
                            b.Save(imagename);
                        }
                    }
                    b.Dispose();
                    this.Close();
                }
            }
            FormBorderStyle = FormBorderStyle.Sizable;
            WindowState = FormWindowState.Normal;
        }
        #endregion

        private void PictureBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode ==Keys.Escape)
            {
                this.Close();
            }
        }
    }
}

