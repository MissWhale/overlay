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
using System.Diagnostics;
namespace OverLay2
{
    public partial class Form2 : Form
    {
        Form1 frm1;
        public Thread checks;
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(Form1 _form)
        {
            InitializeComponent();
            frm1 = _form;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            Bunifu.Framework.Lib.Elipse.Apply(this, 5);
            Bunifu.Framework.Lib.Elipse.Apply(this.panel1, 5);
            checks = new Thread(check);
            checks.Start();
        }
        private void check()
        {
            this.cpunamelbl.Text= frm1.hard.Cpuname();
            this.totalramlbl.Text = frm1.hard.Ramname()+" "+Math.Round((frm1.hard.Ramuse() + frm1.hard.Ramfree())).ToString()+"GB";
            while (true)
            {
                this.cpupercircle.Value = frm1.hard.Cpuper();
                this.cputempcircle.Value = frm1.hard.Cputemp();
                this.cputemplbl.Text = frm1.hard.Cputemp().ToString();
                this.gpunamelbl.Text = frm1.hard.Gpuname();
                this.gpupercircle.Value = frm1.hard.Gpuper();
                this.gputempcircle.Value = frm1.hard.Gputemp();
                this.gputemplbl.Text = frm1.hard.Gputemp().ToString();
                this.rampercircle.Value = frm1.hard.Ramper();
                this.ramuselbl.Text = frm1.hard.Ramuse().ToString()+"GB";
                this.ramfreelbl.Text = frm1.hard.Ramfree().ToString()+"GB";
                Thread.Sleep(1000);
            }
        }
        private void settingbutton2_Click(object sender, EventArgs e)
        {
            frm1.Location = new Point(this.Location.X, this.Location.Y);
            frm1.Show();
            this.checks.Abort();
            this.Close();
        }

        private void screenshotbtn_Click(object sender, EventArgs e)
        {
            PictureBox.imagenumber = int.Parse(this.indextbx.Text);
            PictureBox picture = new PictureBox();
            picture.domaincapture();
        }

        private void screenshotsetting_Click(object sender, EventArgs e)
        {
            if (autoindex.Visible)
            {
                autoindex.Hide();
                indexlbl.Hide();
                indextbx.Hide();
                pathlbl.Hide();
                Pathbtn.Hide();
                pthlbl.Hide();
            }
            else
            {
                autoindex.Show();
                indexlbl.Show();
                indextbx.Show();
                pathlbl.Show();
                Pathbtn.Show();
                pthlbl.Show();
            }
        }
        private void autoindex_OnChange(object sender, EventArgs e)
        {
            if (autoindex.Checked)
            {
                indextbx.Enabled = true;
                PictureBox.idxcheck = 1;
            }
            else
            {
                indextbx.Enabled = false;
                PictureBox.idxcheck = 0;
            }
        }

        private void indextbx_Leave(object sender, EventArgs e)
        {
            PictureBox.imagenumber = int.Parse(this.indextbx.Text);
        }

        private void indextbx_KeyUp(object sender, KeyEventArgs e)
        {
            PictureBox.imagenumber = int.Parse(this.indextbx.Text);
        }

        private void Pathbtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.SelectedPath = @"C:\";    // 열 때 폴더를 지정하려면 이런식으로..(추가)
            dialog.ShowDialog();
            PictureBox.path= dialog.SelectedPath;
            pthlbl.Text= dialog.SelectedPath;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.checks.Abort();
        }
    }
}
