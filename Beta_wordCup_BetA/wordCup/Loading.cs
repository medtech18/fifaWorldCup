using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Resources;
using wordCup.Properties;
using System.Windows.Forms;

namespace wordCup
{
    public partial class Loading : Form
    {
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        public Loading()
        {
            InitializeComponent();

            this.BackColor = Color.White;
            this.TransparencyKey = Color.Transparent;

            ResourceManager rm = Resources.ResourceManager;

            pictureBox1.Image = Properties.Resources.LoadingAnim;
            pictureBox1.BackColor = Color.White; 
     
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private async void Loading_LoadAsync(object sender, EventArgs e)
        {
            Form1 soft = new Form1();
            await Task.Delay(TimeSpan.FromSeconds(07));

            this.Visible = false;

            soft.Show();
            soft.BringToFront();

            soft.FormClosed += (s, args) => this.Dispose();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
