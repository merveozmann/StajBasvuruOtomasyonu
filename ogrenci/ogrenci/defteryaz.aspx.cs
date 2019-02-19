using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ogrenci
{
    public partial class defteryaz : System.Web.UI.Page
    {
        static string baglantiyolu = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=yazilimodev;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            FileUpload fd = new FileUpload();
            if (FileUpload1.FileContent != null)
            {
                FileUpload1.SaveAs(Server.MapPath("~/Masaüstü/") + FileUpload1.FileName);


                SqlConnection baglanti = new SqlConnection(baglantiyolu);
                string sql = "update ogrenci set defter=@defter where ogrenciAdi=@oAdi";
                SqlCommand komut = new SqlCommand(sql, baglanti);
                string dosyaAdi = FileUpload1.FileName;
                komut.Parameters.AddWithValue("@defter", fd.FileName);
                komut.Parameters.AddWithValue("@oAdi", "MERVE");
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();

                sql = "select Defter from ogrenci where ogrenciAdi=@oAdi";
                komut = new SqlCommand(sql, baglanti);
                komut.Parameters.AddWithValue("@oAdi", "YÜSRA");
                SqlDataAdapter adaptor = new SqlDataAdapter();
                adaptor.SelectCommand = komut;
                DataSet sonuc = new DataSet();
                adaptor.Fill(sonuc);
                GridView1.DataSource = sonuc.Tables[0];
                /// LinkButton1.Text = sonuc.Tables[0].Rows[0]["defter"].ToString();

                //System.Diagnostics.Process.Start(LinkButton1.Text);
            }

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            //  System.Diagnostics.Process.Start(LinkButton1.Text);

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
           
           
                FileUpload1.SaveAs(Server.MapPath("~") + FileUpload1.FileName);

            Response.Write("<script lang='JavaScript'>alert('"+ Server.MapPath("~") + FileUpload1.FileName + "');</script>");
            SqlConnection baglanti = new SqlConnection(baglantiyolu);
                string sql = "update ogrenci set Defter=@defter where ogrenciId=@oid";
                SqlCommand komut = new SqlCommand(sql, baglanti);
                string dosyaAdi = Server.MapPath("~")+FileUpload1.FileName;
                komut.Parameters.AddWithValue("@defter",dosyaAdi);
                komut.Parameters.AddWithValue("@oid",Convert.ToInt32(Session["OGRENCI_ID"]));
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();

            }
        }
    
}