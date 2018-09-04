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
using OpenHardwareMonitor.Hardware;
namespace OverLay2
{
    public partial class Form1 : Form
    {
        private PerformanceCounter Ram = new PerformanceCounter("Memory", "Available MBytes");
        Computer computer = new Computer() { CPUEnabled = true,RAMEnabled = true };
        public Thread checksystem;
        public static int totalm = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Bunifu.Framework.Lib.Elipse.Apply(this, 20);
            Bunifu.Framework.Lib.Elipse.Apply(this.header, 5);
            GetMemInfor();
            computer.Open();
            checksystem = new Thread(check);
            checksystem.Start();
        }


        //private void bunifuImageButton3_Click(object sender, EventArgs e)
        //{
        //    this.checksystem.Abort();
        //    this.Close();
        //}

        //}

        private void check()
        {
            int freem = 0,useram=0,ramper=0;
            while (true)
            {
                freem = int.Parse(Ram.NextValue().ToString());
                useram = totalm - freem;
                ramper = Convert.ToInt32(float.Parse(useram.ToString()) / float.Parse(totalm.ToString()) * 100);
                this.ramperlbl.Text = ramper.ToString();
                foreach (IHardware hardware in computer.Hardware)
                {
                    hardware.Update();
                    if (hardware.HardwareType.ToString() == "CPU")
                    {
                        foreach (ISensor sensor in hardware.Sensors)
                        {
                            //MessageBox.Show(sensor.Name.ToString() + " : " + sensor.Value.ToString() + " - " + sensor.SensorType.ToString());
                            if (sensor.SensorType == SensorType.Load && sensor.Name.ToString() == "CPU Total")
                            {
                                this.cpuperlbl.Text = Convert.ToInt32(sensor.Value).ToString();
                            }
                        }
                    }
                }
                Thread.Sleep(1000);
            }
            //MessageBox.Show(ramper.ToString());
            //while (true)
            //{
            //    //float RamUse = Ram.NextValue();
            //    //CheckForIllegalCrossThreadCalls = false;
            //    //freem = Math.Round(RamUse / 1024, 1);
            //    //usem = (double)totalm - freem;
            //    //this.ramuselb.Text = usem.ToString();
            //    //this.ramfreelb.Text = freem.ToString();
            //    //ramper = Convert.ToInt32(usem / (double)totalm * 100);
            //    //this.ramperlb.Text = ramper.ToString();
            //    //this.ramspin.Value = ramper;
            //    //foreach (IHardware hardware in computer.Hardware)
            //    //{
            //    //    hardware.Update();
            //    //    if (hardware.HardwareType.ToString() == "CPU")
            //    //    {
            //    //        this.cpuname.Text = hardware.Name.ToString();
            //    //        foreach (ISensor sensor in hardware.Sensors)
            //    //        {
            //    //            //MessageBox.Show(sensor.Name.ToString() + " : " + sensor.Value.ToString() + " - " + sensor.SensorType.ToString());
            //    //            if (sensor.SensorType == SensorType.Load && sensor.Name.ToString() == "CPU Total")
            //    //            {
            //    //                this.cpuuselb.Text = Convert.ToInt32(sensor.Value).ToString();
            //    //                this.cpuspin2.Value = Convert.ToInt32(sensor.Value);
            //    //            }
            //    //            if (sensor.SensorType == SensorType.Temperature && sensor.Name.ToString() == "CPU Package")
            //    //            {
            //    //                this.cputemplb.Text = Convert.ToInt32(sensor.Value).ToString();
            //    //                this.cpuspin1.Value = Convert.ToInt32(sensor.Value);
            //    //            }
            //    //            if (sensor.SensorType == SensorType.Clock && sensor.Name.ToString() == "CPU Core #6")
            //    //            {
            //    //                this.cpuclock.Text = Convert.ToInt32(sensor.Value).ToString();
            //    //            }

            //    //        }
            //    //    }
            //    //    else if (hardware.HardwareType.ToString() == "GpuNvidia")
            //    //    {
            //    //        this.gpuname.Text = hardware.Name.ToString();
            //    //        foreach (ISensor sensor in hardware.Sensors)
            //    //        {
            //    //            //MessageBox.Show(sensor.Name.ToString() + " : " + sensor.Value.ToString() + " - "+ sensor.SensorType.ToString());
            //    //            if (sensor.SensorType == SensorType.Load && sensor.Name.ToString() == "GPU Core")
            //    //            {
            //    //                this.gpuuselb.Text = sensor.Value.ToString();
            //    //                this.gpuspin2.Value = Convert.ToInt32(sensor.Value);
            //    //            }
            //    //            if (sensor.SensorType == SensorType.Clock && sensor.Name.ToString() == "GPU Core")
            //    //            {
            //    //                this.gpuclock.Text = Convert.ToInt32(sensor.Value).ToString();
            //    //            }
            //    //            if (sensor.SensorType == SensorType.Temperature)
            //    //            {
            //    //                this.gputemplb.Text = Convert.ToInt32(sensor.Value).ToString();
            //    //                this.gpuspin1.Value = Convert.ToInt32(sensor.Value);
            //    //            }
            //    //            if (sensor.SensorType == SensorType.Fan)
            //    //            {
            //    //                this.gpufan.Text = sensor.Value.ToString();
            //    //            }

            //    //        }
            //    //    }

            //    //}
        }
            //}
            //private void pn1_Paint(object sender, PaintEventArgs e)
            //{
            //}
            private void GetMemInfor()
        {
            ManagementClass cls = new ManagementClass("Win32_OperatingSystem");
            ManagementObjectCollection instances = cls.GetInstances();
            foreach (ManagementObject instance in instances)
            {
                //MessageBox.Show(instance["TotalVisibleMemorySize"].ToString());
                //totalm = float.Parse(instance["TotalVisibleMemorySize"].ToString());
                totalm = int.Parse(instance["TotalVisibleMemorySize"].ToString());
            }
            totalm = totalm / 1024;
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.checksystem.Abort();
        }

        private void settingbutton_Click(object sender, EventArgs e)
        {
            Form2 showForm = new Form2(this);
            showForm.Show();
            showForm.Location = new Point(this.Location.X, this.Location.Y);
            this.Hide();
        }

    }
}
//112, 6
//148, 28
//652, 422