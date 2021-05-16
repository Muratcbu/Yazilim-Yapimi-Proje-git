using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//business ve entity sınıfları include ediliyor.
using BusinessLibrary;
using EntityLibrary;

namespace Borsa
{   public partial class frmParaEkle : Form
    {
        int _kisiID;//Ana formdan gele kişi ID bu değişkende tutulacak
        public frmParaEkle(int kisiID)
        {
            InitializeComponent();
            _kisiID = kisiID;// diğer formlardan gelen kişiID bilgisi bu değişkende.
        }
        // sık kullanılcak nesneler global olarak bildiriliyor.
        public Bakiye bakiye;
        BakiyeElle bakiyeislem;
        #region denetimlerin doldurulması
        private void frmParaEkle_Load(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();// döviz combobox ındaki veriler datatable dan alıncak
            dataTable = DovizVTisle.DovizAl();//döviz verileri data table a aktarılıyor.
            cmbDoviz.ValueMember = dataTable.Columns[0].ToString();//doviz ID değer sütunu olacak
            cmbDoviz.DisplayMember = dataTable.Columns[1].ToString();//döviz kısaltması gösterilecek
            cmbDoviz.DataSource = dataTable;//combo box data table daki verilerle dolduruluyor.
            bakiye = new Bakiye();//eklenecek yeni para ile ilgili bilgi ve işlemler bakiye nesnesi ile olacak
            bakiye.KisiID = _kisiID;//hangi kişinin para ekleme işlemleri yapılacağı nesneye aktarılıyor.
            bakiye.Dovizcinsi = Convert.ToInt32(cmbDoviz.SelectedValue);//seçilen döviz cinsi nesneye aktarılıyor.
            //oturum açan kullanıcının mevcut toplam bakiyesi metin kutusunda gösterilecek.
            txtMevcutpara.Text = BakiyeVTisle.ToplamBakiyeGoster(bakiye).ToString();
        }
        #endregion
        #region para eklenmesi
        private void button1_Click(object sender, EventArgs e)
        {
            try // exception oluşabilecek kodlar try içinde yazılıyor.
            {
                bakiye = new Bakiye();
                bakiyeislem = new BakiyeElle();//business katmanda çalışacak nesne.
                bakiye.KisiID = _kisiID;// oturum açan kişi para eklenecek kişi olacak.
                //girilen para ve seçilen döviz cinsi değerlerinin nesneye aktarılması.
                bakiye.Bakiyepara = Convert.ToDecimal(txtParamiktar.Text);
                bakiye.Dovizcinsi = Convert.ToInt32(cmbDoviz.SelectedValue);
                if (bakiyeislem.BakiyeEkle(bakiye))// para ekleme başarılı ise.
                {
                    MessageBox.Show("Yeni para eklendi! Onay bekliyor...!");
                }
            }
            catch // para ekleme başarısız olduysa.
            {
                MessageBox.Show("Yeni para eklenemedi!\n" +
                    "Para miktarını girerken sadece rakam kullanınız!");
            }
        }
        #endregion
        #region klavye kısayolları
        private void frmParaEkle_KeyDown(object sender, KeyEventArgs e)
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
                btnParaekleme.PerformClick();
            }
            if (e.Control && e.KeyCode == Keys.E)
            {
                btnParaekleme.PerformClick();
            }
        }
        #endregion
    }
}
