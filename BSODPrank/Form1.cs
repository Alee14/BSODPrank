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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #if DEBUG
            MessageBox.Show("Debug mode is on.");
            btnExitDebug.Visible = true;
            #endif
            //System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            //player.SoundLocation = "Bleep-SoundBible.com-1927126940.wav";
            //player.Play();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void btnExitDebug_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
