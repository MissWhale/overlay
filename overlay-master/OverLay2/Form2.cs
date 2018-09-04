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
using OpenHardwareMonitor.Hardware;
namespace OverLay2
{
    public partial class Form2 : Form
    {
        Form1 frm1;
        private PerformanceCounter Ram = new PerformanceCounter("Memory", "Available MBytes");
        Computer com = new Computer() { CPUEnabled = true, GPUEnabled = true, RAMEnabled = true };
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
            com.Open();
            checks = new Thread(check);
            checks.Start();
        }
        private void check()
        {
            int freem = 0, useram = 0, ramper = 0;
            double fm = 0.0, um = 0.0;
            this.totalramlbl.Text= (Form1.totalm/1000).ToString()+"GB";
            while (true)
            {
                freem = int.Parse(Ram.NextValue().ToString());
                useram = Form1.totalm - freem;
                ramper = Convert.ToInt32(float.Parse(useram.ToString()) / float.Parse(Form1.totalm.ToString()) * 100);
                fm = Math.Round((double)freem / 1024, 2);
                um = Math.Round((double)useram / 1024, 2);
                this.ramuselbl.Text= um.ToString() + "GB";
                this.ramfreelbl.Text = fm.ToString() + "GB";
                this.rampercircle.Value = ramper;
                foreach (IHardware hardware in com.Hardware)
                {
                    hardware.Update();
                    if (hardware.HardwareType.ToString() == "CPU")
                    {
                        this.cpunamelbl.Text = hardware.Name.ToString();
                        foreach (ISensor sensor in hardware.Sensors)
                        {
                            //MessageBox.Show(sensor.Name.ToString() + " : " + sensor.Value.ToString() + " - " + sensor.SensorType.ToString());
                            if (sensor.SensorType == SensorType.Load && sensor.Name.ToString() == "CPU Total")
                            {
                                this.cpupercircle.Value = Convert.ToInt32(sensor.Value);
                            }
                            if (sensor.SensorType == SensorType.Temperature && sensor.Name.ToString() == "CPU Package")
                            {
                                this.cputemplbl.Text = Convert.ToInt32(sensor.Value).ToString();
                                this.cputempcircle.Value = Convert.ToInt32(sensor.Value);
                            }
                        }
                    }
                    if (hardware.HardwareType.ToString() == "RAM")
                    {
                        //MessageBox.Show(hardware.Name.ToString());
                        foreach (ISensor sensor in hardware.Sensors)
                        {
                            //MessageBox.Show(sensor.Name.ToString() + " : " + sensor.Value.ToString() + " - " + sensor.SensorType.ToString());
                        }
                    }
                }
                Thread.Sleep(1000);
            }
        }
        private void settingbutton2_Click(object sender, EventArgs e)
        {
            frm1.Show();
            this.checks.Abort();
            this.Close();
        }
    }
}
