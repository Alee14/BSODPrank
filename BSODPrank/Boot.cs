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
            await Task.Delay(5000);
            txtBoot.AppendText("[SYSTEM ERROR] BIOS Cannot Display." + Environment.NewLine);
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
