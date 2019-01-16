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
    public partial class CirkelMain : Form
    {
        public CirkelMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Cirkel.CirkelOmtrek().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Cirkel.CirkelOppervlakte().Show();
        }

        private void CirkelMain_Load(object sender, EventArgs e)
        {

        }
    }
}
