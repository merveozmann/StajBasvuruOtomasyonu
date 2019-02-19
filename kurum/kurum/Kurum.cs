using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace kurum
{
    class Kurum
    {
        static string baglantiyolu = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=yazilimodev;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public static DataSet kurumgiris(string kullaniciadi, int sifre)
        {
            SqlConnection baglanti = new SqlConnection(baglantiyolu);
            string sql = "select * from Kurum where KurumAdi=@fkuladi and Sifre=@fkulsif ";
            SqlCommand komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = sql;
            komut.Parameters.Clear();
            komut.Parameters.AddWithValue("@fkuladi", kullaniciadi);
            komut.Parameters.AddWithValue("@fkulsif", sifre);
            SqlDataAdapter adaptor = new SqlDataAdapter();
            adaptor.SelectCommand = komut;
            DataSet sonucds = new DataSet();
            baglanti.Open();
            adaptor.Fill(sonucds);
            baglanti.Close();

            return sonucds;
         }

        public static DataSet bul(string isim)
        {
            SqlConnection baglanti = new SqlConnection(baglantiyolu);
            //string sql = "select ogrenci.ogrenciId, ogrenci.ogrenciNo  from StajBasvuru inner join ogrenci on ogrenci.ogrenciId=StajBasvuru.ogrenciId where ogrenci.ogrenciId=@oId";
            //string sql = "select * from StajBasvuru inner join ogrenci on ogrenci.ogrenciId=StajBasvuru.ogrenciId where ogrenci.ogrenciId=@oId";
            string sql = "select * from StajBasvuru inner join ogrenci on ogrenci.ogrenciId=StajBasvuru.ogrenciId where ogrenci.ogrenciNo=@oId";
            SqlCommand komut = new SqlCommand(sql, baglanti);
            // komut.Parameters.AddWithValue("@oId", Convert.ToInt32(isim));
            komut.Parameters.AddWithValue("@oId", isim);
            SqlDataAdapter adaptor = new SqlDataAdapter();
            adaptor.SelectCommand = komut;
            DataSet sonucara = new DataSet();
            baglanti.Open();
            adaptor.Fill(sonucara);
            baglanti.Close();
            return sonucara;

        }
    }/*  SqlConnection baglanti = new SqlConnection(baglantiyolu);
            string sql = "select Kategori.kategoriid,Kategori.kategoriadi,Kategori.kategoriaciklamasi from Kategori inner join RestoranKategori on RestoranKategori.kategoriid=Kategori.kategoriid where RestoranKategori.restoranid=" + restoranid;
            SqlCommand komut = new SqlCommand(sql,baglanti);*/

}
