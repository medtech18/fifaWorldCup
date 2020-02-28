using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wordCup.Properties;

namespace wordCup
{
    public partial class Win : Form
    {
        public Win()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        public void setPicture(String s)
        {
            ResourceManager rm = Resources.ResourceManager;

            pictureBox1.Image = (Bitmap)rm.GetObject(s);

        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Dispose();
        }
    }
}
