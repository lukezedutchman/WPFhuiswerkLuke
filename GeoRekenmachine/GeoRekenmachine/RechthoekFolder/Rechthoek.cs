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
    public partial class RechthoekMain : Form
    {
        public RechthoekMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Rechthoek.RechthoekOmtrek().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Rechthoek.RechthoekOppervlakte().Show();
        }
    }
}
