using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeoRekenmachine.Rechthoek
{
    public partial class RechthoekOppervlakte : Form
    {
        public RechthoekOppervlakte()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal lengte = numericUpDown1.Value;
            decimal breedte = numericUpDown2.Value;

            decimal uitkomst = lengte * breedte;

            label4.Text = String.Format("De uitkomst is: {0}", uitkomst);
        }
    }
}
