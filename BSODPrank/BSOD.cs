using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BSODPrank
{
    public partial class BSOD : Form
    {
        public BSOD()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
#if DEBUG
            MessageBox.Show("Debug mode is on.");
            btnExitDebug.Visible = true;
#endif
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
            await Task.Delay(5000);
            Boot boot = new Boot();
            boot.Show();
            this.Hide();
        }
    
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            System.IO.Stream str = Properties.Resources.bleep;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
        }

        private void btnExitDebug_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
