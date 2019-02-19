using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ogrenci
{
    public partial class stajbasvurusu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        static string baglantiyolu = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=yazilimodev;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        protected void Button2_Click(object sender, EventArgs e)
        {

            int stajGunu = Convert.ToInt32(TextBox6.Text) / Convert.ToInt32(TextBox8.Text);
            int kalanGun= Convert.ToInt32(TextBox6.Text) % Convert.ToInt32(TextBox8.Text);
            int stajSuresi = stajGunu * 7 + kalanGun;
            DateTime dt = Calendar1.SelectedDate.AddDays(stajSuresi);
            TextBox9.Text = dt.ToLongDateString();

            SqlConnection baglanti = new SqlConnection(baglantiyolu);
                string sql = "insert into StajBasvuru(ogrenciId,IsYeriAdi,il,IsYeriFaaliyet,Eposta,IsTel,Program,StajDonem,StajGunSayisi,hcys,StajBaslama,StajBitis) values(@oId,@IsYeriAdi,@il,@IsYeriFaaliyet,@Eposta,@IsTel,@Program,@StajDonem,@StajGunSayisi,@hcys,@StajBaslama,@StajBitis) ";
                SqlCommand komut = new SqlCommand(sql, baglanti);
            komut.Parameters.AddWithValue("@oId",Convert.ToInt32(Session["OGRENCI_ID"]));
                komut.Parameters.AddWithValue("@IsYeriAdi", TextBox1.Text);
            komut.Parameters.AddWithValue("@il", DropDownList1.SelectedItem.Text);
            komut.Parameters.AddWithValue("@IsYeriFaaliyet", TextBox2.Text);
                komut.Parameters.AddWithValue("@Eposta", TextBox3.Text);
                komut.Parameters.AddWithValue("@IsTel", Convert.ToInt32(TextBox5.Text));
              //  komut.Parameters.AddWithValue("@IsAdres", TextBox4.Text);
                komut.Parameters.AddWithValue("@Program", DropDownList2.SelectedItem.Text);
                komut.Parameters.AddWithValue("@StajDonem", DropDownList3.SelectedItem.Text);
                komut.Parameters.AddWithValue("@StajGunSayisi", Convert.ToInt32(TextBox6.Text));
                komut.Parameters.AddWithValue("@hcys",Convert.ToInt32(TextBox8.Text));
                komut.Parameters.AddWithValue("@StajBaslama", Calendar1.SelectedDate.ToLongDateString());
                komut.Parameters.AddWithValue("@StajBitis", dt.ToLongDateString());
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();

            Response.Write("<script lang='JavaScript'>alert('Başvuru Yapıldı...');</script>");
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            int stajGunu = Convert.ToInt32(TextBox6.Text) / Convert.ToInt32(TextBox8.Text);
            int kalanGun = Convert.ToInt32(TextBox6.Text) % Convert.ToInt32(TextBox8.Text);
            int stajSuresi = stajGunu * 7 + kalanGun;
            DateTime dt = Calendar1.SelectedDate.AddDays(stajSuresi);
            TextBox9.Text = dt.ToLongDateString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            Response.Redirect("anasayfa.aspx");
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}