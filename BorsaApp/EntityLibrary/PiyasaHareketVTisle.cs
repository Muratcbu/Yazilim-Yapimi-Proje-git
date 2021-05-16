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
    public class PiyasaHareketVTisle
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

    }
}
