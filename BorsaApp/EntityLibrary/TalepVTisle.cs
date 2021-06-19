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
    public class TalepVTisle
    {
        //bu metot teklif edilen birim fiyata göre talep oluşturur.
        public bool TalepEkle(Talep talep)
        {
            bool result = false;
            using (var baglanti = Database.Baglan())
            {
// Veri tabanı sunucusundaki sp_TalepEkle prosedürüne kisiID, urunID, birim fiyat ve miktar parametrelerini göndererir.
                var command = new SqlCommand("sp_TalepEkle @KisiID, @urunID, @fiyat, @miktar", baglanti);
                command.Parameters.Add(new SqlParameter("KisiID", talep.KisiID));
                command.Parameters.Add(new SqlParameter("urunID", talep.UrunID));
                command.Parameters.Add(new SqlParameter("fiyat", talep.Fiyat));
                command.Parameters.Add(new SqlParameter("miktar", talep.Miktar));
                baglanti.Open();
                if (command.ExecuteNonQuery() != -1) // kayıt ekleme başarılı ise
                {
                    result = true;
                }
                baglanti.Close();
            }
            return result; // kayıt ekleme başarısız ise
        }

        public bool TalepKarsila(int piyasaID)
        {
            bool result = false;
            // alım emrini yerine getirme işlemi MS SQL Server'daki sp_TalepKarsila isimli prosedür tarafından yapılıyor.
            using (var baglanti = Database.Baglan())
            {
                // prosedüre PiyasaID verisi parametre olarak gönderiliyor.
                // prosedür onaylanan ürünü satın almayı bekleyen talepleri karşılıyor.
                var command = new SqlCommand("sp_TalepKarsila @PiyasaID", baglanti);
                command.Parameters.Add(new SqlParameter("PiyasaID", piyasaID));
                baglanti.Open();
                if (command.ExecuteNonQuery() != -1) // prosedür başarılı ise
                {
                    result = true;
                }
                baglanti.Close();
            }
            return result; // talep karşılama başarısız ise
        }
    }
}
