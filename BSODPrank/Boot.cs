using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BSODPrank
{
    public partial class Boot : Form
    {
        public Boot()
        {
            InitializeComponent();
        }


        private async void Boot_Load(object sender, EventArgs e)
        {
            //SystemInformation si = new SystemInformation();
            txtBoot.AppendText("[SYSTEM] Starting up computer..." + Environment.NewLine);
            await Task.Delay(2000);
            txtBoot.AppendText("[SYSTEM] Loading hard drive..." + Environment.NewLine);
            await Task.Delay(2000);
            txtBoot.AppendText("[SYSTEM ERROR] Cannot find an Operating System..." + Environment.NewLine);
            await Task.Delay(2000);
            txtBoot.AppendText("[SYSTEM ERROR] Any Operating System is not detected in the hard drive..." + Environment.NewLine);
            await Task.Delay(2000);
            txtBoot.AppendText("[SYSTEM] Attempting to boot..." + Environment.NewLine);
            await Task.Delay(5000);
            Jumpscare jumpscare = new Jumpscare();
            jumpscare.Show();
            this.Hide();
        }

        private void Boot_KeyDown(object sender, KeyEventArgs e)
        {
            System.IO.Stream str = Properties.Resources.bleep;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
        }

        private void txtBoot_KeyDown(object sender, KeyEventArgs e)
        {
            System.IO.Stream str = Properties.Resources.bleep;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
        }
    }
}
