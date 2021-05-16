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
    public class DovizVTisle
    {
        // mevcut döviz seçeneklerini tablo şeklinde gönderen metot
        public static DataTable  DovizAl()
        {
            DataTable dt = new DataTable();
            var baglanti = Database.Baglan();
            string command = "SELECT DovizID, DovizKisaltma FROM tblDoviz ORDER BY DovizID";
            SqlDataAdapter dataadap = new SqlDataAdapter(command,baglanti);
            dataadap.Fill(dt);
            baglanti.Close();
            return dt;
        }
    }
}
