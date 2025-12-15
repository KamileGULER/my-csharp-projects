using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

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
            int tutar = TutarHesapla();

            string rota =
                "Rota: " + comboBoxNereden.Text + " ---> " + comboBoxNereye.Text +
                " | Tarih: " + maskedTextBox1.Text +
                " | Saat: " + maskedTextBox2.Text;

            string cinsiyet = radioButton1.Checked ? radioButton1.Text : radioButton2.Text;

            string yolcu =
                "Ad Soyad: " + textBox1.Text +
                " | TC: " + maskedTextBox4.Text +
                " | Tel: " + maskedTextBox3.Text +
                " | Cinsiyet: " + cinsiyet;

            string kisiBilgisi =
                "Çocuk: " + numericUpDown1.Value +
                " | Yetişkin: " + numericUpDown2.Value +
                " | Toplam Tutar: " + tutar + " TL";

            listBox1.Items.Add(rota);
            listBox1.Items.Add(yolcu);
            listBox1.Items.Add(kisiBilgisi);
            listBox1.Items.Add("------------------------------------------------");
        }

        private int TutarHesapla()
        {
            int cocukSayisi = (int)numericUpDown1.Value;
            int yetiskinSayisi = (int)numericUpDown2.Value;

            int tutar = 0;

            if (checkBoxCocuk.Checked)
                tutar += cocukSayisi * 50;

            if (checkBoxYetişkin.Checked)
                tutar += yetiskinSayisi * 100;

            return tutar;
        }
        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            int tutar = TutarHesapla();
            labelTutar.Text = tutar + " TL";
        }

    }
}
