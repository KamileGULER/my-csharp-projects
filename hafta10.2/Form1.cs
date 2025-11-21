using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hafta10._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Id, name, surname, phoneNum, job;
            Id = textBox1.Text;
            name = textBox2.Text;
            surname = textBox3.Text;
            phoneNum = textBox4.Text;
            job = textBox5.Text;

            string[] colum = { Id, name, surname, phoneNum, job };

            ListViewItem records = new ListViewItem(colum);
            listView1.Items.Add(records);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String targetID = textBox6.Text.Trim();

            if (string.IsNullOrEmpty(targetID))
            {
                MessageBox.Show("Please enter an ID to delete.");
                return;
            }
            bool found = false;

            foreach (ListViewItem item in listView1.Items)
            {
                if (item.SubItems[0].Text == targetID)
                { 
                    listView1.Items.Remove(item);
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                MessageBox.Show("Record with the specified ID not found.");
            }   
            else
            {
                MessageBox.Show("Record deleted successfully.");
            }
        }
    }
}
