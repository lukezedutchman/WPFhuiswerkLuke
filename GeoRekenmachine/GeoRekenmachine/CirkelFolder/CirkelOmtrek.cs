using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeoRekenmachine.Cirkel
{
    public partial class CirkelOmtrek : Form
    {
        public CirkelOmtrek()
        {
            InitializeComponent();

            comboBox1.Items.Add(new Item("Straal", 1));
            comboBox1.Items.Add(new Item("Diameter", 2));
        }

        private class Item
        {
            public string Name;
            public int Value;
            public Item(string name, int value)
            {
                Name = name; Value = value;
            }

            public override string ToString()
            {
                // Generates the text shown in the combo box
                return Name;
            }
        }

            private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void CirkelOmtrek_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double pi = Math.PI;
            decimal dpi = (decimal)pi;

            Item itm = (Item)comboBox1.SelectedItem;

            if (itm.Value == 1)
            {
                decimal straal = numericUpDown1.Value;

                decimal uitkomst = 2 * straal * dpi;

                label4.Text = String.Format("De uitkomst is: {0}", uitkomst);
            }

            if (itm.Value == 2)
            {
                decimal diameter = numericUpDown1.Value;

                decimal uitkomst = diameter * dpi;

                label4.Text = String.Format("De uitkomst is: {0}", uitkomst);
            }

            else
            {
                string message = "You did not select a value";
                string caption = "Error Detected in Input";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                // Displays the MessageBox.

                result = MessageBox.Show(message, caption, buttons);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {

                    // Closes the parent form.

                    this.Close();

                }
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
