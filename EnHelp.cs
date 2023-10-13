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

namespace Stable_Diffusion_Recolay
{
    public partial class EnHelp : Form
    {
        public EnHelp()
        {
            InitializeComponent();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.python.org/ftp/python/3.12.0/python-3.12.0-amd64.exe");
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.python.org/ftp/python/3.12.0/python-3.12.0.exe");
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.python.org/ftp/python/3.12.0/python-3.12.0-arm64.exe");
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/git-for-windows/git/releases/download/v2.42.0.windows.2/Git-2.42.0.2-32-bit.exe");
        
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/git-for-windows/git/releases/download/v2.42.0.windows.2/Git-2.42.0.2-32-bit.exe");
        
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {

        }

        private void EnHelp_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            SoundPlayer splayer = new SoundPlayer("Help_Fa.wav");
            splayer.Play();
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            SoundPlayer splayer = new SoundPlayer("Help_En.wav");
            splayer.Play();
        }
    }
}
