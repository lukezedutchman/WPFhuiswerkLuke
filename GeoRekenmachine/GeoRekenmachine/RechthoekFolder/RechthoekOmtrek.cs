﻿using System;
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
    public partial class RechthoekOmtrek : Form
    {
        public RechthoekOmtrek()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal first = numericUpDown1.Value;
            decimal second = numericUpDown2.Value;
            decimal third = numericUpDown3.Value;
            decimal fourth = numericUpDown4.Value;

            decimal finalvalue = first + second + third + fourth;

            label6.Text = String.Format("De uitkomst is: {0}", finalvalue);
        }
    }
}
