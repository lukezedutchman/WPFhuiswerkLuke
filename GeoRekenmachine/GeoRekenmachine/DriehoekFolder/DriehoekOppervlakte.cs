using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeoRekenmachine.Driehoek
{
    public partial class DriehoekOppervlakte : Form
    {
        public DriehoekOppervlakte()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal basis = numericUpDown1.Value;
            decimal hoogte = numericUpDown2.Value;

            decimal uitkomst = 0.5m * basis * hoogte;

            label4.Text = String.Format("De uitkomst is: {0}", uitkomst);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
