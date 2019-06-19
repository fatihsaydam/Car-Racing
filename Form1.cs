using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace ArabaYarisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile("nfs.jpg");
            SoundPlayer sesci = new SoundPlayer();
            sesci.SoundLocation = "basgaza.wav";
            sesci.Play();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value != 100)
            {
                progressBar1.Value += 1;
                lblDolum.Text = "%" + progressBar1.Value.ToString();
            }
            else
            {
                timer1.Stop();
                YolSecimiForm yol = new YolSecimiForm();
                this.Hide();
                yol.ShowDialog();

            }

        }
    }
}
