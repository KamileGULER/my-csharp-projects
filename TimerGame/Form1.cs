using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimerGame
{
    public partial class Form1 : Form
    {
        int counter;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;
            label1.Text = "Time: " + counter.ToString();
            if (counter == 10)
            {
                timer1.Stop();
                MessageBox.Show("Time's up! You lost.");
                Application.Exit();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();
            button1.Location = new Point(rand.Next(0, Size.Width), rand.Next(Size.Height));
        }
    }
}
