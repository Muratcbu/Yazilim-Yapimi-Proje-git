using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//entity ve business katmanları include ediliyor.
using EntityLibrary;
using BusinessLibrary;

namespace Borsa
{
    public partial class frmUrunSat : Form
    {
        #region hazirlik
        int _kisiID; // urun ekleyecek kullanıcı kimlik bilgisini bu değişken taşıyacak.
        //parametreli constructor metot 
        public frmUrunSat(int kisiID) // parametre olarak oturum açan kullanıcı kimlik bilgisini alıyor.
        {
            InitializeComponent();
            _kisiID = kisiID;// oturum açan kullanıcı kimlik bilgisi formdaki _kisiID değişkenine alınıyor.
        }
        // sık kullanılacak nesneler global olarak bildiriliyor.
        DataTable dataTable = new(); // doviz cinsini ID'si ve kısaltması ile birlikte combo box a doldurmakta kullanılacak.
        DataTable dataTableUrun = new();// eklenecek ürün bilgisini ürünID'si ve ürünAdi ile birlikte combo box'a doldurmakta kullanılacak.
        Piyasa piyasa; // stoğa eklenecek ürünün bilgileri + miktar, fiyat ve kullanıcıID bilgileri bu nesnede tutulacak.
        PiyasaElle piyasaislem; // stoğa ürün ve satıcı bilgilerini taşıyacak business katman nesnesi

        private void frmUrunSat_Load(object sender, EventArgs e)
        {
            cmbDovizDoldur();// geçerli doviz kısaltmaları combo box'a yükleniyor.
            cmbUrunDoldur();// geçerli ürün isimleri combo box'a yükleniyor.
            piyasa = new Piyasa // eklenecek ürünün kullanıcı kimlik ile default döviz ve ürünID değerleri nesne başlatıcılar ile
                                // piyasa nesnesine ekleniyor.
            {
                KisiID = _kisiID,
                DovizID = Convert.ToInt32(cmbDoviz.SelectedValue),
                UrunID = Convert.ToInt32(cmbUrun.SelectedValue)
            };
        }
        private void cmbUrunDoldur() // veri tabanındaki geçerli ürün bilgilerini combo box'a doldurur.
        {
            dataTableUrun = UrunVTisle.UrunAl(); // Entity katmanından UrunID ve Urun adı bilgilerini getiren metot
            cmbUrun.ValueMember = dataTableUrun.Columns[0].ToString();// combo box değeri urunID olacak.
            cmbUrun.DisplayMember = dataTableUrun.Columns[1].ToString();// combo box içinde urun adı gösterilecek.
            cmbUrun.DataSource = dataTableUrun;// data table satırları combo box veri kaynağı oluyor.
        }
        private void cmbDovizDoldur()
        {
            dataTable = DovizVTisle.DovizAl(); // Entity katmanından dovizID ve döviz kısaltma adı bilgilerini getiren metot
            cmbDoviz.ValueMember = dataTable.Columns[0].ToString();// combo box değeri dovizID olacak.
            cmbDoviz.DisplayMember = dataTable.Columns[1].ToString();// combo box içinde doviz kısaltması gösterilecek.
            cmbDoviz.DataSource = dataTable;// data table satırları combo box veri kaynağı oluyor.
        }
        #endregion
        #region urun ekle
        private void btnMalekle_Click(object sender, EventArgs e)
        { // ürün onaya sunulmak üzere stoğa ekleniyor.
            try // exception oluşabilecek kodlar buraya yazıldı.
            {
                piyasaislem = new PiyasaElle(); // Business katmanından islem yapacak nesne
                piyasa.KisiID = _kisiID; // kullanıcı kimlik bilgisi nesneye aktarılıyor.
                //Form üzerindeki bilgiler piyasa nesnesine aktarılıyor.
                piyasa.UrunID = Convert.ToInt32(cmbUrun.SelectedValue);
                piyasa.Fiyat = Convert.ToDecimal(txtFiyat.Text);
                piyasa.DovizID = Convert.ToInt32(cmbDoviz.SelectedValue);
                piyasa.Miktar=Convert.ToDouble(txtMiktar.Text);
                // ürün stoğa PiyasaEkle business katman metodu ile ekleniyor.
                if (piyasaislem.PiyasaEkle(piyasa)) // urun stoğa başarılı bir şekilde eklendiyse
                {
                    MessageBox.Show("Yeni ürün eklendi! Onay bekliyor...!");
                }
            }
            catch // pazara yeni ürün ekleme işleminde sorun çıktıysa
            {
                MessageBox.Show("Yeni ürün eklenemedi!\n" +
                    "Ürüm miktarı veya Fiyat girerken sadece rakam kullanınız!");
            }
        }
        #endregion
        #region klavye kısayolları
        private void frmUrunSat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                btnAnaSayfa.PerformClick();
            }
            if (e.Control && e.KeyCode == Keys.S)
            {
                btnAnaSayfa.PerformClick();
            }
            if (e.KeyCode == Keys.F2)
            {
                btnMalekle.PerformClick();
            }
            if (e.Control && e.KeyCode == Keys.E)
            {
                btnMalekle.PerformClick();
            }
        }
        #endregion
    }
}
