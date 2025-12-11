using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusTicket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Rotaniz :  " + groupBox1.Text + "------->>>>  " + groupBox2.Text+"\t " +
            "Tarih:  " + maskedTextBox1.Text + "\t Saat:  " + maskedTextBox2.Text);
            if (radioButton1.Checked)
                listBox1.Items.Add("Adiniz: " + textBox1.Text +
                "TC ID: " + maskedTextBox4.Text +
                "Telefon Numaranız  " + maskedTextBox3.Text +
                "Cinsiyetiniz: " + radioButton1.Text);
            else listBox1.Items.Add("Adinız: " + textBox1.Text +
            "TC ID: " + maskedTextBox4.Text +
            "Telefon Numaranız " + maskedTextBox3.Text +
            "Cinsiyetiniz:  " + radioButton2.Text);
        }
    }
}
