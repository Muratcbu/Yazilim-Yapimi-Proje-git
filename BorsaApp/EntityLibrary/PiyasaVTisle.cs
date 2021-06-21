using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLibrary;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace EntityLibrary
{
    public class PiyasaVTisle
    {
        // kullanıcının eklediği parayı veri tabanına kaydeden metot.
        public bool PiyasaEkle(Piyasa piyasa)
        {
            bool result = false;

            // eklenen para ile ilgili parametreler sp_piyasaEkle isimli veri tabanı prosedürüne gönderilir.
            // yeni kaydı saklı prosedür yapar.
            using (var baglanti = Database.Baglan())
            {
                var command = new SqlCommand("sp_piyasaEkle @KisiID, @UrunID, @Fiyat, @DovizID, @Miktar", baglanti);
                command.Parameters.Add(new SqlParameter("KisiID", piyasa.KisiID));
                command.Parameters.Add(new SqlParameter("UrunID", piyasa.UrunID));
                command.Parameters.Add(new SqlParameter("Fiyat", piyasa.Fiyat));
                command.Parameters.Add(new SqlParameter("DovizID", piyasa.DovizID));
                command.Parameters.Add(new SqlParameter("Miktar", piyasa.Miktar));
                baglanti.Open();
                if (command.ExecuteNonQuery() != -1) // para ekleme başarılı ise.
                {
                    result = true;
                }
                baglanti.Close();
            }
            return result;
        }

        // kisiID'si ve Döviz cinsi parametre olarak verilen kişinin toplam bakiyesini hesaplayan metot.
        public static decimal ToplamPiyasaGoster(Piyasa piyasa)
        {
            decimal toplam = 0;
            using (var baglanti = Database.Baglan())
            {
                baglanti.Open();
                // kişiID ve döviz cinisi MS SQL Server'daki f_ToplamPiyasa fonksiyonuna gönderilir.
                // toplam bakiye tutarını veri tabanı fonksiyonu hesaplar.
                using (var cmd = new SqlCommand("SELECT dbo.f_ToplamPiyasa(@kisiID,@DovizCinsi)", baglanti))
                {
                    cmd.Parameters.AddWithValue("@kisiID", piyasa.KisiID);
                    cmd.Parameters.AddWithValue("@DovizCinsi", piyasa.DovizID);
                    if(cmd.ExecuteScalar()!=DBNull.Value) // toplam bakiye hesaplanabildiyse
                        toplam =(decimal) cmd.ExecuteScalar();// dönen sonuç toplam değişkenine aktarılır.
                }
                baglanti.Close();
            }
            return toplam;
        }

        // admin tarafından eklenen yeni paranın onaylanması metodu
        public static DataTable PiyasaOnayOnizleme()
        {
            DataTable dt = new DataTable();
            var baglanti = Database.Baglan();
            // veri tabanı sunucusundaki vw_PiyasaOnay görünümünden eklenen paralar ve onay durumları
            // ile ilgili bilgiler onaylanmayan kayıtlar önce gösterilecek şekilde seçiliyor.
            string command = "SELECT * FROM vw_PiyasaOnay ORDER BY onaydurumu ASC, tarih ASC";
            SqlDataAdapter dataadap = new SqlDataAdapter(command, baglanti);
            dataadap.Fill(dt);
            baglanti.Close();
            return dt; // sonuç dt tablosu olarak gönderiliyor.
        }

        // bu metot kullanıcı adı (user name) parametresi ile para ekleme kayıtlarını döndürür.
        public static DataTable KullaniciAdinaGorePiyasaArama(string kullaniciadi)
        {
            DataTable dt = new DataTable();
            var baglanti = Database.Baglan();
            // f_KullaniciAdinaGorePiyasaAra fonksiyonuna kullanıcı adı parametre olarak veriliyor.
            // dönen sonuç onaylanmamış kayıtlar önce olacak şekilde dt tablosuna dolduruluyor.
            string command = "SELECT * FROM dbo.f_KullaniciAdinaGorePiyasaAra('"+kullaniciadi+"') ORDER BY onaydurumu ASC, tarih ASC";
            SqlDataAdapter dataadap = new SqlDataAdapter(command, baglanti);
            dataadap.Fill(dt);
            baglanti.Close();
            return dt; // sonuç dt tablosu olarak gönderiliyor.
        }

        // eklenen ürünün onaylanması işlemleri için kullanılan metot.
        public bool PiyasaOnayla(Piyasa piyasa)
        {
            bool result = false;
            // Onay işlemi MS SQL Server'daki sp_piyasaOnayla isimli prosedür tarafından yapılıyor.
            using (var baglanti = Database.Baglan())
            {
                // prosedüre PiyasaID ve Onaydurumu verileri parametre olarak gönderiliyor.
                // prosedür onay bekleyen ilgili kullanıcıya ait para miktarını onaylandı şeklinde güncelliyor.
                var command = new SqlCommand("sp_piyasaOnayla @PiyasaID,@OnayDurumu", baglanti);
                command.Parameters.Add(new SqlParameter("PiyasaID", piyasa.PiyasaID));
                command.Parameters.Add(new SqlParameter("OnayDurumu", piyasa.Onaydurumu));
                baglanti.Open();
                if (command.ExecuteNonQuery() != -1) // onaylama başarılı ise
                {
                    result = true;
                }
                baglanti.Close();
            }
            return result;
        }

        // ürün alım-satımı ekranında talep edilen ürünün toplam stok miktarını bulan metot.
        public static double ToplamStokGoster(Piyasa piyasa)
        {
            double toplam = 0;
            using (var baglanti = Database.Baglan())
            {
                baglanti.Open();
                // talep edilen ürünün ID ve döviz cinsi bilgileri MS SQL Server'daki 
                // f_ToplamStok isimli fonksiyona parametre olarak gönderiliyor.
                using (var cmd = new SqlCommand("SELECT dbo.f_ToplamStok(@urunID,@dovizID)", baglanti))
                {
                    cmd.Parameters.AddWithValue("@urunID", piyasa.UrunID);
                    cmd.Parameters.AddWithValue("@dovizID", piyasa.DovizID);
                    if (cmd.ExecuteScalar() != DBNull.Value) // f_ToplamStok fonksiyonundan bir değer döndüyse
                        toplam = (double)cmd.ExecuteScalar();// toplam değişkenine aktarılıyor.
                }
                baglanti.Close();
            }
            return toplam;
        }

        /* metot overloading yapılıyor. Alım emir ekranında piyasa nesnesine ek olarak
         * birim fiyat teklifi de parametre olarak geliyor ancak metot adı aynı */
        public static double ToplamStokGoster(Piyasa piyasa, string fiyatTeklif)
        {
            double toplam = 0, hedefFiyat=0;
            try
            {
                hedefFiyat = Convert.ToDouble(fiyatTeklif);
                using (var baglanti = Database.Baglan())
                {
                    baglanti.Open();
                    // talep edilen ürünün ID, döviz cinsi ve birim fiyat teklifi degerleri MS SQL Server'daki 
                    // f_TeklifToplamStok isimli fonksiyona parametre olarak gönderiliyor.
                    using (var cmd = new SqlCommand("SELECT dbo.f_TeklifToplamStok(@urunID,@dovizID,@HedefFiyat)", baglanti))
                    {
                        cmd.Parameters.AddWithValue("@urunID", piyasa.UrunID);
                        cmd.Parameters.AddWithValue("@dovizID", piyasa.DovizID);
                        cmd.Parameters.AddWithValue("@HedefFiyat",hedefFiyat);
                        if (cmd.ExecuteScalar() != DBNull.Value) // f_ToplamStok fonksiyonundan bir değer döndüyse
                            toplam = (double)cmd.ExecuteScalar();// toplam değişkenine aktarılıyor.
                    }
                    baglanti.Close();
                }
            }
            catch
            {
                MessageBox.Show("Birim fiyat teklifini sayısal olarak giriniz..!");
            }
                return toplam;
            
        }

        // ürün alım-satımı yapılırken talep edilen üründen mevcut stok miktarlarını bulan metot.
        public static DataTable UygunStoklar(int urunID, int dovizID)
        {
            DataTable dt = new DataTable();
            var baglanti = Database.Baglan();
            // talep edilen ürün ve döviz cinsi ile ilgili parametreler MS SQL Server f_UygunStoklar
            // fonksiyonuna veriliyor. Fonksiyon uygun sonuçları en düşük fiyat en önce olacak şekilde
            // tablo olarak veriyor.
            string command = "SELECT * FROM dbo.f_UygunStoklar(" + urunID + ","+dovizID+") ORDER BY fiyat ASC, tarih ASC";
            SqlDataAdapter dataadap = new SqlDataAdapter(command, baglanti);
            dataadap.Fill(dt); // f_UygunStoklar fonksiyonundan dönen sonuç dt tablosuna dolduruluyor.
            baglanti.Close();
            return dt;
        }
    }
}
