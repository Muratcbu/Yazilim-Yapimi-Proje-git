using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DataLibrary
{
    public class Database
    {
        private static Database instance = null;
        

        // Ayrı thread'lerde tekrar nesne oluşmasını önlemek için oluşturuldu.
        //Burada Database sınıfı için singleton tasarım deseni uygulanıyor.
        private static readonly object padlock = new object();

        // Nesneye dışarıdan erişim engelleniyor.
        private Database() { }

        public static Database CreateInstance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new Database();
                    }

                    return instance;
                }
            }
        }

        
        // MS SQL Server bağlantısı sağlayan metot.
        public static SqlConnection Baglan()
        {
            try
            {
                // bağlantı string'i app.config dosyasından okunuyor.
                // string adı= BorsaVTBaglantiStr
                return new SqlConnection(ConfigurationManager.ConnectionStrings["BorsaVTBaglantiStr"].ConnectionString);
            }
            catch
            {   // MS SQL Server bağlantısı başarısız olduysa.
                MessageBox.Show("Veri tabanına bağlantıda hata oluştu...!");
                return null; ;
            }
        }
    }
}
