using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace SystemMonitor
{
    public partial class Form1 : Form
    {
        private PerformanceCounter cpuCounter;
        private PerformanceCounter memoryCounter;

        public Form1()
        {
            InitializeComponent();

            cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            memoryCounter = new PerformanceCounter("Memory", "Available MBytes");

            timer1.Tick += Timer1_Tick;
            timer1.Start();
        }


        private void Timer1_Tick(object sender, EventArgs e)
        {
            // Get values
            float cpuUsage = cpuCounter.NextValue();
            float availableMemory = memoryCounter.NextValue();

            // Update labels
            labelCpuValue.Text = $"{cpuUsage:F1}%";
            labelMemoryValue.Text = $"{availableMemory} MB";

            // Update progress bar (clip value to 100)
            int cpuInt = (int)Math.Min(cpuUsage, 100);
            progressBarCpu.Value = cpuInt;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
