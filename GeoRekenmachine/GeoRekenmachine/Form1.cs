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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Location = new Point(-650, button1.Location.Y);
            button2.Location = new Point(-300, button2.Location.Y);
            button3.Location = new Point(-650, button3.Location.Y);
            button4.Location = new Point(-300, button4.Location.Y);

            timer1.Start();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            
            button1.Location = new Point(button1.Location.X + 10, button1.Location.Y);
            button2.Location = new Point(button2.Location.X + 10, button2.Location.Y);
            button3.Location = new Point(button3.Location.X + 10, button3.Location.Y);
            button4.Location = new Point(button4.Location.X + 10, button4.Location.Y);

            if (button1.Location.X == 10)
            {
                    timer1.Stop();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            new CirkelMain().Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            new VierkantMain().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new DriehoekMain().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new RechthoekMain().Show();
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            TextBox myText = new TextBox();
            myText.Location = new Point(350, 200);
            this.Controls.Add(myText);
        }
    }
}
