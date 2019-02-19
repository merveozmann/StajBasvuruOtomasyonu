using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kurum
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == String.Empty)
                textBox1.Text = "0";
            DataSet bulunanlar = Kurum.bul(textBox1.Text);
            dataGridView1.DataSource = bulunanlar.Tables[0];

        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {




        }
        private void dataGridView1_SelectionChanged_1(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential("xx@gmail.com", "xx");
                MailMessage ms = new MailMessage();
                ms.To.Add(textBox15.Text);
                ms.From = new MailAddress("xx@gmail.com");
                ms.Subject = textBox14.Text;
                ms.Body = textBox13.Text;
                client.Send(ms);
                MessageBox.Show("MAİLİNİZ GÖNDERİLDİ");
            }
            catch
            {
                MessageBox.Show("MAİLİNİZ GÖNDERİLMEDİ");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        static string baglantiyolu = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=yazilimodev;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(baglantiyolu);
            string sql = "Select Defter from ogrenci where ogrenciId=@oid";
            SqlCommand komut = new SqlCommand(sql, baglanti);
            komut.Parameters.AddWithValue("@oid", Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[1].Value.ToString()));
            baglanti.Open();
            SqlDataAdapter adaptor = new SqlDataAdapter();
            adaptor.SelectCommand = komut;
            DataSet sonuc = new DataSet();
            adaptor.Fill(sonuc);
            dataGridView2.DataSource = sonuc.Tables[0];
            baglanti.Close();
            string dosyaYolu = dataGridView2.Rows[0].Cells[0].Value.ToString();
            System.Diagnostics.Process.Start(dosyaYolu);
            MessageBox.Show("AÇILDI...");

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {


        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("STAJ ONAYLANMIŞTIR...");
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
           
            SqlConnection baglanti = new SqlConnection(baglantiyolu);
            string sql = "update ogrenci set Sigorta=@sigorta where ogrenciId=@ogrId";
            SqlCommand komut = new SqlCommand(sql, baglanti);
            komut.Parameters.AddWithValue("@ogrId", Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[1].Value.ToString()));
            if (checkBox1.Checked == true)
            {komut.Parameters.AddWithValue("@sigorta",checkBox1.Text);
                 MessageBox.Show("SİGORTA BAŞLATILDI....");
            
            }
            if (checkBox2.Checked == true)
            {
                komut.Parameters.AddWithValue("@sigorta", checkBox2.Text);
                MessageBox.Show("SİGORTA BAŞLAMADI");
            }
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("STAJ ONAYLANMIŞTIR...");
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                textBox4.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                textBox5.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                textBox2.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                textBox6.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                textBox7.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                textBox8.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
                textBox9.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
                textBox10.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
                textBox11.Text = dataGridView1.SelectedRows[0].Cells[11].Value.ToString();
                textBox12.Text = dataGridView1.SelectedRows[0].Cells[12].Value.ToString();





            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {


            DialogResult sonuc = MessageBox.Show("Çıkmak İstediğinizden Emin misiniz ?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (sonuc == DialogResult.Yes)
            {
                Form.ActiveForm.Close();
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
    }
}
