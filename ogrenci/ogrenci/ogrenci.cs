using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace ogrenci
{
    public class ogrenci
    {
        static string baglantiyolu = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=yazilimodev;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        internal static void stajbasvuruekle(object ısAdi, object ısYeriFaaliyet, object ısYeriEposta, object ısYeriTel, object adres, object program, object stajDonem, object gunSayisi, object hCGS, object stajBaslama, object stajBitis)
        {
            throw new NotImplementedException();
        }

        public static bool ogrencivarmi(string email, int sifre)
        {
            SqlConnection baglanti = new SqlConnection(baglantiyolu);
            string sql = "select * from ogrenci where Email=@pmail and Sifre=@ps";
            SqlCommand komut = new SqlCommand(sql, baglanti);
            komut.Parameters.AddWithValue("@pmail", email);
            komut.Parameters.AddWithValue("@ps", sifre);
            SqlDataAdapter adaptor = new SqlDataAdapter(komut);
            DataSet sonuc = new DataSet();
            baglanti.Open();
            adaptor.Fill(sonuc);
            baglanti.Close();

            bool sonuc1 = false;
            if (sonuc.Tables[0].Rows.Count > 0)
                sonuc1 = true;
            return sonuc1;


        }
        public static int ogrenciIdBul(string email, int sifre)
        {
            SqlConnection baglanti = new SqlConnection(baglantiyolu);
            string sql = "select ogrenciId from ogrenci where Email=@pmail and Sifre=@ps";
            SqlCommand komut = new SqlCommand(sql, baglanti);
            komut.Parameters.AddWithValue("@pmail", email);
            komut.Parameters.AddWithValue("@ps", sifre);
            SqlDataAdapter adaptor = new SqlDataAdapter(komut);
            DataSet sonuc = new DataSet();
            baglanti.Open();
            adaptor.Fill(sonuc);
            baglanti.Close();

            int oId = Convert.ToInt32(sonuc.Tables[0].Rows[0]["ogrenciId"]);
            
            return oId;


        }
        
        public static void stajbasvuruekle(string IsYeriAdi,string IsYeriFaaliyet,string IsYeriEposta, int IsYeriTel, string adres,string program, string StajDonem, int GunSayisi,int HCGS, int StajBaslama, int StajBitis)
        {

            SqlConnection baglanti = new SqlConnection(baglantiyolu);
            string sql = "insert into StajBasvuru(StajId,ogrenciId,IsYeriAdi,IsYeriFaaliyet,Eposta,IsTel,IsAdres,Program,StajDonem,StajGunSayisi,hcys,StajBaslama,StajBitis) values(@StajId,@ogrenciId,@IsYeriAdi,@IsYeriFaaliyet,@Eposta,@IsTel,@IsAdres,@Program,@StajDonem,@StajGunSayisi,@hcys,@StajBaslama,@StajBitis) ";
            SqlCommand komut = new SqlCommand(sql, baglanti);
            komut.Parameters.AddWithValue("@IsYeriAdi",IsYeriAdi);
            komut.Parameters.AddWithValue("@IsYeriFaaliyet", IsYeriFaaliyet);
            komut.Parameters.AddWithValue("@Eposta", IsYeriEposta);
            komut.Parameters.AddWithValue("@IsTel", IsYeriTel);
            komut.Parameters.AddWithValue("@Isadres", adres);
            komut.Parameters.AddWithValue("@Program", program );
            komut.Parameters.AddWithValue("@StajDonem", StajDonem);
            komut.Parameters.AddWithValue("@StajGunSayisi", GunSayisi);
            komut.Parameters.AddWithValue("@hcys", HCGS);
            komut.Parameters.AddWithValue("@StajBaslama",StajBaslama);
            komut.Parameters.AddWithValue("@StajBitis", StajBitis);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
    }
}