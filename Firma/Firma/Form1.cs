using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Firma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            string kullaniciadi = textBox1.Text;
            int sifre = Convert.ToInt32(textBox2.Text);
            if (firma.firmagiris(kullaniciadi, sifre).Tables[0].Rows.Count == 1)
            {
                MessageBox.Show("DOĞRU GİRİŞ YAPTINIZ!!!");
                Form2 frm = new Form2();
                frm.Show();
                this.Hide();
            }
            else
                MessageBox.Show("KULANICI ADI VE/VEYA YANLIŞ ŞİFRE GİRDİNİZ!!!");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }
    }
    }

