using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ogrenci
{
    public partial class ogrencigiris : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string kulmail = TextBox1.Text;
            int sifre = Convert.ToInt32(TextBox2.Text);
            bool kontrol = ogrenci.ogrencivarmi(kulmail, sifre);
            if (kontrol == false)
                Response.Write("YANLIŞ KULLANICI E-MAİLİ VE/VEYA ŞİFRE GİRDİNİZ...");
            else
            {
                Session["OTURUMAC"] = true;
                Session["E-MAİL"] = kulmail;
                Session["OGRENCI_ID"] = ogrenci.ogrenciIdBul(kulmail,sifre);
                Response.Write(Session["OGRENCI_ID"]);
                Response.Redirect("anasayfa.aspx");
            }
        }
    }
}