using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualHomework
{
    public partial class Form1 : Form
    {
        Student student = new Student("KamileGüler", "1234");
        Student student2 = new Student("AbideGüler", "123456");
        public Form1()
        {
            InitializeComponent();
            this.AcceptButton = button1;          // Enter ile tıkla
            passwordText.UseSystemPasswordChar = true; // şifre gizli
            userName.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var name = userName.Text;
            var password = passwordText.Text;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            else if (name != student.Name && password == student.Password.ToString())
            {
                MessageBox.Show("Öğrenci bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (name == student.Name && password == student.Password.ToString())
            {
                MessageBox.Show($"Giriş başarılı! Hoş geldiniz {student.Name}","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show($"Şifre yanlış {student.Name}", "Hata",MessageBoxButtons.OK, MessageBoxIcon.Error);
                passwordText.SelectAll();
                passwordText.Focus();
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
