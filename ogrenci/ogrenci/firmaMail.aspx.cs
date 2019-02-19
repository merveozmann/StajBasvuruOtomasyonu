using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

using System.Net.Mail;
using System.Net;

namespace ogrenci
{
    public partial class firmalistele : System.Web.UI.Page
    {

        string baglantiyolu = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=yazilimodev;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=yazilimodev;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        protected void Page_Load(object sender, EventArgs e)
        {
           
    

        }

protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
{

}

        protected void Button1_Click(object sender, EventArgs e)
        {


            try
            {

                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential("xxx@gmail.com", "xxx");
                MailMessage ms = new MailMessage();
                ms.To.Add(TextBox1.Text);
                ms.From = new MailAddress("xxx@gmail.com");
                ms.Subject = TextBox2.Text;
                ms.Body = TextBox3.Text;
                Attachment attach = new Attachment(Server.MapPath("~") + FileUpload1.FileName);
                ms.Attachments.Add(attach);
                client.Send(ms);
                ScriptManager.RegisterStartupScript(this, this.GetType(), "poup", "alert('basarili');", true);

            }
            catch (Exception ex)
            {
                Response.Write("hata" + ex.Message);
            }


        }

        protected void DropDownList1_SelectedIndexChanged1(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }

        protected void Button2_Click1(object sender, EventArgs e)
        {
            Response.Redirect("anasayfa.aspx");
        }
    }
}
 