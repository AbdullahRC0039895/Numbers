using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            double pi = 3.14159265;
            richTextBox2.AppendText(pi.ToString() + "\n");
            richTextBox2.AppendText(pi.ToString("N") + "\n");
            richTextBox2.AppendText(pi.ToString("N3") + "\n");
            richTextBox2.AppendText(pi.ToString("N15") + "\n");
            richTextBox2.AppendText("\n");
            double c = 299792458;
            richTextBox2.AppendText(c.ToString("0") + "\n");
            richTextBox2.AppendText(c.ToString("N0") + "\n");
            richTextBox2.AppendText(c.ToString("0.00000E0") + "\n");
            richTextBox2.AppendText(c.ToString("0.000E0") + "\n");

            string st = "three";
            try
            {
                int it = int.Parse(st);
            }
            catch
            {
                MessageBox.Show(st + " is not an integar");
            }

            string s2 = "3.2";
            try
            {
                int i2 = int.Parse(s2)
            }
            catch
            {
                MessageBox.Show(s2 + " is not an integar);
                int i2 = 0;
            }
        }

        private void RichTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}