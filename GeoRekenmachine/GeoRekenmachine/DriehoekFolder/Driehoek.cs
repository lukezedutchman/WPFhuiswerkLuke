using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeoRekenmachine
{
    public partial class DriehoekMain : Form
    {
        public DriehoekMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Driehoek.DriehoekOmtrek().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Driehoek.DriehoekOppervlakte().Show();
        }

        private void DriehoekMain_Load(object sender, EventArgs e)
        {

        }
    }
}
