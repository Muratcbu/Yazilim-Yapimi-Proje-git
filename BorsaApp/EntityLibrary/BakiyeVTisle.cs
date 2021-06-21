using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLibrary;
using System.Data.SqlClient;
using System.Data;
using System.Xml;
using System.Windows.Forms;

namespace EntityLibrary
{
    // kasaya eklenen paralar ile ilgili veri tabanı işlemlerinde kullanılacak sınıf ve metotları
    public class BakiyeVTisle
    {
        //bu metot kasaya para ekler.
        public bool BakiyeEkle(Bakiye bakiye)
        {
            bool result = false;
            using (var baglanti = Database.Baglan())
            {
                // Veri tabanı sunucusundaki sp_bakiyeEkle prosedürüne kisiID, bakiye ve döviz cinsi parametrelerini
                //göndererir
                var command = new SqlCommand("sp_bakiyeEkle @KisiID, @Bakiye, @DovizCinsi", baglanti);
                command.Parameters.Add(new SqlParameter("KisiID", bakiye.KisiID));
                command.Parameters.Add(new SqlParameter("Bakiye", bakiye.Bakiyepara));
                command.Parameters.Add(new SqlParameter("DovizCinsi", bakiye.Dovizcinsi));
                baglanti.Open();
                if (command.ExecuteNonQuery() != -1) // kayıt ekleme başarılı ise
                {
                    result = true;
                }
                baglanti.Close();
            }
            return result; // kayıt ekleme başarısız ise
        }

        // kişinin verilen döviz cinsinden toplam bakiyesini hesaplayan metot
        public static decimal ToplamBakiyeGoster(Bakiye bakiye)
        {
            decimal toplam = 0;
            using (var baglanti = Database.Baglan())
            {
                baglanti.Open(); // veri tabanı bağlantısı açılır
                // kisiID ve Dovizcinsi parametreleri MS SQL Server'daki f_ToplamBakiye fonksiyonuna gönderilir.
                using (var cmd = new SqlCommand("SELECT dbo.f_ToplamBakiye(@kisiID,@DovizCinsi)", baglanti))
                {
                    cmd.Parameters.AddWithValue("@kisiID", bakiye.KisiID);
                    cmd.Parameters.AddWithValue("@DovizCinsi", bakiye.Dovizcinsi);
                    if(cmd.ExecuteScalar()!=DBNull.Value)
                        toplam =(decimal) cmd.ExecuteScalar();
                }
                baglanti.Close();
            }
            return toplam;
        }

        // bakiye onaylamadan önce tüm bakiye durumlarını MS SQL Server'daki vw_BakiyeOnay görünümünden seçen metot
        public static DataTable BakiyeOnayOnizleme()
        {
            DataTable dt = new DataTable();
            var baglanti = Database.Baglan();
            string command = "SELECT * FROM vw_BakiyeOnay ORDER BY OnayDurumu ASC, Tarih ASC";
            SqlDataAdapter dataadap = new SqlDataAdapter(command, baglanti);
            dataadap.Fill(dt);
            baglanti.Close();
            return dt; // dönen sorgu sonucu dt tablosu ile gönderiliyor.
        }

        // kullanıcı adına (username) göre toplam net bakiyeyi hesaplayan metot
        public static DataTable KullaniciAdinaGoreBakiyeArama(string kullaniciadi)
        {
            DataTable dt = new DataTable();
            var baglanti = Database.Baglan();
            // MS SQL Server'daki f_KullaniciAdinaGoreBakiyeAra fonksiyonun parametre gönderiliyor.
            string command = "SELECT * FROM dbo.f_KullaniciAdinaGoreBakiyeAra('"+kullaniciadi+"') ORDER BY OnayDurumu ASC, Tarih ASC";
            SqlDataAdapter dataadap = new SqlDataAdapter(command, baglanti);
            dataadap.Fill(dt);
            baglanti.Close();
            return dt; // sonuç dt tablosu ile gönderiliyor.
        }

        // admin tarafından bakiye onaylama metodu
        public bool BakiyeOnayla(Bakiye bakiye, string dovizcinsi)
        {
            bool result = false;
            if(dovizcinsi!="TL") // döviz cinsi TL değilse kur dönüşümü yapılacak.
            {
                string xmlcanlidoviz = "https://www.tcmb.gov.tr/kurlar/today.xml";// canlı döviz bilgilerinin alınacağı adres
                var xmldoc = new XmlDocument();// xmldoc isimli xml belgesi tanılanıyor.
                xmldoc.Load(xmlcanlidoviz);// xml belgesine url yükleniyor.


                string xmldovizal = "Tarih_Date/Currency[@Kod='" + dovizcinsi + "']/BanknoteBuying";
                // onaylanan para biriminin TL efektif alış karşılığı dovizTL stringine alınıyor.
                string dovizTL = xmldoc.SelectSingleNode(xmldovizal).InnerXml;
                
                // binler basamağı ve ondalık ayırıcı düzenleniyor!
                dovizTL = dovizTL.Replace('.', ','); // kaynak url'de ondalık ayırıcı olarak nokta kullanılıyor. 
                                                    // Türkiye bölgesel ayarlarında ise ondalık ayırıcı virgüldür.
                decimal yenibakiye = bakiye.Bakiyepara * Convert.ToDecimal(dovizTL);
                MessageBox.Show("Onaylanan para biriminin birim TL karşılığı: " + dovizTL+                
                    "\nve onaylanacak bakiye= "+dovizTL+"*"+bakiye.Bakiyepara.ToString()+"="+yenibakiye.ToString()+"TL");
                bakiye.Bakiyepara = yenibakiye;
            }

            using (var baglanti = Database.Baglan())
            {
                // MS SQL Server'daki sp_bakiyeOnayla prosedürüne bakiyeID, onaydurumu ve bakiye parametreleri gönderiliyor.
                var command = new SqlCommand("sp_bakiyeOnayla @BakiyeID,@OnayDurumu,@bakiye", baglanti);
                command.Parameters.Add(new SqlParameter("BakiyeID", bakiye.BakiyeID));
                command.Parameters.Add(new SqlParameter("OnayDurumu", bakiye.OnayDurumu));
                command.Parameters.Add(new SqlParameter("bakiye", bakiye.Bakiyepara));
                baglanti.Open();
                if (command.ExecuteNonQuery() != -1) // bakiye onaylama başarılı ise
                {
                    result = true;
                }
                baglanti.Close();
            }
            return result;
        }
    }
}
