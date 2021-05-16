using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLibrary;
using System.Data.SqlClient;
using System.Data;

namespace EntityLibrary
{
    public class UrunVTisle
    {  
        // Mevcut ürün isimlerini elde eden metot. Piyasaya ürün eklerken ve alım-satımda kullanılır.
        public static DataTable UrunAl()
        {
            DataTable dt = new DataTable();
            var baglanti = Database.Baglan();
            // veri tabanındaki ürünler tablosundan urunID ve urun adı seçilir.
            string command = "SELECT UrunID, UrunAd FROM tblUrunler";
            SqlDataAdapter dataadap = new SqlDataAdapter(command, baglanti);
            dataadap.Fill(dt); // seçilen ürünler dt tablosuna doldurulur.
            baglanti.Close();
            return dt;
        }

        // sisteme yeni ürün ekleyen metot
        public bool UrunEkle(Urun urun)
        {
            bool result = false;
            using (var baglanti = Database.Baglan())
            {
                // eklenecek yeni ürün gerekli verileri sp_urunEkle isimli SQL Server prosedürüne
                // parametre olarak veriliyor. Yeni ürünü prosedür ekliyor.
                var command = new SqlCommand("sp_urunEkle @UrunAd, @OlcuBirimi, @Aciklama", baglanti);
                command.Parameters.Add(new SqlParameter("UrunAd", urun.UrunAd));
                command.Parameters.Add(new SqlParameter("OlcuBirim", urun.OlcuBirimiID));
                command.Parameters.Add(new SqlParameter("Aciklama", urun.Aciklama));
                baglanti.Open();
                if (command.ExecuteNonQuery() != -1) // yeni ürün ekleme başarılı ise
                {
                    result = true;
                }
                baglanti.Close();
            }
            return result;
        }

        // ürünlerin onay durumlarını görüntülemek için metot
        public static DataTable UrunOnayOnizleme()
        {
            DataTable dt = new DataTable();
            var baglanti = Database.Baglan();
            string command = "SELECT * FROM vw_UrunOnay ORDER BY OnayDurumu ASC, Tarih ASC";
            SqlDataAdapter dataadap = new SqlDataAdapter(command, baglanti);
            dataadap.Fill(dt);
            baglanti.Close();
            return dt;
        }

        // pazara eklenmek istenen ürün admin tarafından onaylanması için metot
        public bool UrunOnayla(Urun urun)
        {
            bool result = false;
            using (var baglanti = Database.Baglan())
            {
                var command = new SqlCommand("sp_urunOnayla @UrunID,@OnayDurumu", baglanti);
                command.Parameters.Add(new SqlParameter("UrunID", urun.UrunID));
                //command.Parameters.Add(new SqlParameter("OnayDurumu", urun.OnayDurumu));
                baglanti.Open();
                if (command.ExecuteNonQuery() != -1)
                {
                    result = true;
                }
                baglanti.Close();
            }
            return result;
        }
    }
}
