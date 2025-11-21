using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hafta10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            color.ShowDialog();
            textBox3.BackColor = color.Color;
            color.Reset();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            progressBar1.Value = 10;
            listBox1.Items.Add("Name: " + textBox1.Text);
            listBox1.Items.Add("Surname: " + textBox2.Text);

            listBox1.Items.Add(("Age:" + (DateTime.Now.Year - dateTimePicker1.Value.Year)));
            listBox1.Items.Add("Country: " + comboBox1.SelectedItem.ToString());
            if (radioButton2.Checked) listBox1.Items.Add("Gender:" + radioButton2.Text);
            else listBox1.Items.Add("Gender:" + radioButton1.Text);
            
            if (checkBox1.Checked) listBox1.Items.Add("Position: " + checkBox1.Text);
            else listBox1.Items.Add("Position" + checkBox2.Text);
            progressBar1.Value = 100;
            tabPage1.Refresh();


        }
    }
}
