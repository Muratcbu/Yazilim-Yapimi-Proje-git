using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml; // canlı döviz bilgisi xml işlemleri okumak için
//entity ve business katmanları include ediliyor.
using EntityLibrary;
using BusinessLibrary;
using System.Net;

namespace Borsa
{
    public partial class frmParaOnayla : Form
    {
        public frmParaOnayla()
        {
            InitializeComponent();
        }
        #region hazırlık
        //sık kullanılacak nesneler global olarak bildiriliyor.
        public Bakiye bakiye;
        BakiyeElle bakiyeislem;
        DataTable dataTable;
        
        private void frmParaOnayla_Load(object sender, EventArgs e)
        {
            //data grid verilerle dolduruluyor.
            gridGuncelle();
            //data grid bazı sütunları salt okunur yapılıyor.
            dgv.Columns[0].ReadOnly = true;
            dgv.Columns[1].ReadOnly = true;
            dgv.Columns[2].ReadOnly = true; 
            dgv.Columns[3].ReadOnly = true;
            dgv.Columns[4].ReadOnly = true;
            dgv.Columns[6].ReadOnly = true;
        }
        #endregion
        #region onay işlemleri
        private void dgv_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {   
            //data gridteki onay durumu değiştirildiğinde bu değişiklik veri tabanına yansıtılacak
            try // exception oluşabilecek satırlar buraya yazılıyor.
            {
                bakiye = new Bakiye();// entity layer nesnesi.
                bakiyeislem = new BakiyeElle();//business layer nesnesi.
                //data grid teki onaylanacak para ID, onay durumu ve onaylanacak bakiye nesneye aktarılıyor.
                bakiye.BakiyeID = Convert.ToInt32(dgv.CurrentRow.Cells[0].Value.ToString());
                bakiye.OnayDurumu= Convert.ToInt32(dgv.CurrentRow.Cells[5].Value.ToString());
                bakiye.Bakiyepara = Convert.ToDecimal(dgv.CurrentRow.Cells[3].Value.ToString());
                
                //onaylanacak bakiyenin doviz türü etkin satırdan okunuyor.
                string dovizcinsi = dgv.CurrentRow.Cells[4].Value.ToString();


                // onay durumu olarak geçersiz bir değer girildiyse
                if (bakiye.OnayDurumu!=0 && bakiye.OnayDurumu!=1)
                {
                    MessageBox.Show("Onay Durumu olarak 0 veya 1 dışında değer girmeyiniz!");
                    return;
                }
                // onay durumu olarak geçerli bir değer girildiyse ve
                if (bakiyeislem.BakiyeOnayla(bakiye,dovizcinsi))// onay durumu başarılı bir şekilde veri tababında güncellendiyse
                {
                    gridGuncelle();// yeni onay durumu data grid te gösteriliyor.
                    MessageBox.Show("Seçilen bakiye onaylandı...!");
                }
            }
            catch // onay durumu değişikliğinde herhangi bir başarısızlık varsa
            {
                MessageBox.Show("Seçilen bakiye onaylanamadı!");
            }
        }
        #endregion
        #region grid güncelleme ve arama metotları
        //data grid verilerini veri tabanı ile eşitler.
        private void gridGuncelle()
        {   
            dataTable = new DataTable();
            dataTable = BakiyeVTisle.BakiyeOnayOnizleme();
            dgv.DataSource = dataTable;
        }

        private void dovizhesapla()
        {
            // Etkin satırdaki döviz bilgisi dövizcinsi değişkene atanıyor.
            string dovizcinsi = dgv.CurrentRow.Cells[4].Value.ToString();

            string xmlcanlidoviz = "https://www.tcmb.gov.tr/kurlar/today.xml";// canlı döviz bilgilerinin alınacağı adres
            var xmldoc = new XmlDocument();// xmldoc isimli xml belgesi tanılanıyor.
            xmldoc.Load(xmlcanlidoviz);// xml belgesine url yükleniyor.


            string xmldovizal = "Tarih_Date/Currency[@Kod='" + dovizcinsi + "']/BanknoteBuying";
            // onaylanan para biriminin TL efektif alış karşılığı dovizTL stringine alınıyor.
            string dovizTL = xmldoc.SelectSingleNode(xmldovizal).InnerXml;
            // string dovizTL = xmldoc.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteBuying").InnerXml;


            MessageBox.Show("Onaylanan para biriminin TL karşılığı: " + dovizTL);
            //MessageBox.Show(string.Format("Tarih {0} ABD DOLARI={1}",tarih.ToShortDateString(),))
        }

        //kullanıcı adını yazarken onay durumu değiştirilecek kaydı arar
        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            dataTable = new DataTable();
            dataTable = BakiyeVTisle.KullaniciAdinaGoreBakiyeArama(txtAra.Text.Trim());
            dgv.DataSource = dataTable;
        }
        #endregion
        #region klavye kısayolları
        private void frmParaOnayla_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                btnAnasayfa.PerformClick();
            }
            if (e.Control && e.KeyCode == Keys.S)
            {
                btnAnasayfa.PerformClick();
            }
        }
        #endregion
    }
}
