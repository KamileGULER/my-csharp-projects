using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlanHesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                int Result = Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox1.Text);
                label5.Text = Result.ToString();
            }
            else if (radioButton2.Checked)
            {

                int Result = Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox1.Text);
                label5.Text = Result.ToString();
            }
            else 
            {
                MessageBox.Show("Chose one of the buttons");
            }
        }
    }
}
