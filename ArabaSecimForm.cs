using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArabaYarisi
{
    public partial class ArabaSecimForm : Form
    {
        public ArabaSecimForm()
        {
            InitializeComponent();
        }

        public RadioButton yol { get; set; }

        private void ArabaSecimForm_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            YolSecimiForm yol = new YolSecimiForm();
            this.Hide();
            yol.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KarakterSecimForm krkt = new KarakterSecimForm();
            if (rdbKirmizi.Checked)
                krkt.araba = rdbKirmizi;
            else if (rdbSari.Checked)
                krkt.araba = rdbSari;
            else if (rdbSiyah.Checked)
                krkt.araba = rdbSiyah;
            krkt.yol = yol;
            this.Hide();
            krkt.Show();
        }
    }
}
