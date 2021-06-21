using System;
using System.Data;
using System.Windows.Forms;
using EntityLibrary;
using ExcelLibrary;

namespace Borsa
{
    public partial class frmRapor : Form
    {
        #region Hazırlık
        int _kisiID; // ana formdan gelen oturum açma kimlik bilgisi bu değişkende.
        DataTable dataTable; // sorgudan dönen rapor sonuçlarını tutacak nesne

        //parametreli form yapıcı metodu
        public frmRapor(int kisiID)
        {
            InitializeComponent();
            _kisiID = kisiID;
        }

        #endregion

        #region grid güncelleme ve raporlama metodu
        //data grid verilerini veri tabanı ile eşitler.
        private void gridGuncelle()
        {
            DataSet ds = new DataSet("New_DataSet");
            dataTable = PiyasaHareketVTisle.Rapor(_kisiID,dtpBaslangic.Value,dtpBitis.Value);
            dgvRapor.DataSource = dataTable;

            // data set ve data table için yerel thread ler ayarlanıyor.
            ds.Locale = System.Threading.Thread.CurrentThread.CurrentCulture;
            dataTable.Locale = System.Threading.Thread.CurrentThread.CurrentCulture;

            DateTime raportarih = DateTime.Now; // dosya adında anlık tarih-saat kullanmak için.

            // dosya adı hazırlanıyor..
            string dosyaadirapor ="..\\..\\..\\..\\Raporlar\\"+_kisiID.ToString()+"kisisi"
                +raportarih.ToShortDateString()
                +raportarih.Hour.ToString()+raportarih.Minute.ToString()
                +raportarih.Second.ToString()+".xls";
            MessageBox.Show("Excel dosyası projenin bulunduğu klasörde Raporlar dosyasına\n" +
                "kişiID ve rapor tarihi bilgisi ile (gün ay yıl saat dakika saniye.xls) yazılıyor..\n"+dosyaadirapor);
            
            // data table data sete yazılıyor.
            ds.Tables.Add(dataTable);

            // Excel dosyası data setten okunup dosya belirtilen konuma yazılıyor.
            ExcelLibrary.DataSetHelper.CreateWorkbook(dosyaadirapor, ds);            
        }
        #endregion

        #region rapor gösterme ve dosya oluşturma metodu çağırılıyor
        private void btnRaporGoster_Click(object sender, EventArgs e)
        {
            gridGuncelle(); // datagrid güncelleniyor ve excel dosyası olarak rapor oluşturuluyor..!
        }

        #endregion

        #region klavye kısayolları
        private void frmRapor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                btnAnasayfa.PerformClick();
            }
            if (e.Control && e.KeyCode == Keys.S)
            {
                btnAnasayfa.PerformClick();
            }

            if (e.KeyCode == Keys.R)
            {
                btnRaporGoster.PerformClick();
            }
            
        }
        #endregion
    }
}
