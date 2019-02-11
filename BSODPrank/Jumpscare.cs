using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BSODPrank
{
    public partial class Jumpscare : Form
    {
        public Jumpscare()
        {
            InitializeComponent();
        }

        private async void Jumpscare_Load(object sender, EventArgs e)
        {
            await Task.Delay(5000);
            Process[] runningProcesses = Process.GetProcesses();
            foreach (Process process in runningProcesses)
            {
                foreach (ProcessModule module in process.Modules)
                {
                    if (module.FileName.Equals("BSODPrank.exe"))
                    {
                        process.Kill();
                    }
                }
            }
        }
    }
}
