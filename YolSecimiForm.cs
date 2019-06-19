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
    public partial class YolSecimiForm : Form
    {
        public YolSecimiForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ArabaSecimForm araba = new ArabaSecimForm();
            this.Hide();
            if (rdbKolay.Checked)
                araba.yol = rdbKolay;
            else if (rdbOrta.Checked)
                araba.yol = rdbOrta;
            else if (rdbZor.Checked)
                araba.yol = rdbZor;
            araba.ShowDialog();
        }

        
    }
}
