using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.Data.SqlClient;

namespace Firma
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential("xxx@gmail.com", "xxx");
                MailMessage ms = new MailMessage();
                ms.To.Add(textBox1.Text);
                ms.From = new MailAddress("xxx@gmail.com");
                ms.Subject = textBox1.Text;
                ms.Body = textBox3.Text;
                client.Send(ms);
                MessageBox.Show("MAİLİNİZ GÖNDERİLDİ");
            }
            catch
            {
                MessageBox.Show("MAİLİNİZ GÖNDERİLMEDİ");
            }


        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text == String.Empty)
                textBox4.Text = "0";
            DataSet bulunanlar = firma.bul(textBox4.Text);
            dataGridView1.DataSource = bulunanlar.Tables[0];
        }
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                textBox14.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                textBox13.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                textBox5.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                textBox15.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                textBox6.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();






            }
        }
        static string baglantiyolu = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=yazilimodev;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(baglantiyolu);
            string sql = "Select Defter from ogrenci where ogrenciAdi=@oAdi";
            SqlCommand komut = new SqlCommand(sql, baglanti);
            komut.Parameters.AddWithValue("@oAdi", textBox4.Text.ToString());
            baglanti.Open();
            SqlDataAdapter adaptor = new SqlDataAdapter();
            adaptor.SelectCommand = komut;
            DataSet sonuc = new DataSet();
            adaptor.Fill(sonuc);
            dataGridView2.DataSource = sonuc.Tables[0];
           
            string dosyaYolu = dataGridView2.Rows[0].Cells[0].Value.ToString();
            System.Diagnostics.Process.Start(dosyaYolu);
            MessageBox.Show("Olmuş Bil.");
            baglanti.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            DialogResult sonuc = MessageBox.Show("Çıkmak İstediğinizden Emin misiniz ?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (sonuc == DialogResult.Yes)
            {
                Form.ActiveForm.Close();
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
