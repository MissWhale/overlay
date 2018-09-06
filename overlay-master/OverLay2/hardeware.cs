using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.Diagnostics;
using OpenHardwareMonitor;
using OpenHardwareMonitor.Hardware;
using OpenHardwareMonitor.Collections;
using System.Windows.Forms;
namespace hardcs
{
    public partial class hardeware
    {
        public static Computer com = new Computer() { CPUEnabled = true, GPUEnabled = true, RAMEnabled = true ,FanControllerEnabled=true};
        #region cpu
        public int Cputemp()
        {
            com.Open();
            foreach (IHardware hardware in com.Hardware)
            {
                hardware.Update();
                if (hardware.HardwareType.ToString() == "CPU")
                {
                    foreach (ISensor sensor in hardware.Sensors)
                    {
                        if (sensor.SensorType == SensorType.Temperature && sensor.Name.ToString() == "CPU Package")
                        {
                            return Convert.ToInt32(sensor.Value);
                        }
                    }
                }
            }
            return 0;
        }
        public string Cpuname()
        {
            com.Open();
            foreach (IHardware hardware in com.Hardware)
            {
                hardware.Update();
                if (hardware.HardwareType.ToString() == "CPU")
                {
                    return hardware.Name;
                }
            }
            return null;
        }
        public int Cpuper()
        {
            com.Open();
            foreach (IHardware hardware in com.Hardware)
            {
                hardware.Update();
                if (hardware.HardwareType.ToString() == "CPU")
                {
                    foreach (ISensor sensor in hardware.Sensors)
                    {
                        if (sensor.SensorType == SensorType.Load && sensor.Name.ToString() == "CPU Total")
                        {
                            return Convert.ToInt32(sensor.Value);
                        }
                    }
                }
            }
            return 0;
        }
        #endregion
        #region ram
        public string Ramname()
        {
            com.Open();
            foreach (IHardware hardware in com.Hardware)
            {
                hardware.Update();
                if (hardware.HardwareType.ToString() == "RAM")
                {
                    return hardware.Name;
                }
            }
            return null;
        }
        public int Ramper()
        {
            com.Open();
            foreach (IHardware hardware in com.Hardware)
            {
                hardware.Update();
                if (hardware.HardwareType.ToString() == "RAM")
                {
                    foreach (ISensor sensor in hardware.Sensors)
                    {
                        if (sensor.SensorType == SensorType.Load && sensor.Name.ToString() == "Memory")
                        {
                            return Convert.ToInt32(sensor.Value);
                        }
                    }
                }
            }
            return 0;
        }
        public double Ramuse()
        {
            com.Open();
            foreach (IHardware hardware in com.Hardware)
            {
                hardware.Update();
                if (hardware.HardwareType.ToString() == "RAM")
                {
                    foreach (ISensor sensor in hardware.Sensors)
                    {
                        if (sensor.SensorType == SensorType.Data && sensor.Name.ToString() == "Used Memory")
                        {
                            return Math.Round((double)sensor.Value,2);
                        }
                    }
                }
            }
            return 0.0;
        }
        public double Ramfree()
        {
            com.Open();
            foreach (IHardware hardware in com.Hardware)
            {
                hardware.Update();
                if (hardware.HardwareType.ToString() == "RAM")
                {
                    foreach (ISensor sensor in hardware.Sensors)
                    {
                        if (sensor.SensorType == SensorType.Data && sensor.Name.ToString() == "Available Memory")
                        {
                            return Math.Round((double)sensor.Value,2);
                        }
                    }
                }
            }
            return 0.0;
        }
        #endregion
        #region gpu
        public string Gpuname()
        {
            com.Open();
            foreach (IHardware hardware in com.Hardware)
            {
                hardware.Update();
                if (hardware.HardwareType.ToString() == "GpuNvidia")
                {
                    return hardware.Name;
                }
            }
            return null;
        }
        public int Gpuper()
        {
            com.Open();
            foreach (IHardware hardware in com.Hardware)
            {
                hardware.Update();
                if (hardware.HardwareType.ToString() == "GpuNvidia")
                {
                    foreach (ISensor sensor in hardware.Sensors)
                    {
                        if (sensor.SensorType == SensorType.Load && sensor.Name.ToString() == "GPU Core")
                        {
                            return Convert.ToInt32(sensor.Value);
                        }
                    }
                }
            }
            return 0;
        }
        public int Gputemp()
        {
            com.Open();
            foreach (IHardware hardware in com.Hardware)
            {
                hardware.Update();
                if (hardware.HardwareType.ToString() == "GpuNvidia")
                {
                    foreach (ISensor sensor in hardware.Sensors)
                    {
                        //MessageBox.Show(sensor.Name.ToString() + " : " + sensor.Value.ToString() + " - " + sensor.SensorType.ToString());
                        if (sensor.SensorType == SensorType.Temperature && sensor.Name.ToString() == "GPU Core")
                        {
                            //MessageBox.Show(sensor.Value.ToString());
                            if (sensor.Value == 0)
                            {
                                return Convert.ToInt32(sensor.Max);
                            }
                            else
                            {
                                return Convert.ToInt32(sensor.Value);
                            }
                        }
                    }
                }
            }
            return 0;
        }
        #endregion
    }
}
//MessageBox.Show(hardware.HardwareType.ToString());
//MessageBox.Show(sensor.Name.ToString() + " : " + sensor.Value.ToString() + " - " + sensor.SensorType.ToString());