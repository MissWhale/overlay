using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Diagnostics;
using hardcs;
using System.Runtime.InteropServices;

namespace OverLay2
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        private static extern int RegisterHotKey(int hwnd, int id, int fsModifiers, int vk);
        [DllImport("user32.dll")]
        private static extern int UnregisterHotKey(int hwnd, int id);
        public hardeware hard = new hardeware();
        public Thread checksystem;
        public static int totalm = 0;
        public Form2 showForm = new Form2();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            this.notifyIcon1.Visible = true;
            notifyIcon1.ContextMenuStrip = contextMenuStrip1;
            RegisterHotKey((int)this.Handle, 0, 0x0, (int)Keys.F9);
            Bunifu.Framework.Lib.Elipse.Apply(this, 20);
            Bunifu.Framework.Lib.Elipse.Apply(this.header, 5);
            checksystem = new Thread(check);
            checksystem.Start();
        }

        protected override void WndProc(ref Message m) 
        {
            base.WndProc(ref m);

            if (m.Msg == (int)0x312) 
            {
                if (m.WParam == (IntPtr)0x0) 
                {
                    PictureBox picture = new PictureBox();
                    picture.domaincapture();
                }
            }
        }
        private void check()
        {
            while (true)
            {
                this.cpuperlbl.Text = hard.Cpuper().ToString();
                this.ramperlbl.Text = hard.Ramper().ToString();
                //hard.Gputemp();
                Thread.Sleep(1000);
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            UnregisterHotKey((int)this.Handle, 0);
            this.checksystem.Abort();
        }

        private void settingbutton_Click(object sender, EventArgs e)
        {
            Form2 showForm = new Form2(this);
            showForm.Show();
            showForm.Location = new Point(this.Location.X, this.Location.Y);
            this.Hide();
        }
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            
        }

        private void StripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.checksystem.Abort();
            //MessageBox.Show(showForm.checks.ThreadState.ToString());
            //showForm.checks.Abort();
            UnregisterHotKey((int)this.Handle, 0);
            Application.Exit();
        }
    }
}
//112, 6
//148, 28
//652, 422