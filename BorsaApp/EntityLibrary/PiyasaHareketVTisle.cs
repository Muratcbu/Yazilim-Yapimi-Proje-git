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
    public class PiyasaHareketVTisle:PiyasaHareket
    {
        // Veri tabanına yeni bir satış kaydı eklemek için kullanılan metot
        public bool PiyasaHareketEkle(PiyasaHareket piyasaHareket)
        {
            bool result = false;
            using (var baglanti = Database.Baglan())
            {
                // MS SQL Server sp_piyasaHareketEkle prosedürüne gerekli parametreler gönderilyor.
                // hareketID ve tarih kayıtları prosedür tarafından otomatik yapılıyor.
                // bu kayıt ekleme ile tetiklenen trg_PiyasaBakiyeDegistir isimli tetikleyici
                // alıcının bakiyesini satış miktarı kadar azaltıp, satıcınınkini de arttırırken
                // satıcının veri tabanındaki ilgili ürün stoğunu da satış miktarı kadar azaltır.
                var command = new SqlCommand("sp_piyasaHareketEkle @piyasaID, @aliciID, @saticiID, @miktar", baglanti);
                command.Parameters.Add(new SqlParameter("piyasaID", piyasaHareket.PiyasaID));
                command.Parameters.Add(new SqlParameter("aliciID", piyasaHareket.AliciID));
                command.Parameters.Add(new SqlParameter("saticiID", piyasaHareket.SaticiID));
                command.Parameters.Add(new SqlParameter("miktar", piyasaHareket.Miktar));
                baglanti.Open();
                if (command.ExecuteNonQuery() != -1) // yeni satış kaydı başarılı ise
                {
                    result = true;
                }
                baglanti.Close();
            }
            return result;
        }

        // kisiID, başlangıç ve bitiş tarihleri girildiğinde kişinin iki tarih arasındaki alım-satım
        // hareketlerini bir data table nesnesinde veren metot
        public static DataTable Rapor(int kisiID, DateTime baslangic, DateTime bitis)
        {
            string ilktarihstr, sontarihstr;
            DateTime takasTarih; //ilk tarih son tarihten sonra seçilmişse bunu düzeltirken kullanilacak nesne

            if (baslangic > bitis)// ilk tarih son tarihten buyukse yer değiştirilmeli
            {                     // çünkü SQL sorgusundaki Between'de onde küçük değer yazılmalı.
                takasTarih = baslangic;
                baslangic = bitis;
                bitis = takasTarih;
            }

            // sorguya parametre olarak geçirilecek tarih değerleri uygun biçimde string değer yapılıyor..
            ilktarihstr = baslangic.Year.ToString() + "-" + baslangic.Month.ToString() + "-" + baslangic.Day.ToString();
            sontarihstr = bitis.Year.ToString() + "-" + bitis.Month.ToString() + "-" + bitis.Day.ToString();

            DataTable dt = new DataTable();
            var baglanti = Database.Baglan();
            // MS SQL Server'daki f_TariheGoreHareket fonksiyonuna parametre gönderiliyor.
            string command = "SELECT * FROM dbo.f_TariheGoreHareket(" + kisiID.ToString() + ",'"+ilktarihstr+"','"+sontarihstr+"')";
            SqlDataAdapter dataadap = new SqlDataAdapter(command, baglanti);
            dataadap.Fill(dt);
            baglanti.Close();
            return dt; // sonuç dt tablosu ile gönderiliyor.
        }

    }
}

