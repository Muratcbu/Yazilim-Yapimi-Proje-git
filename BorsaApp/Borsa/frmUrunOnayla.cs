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
    public partial class frmUrunOnayla : Form
    {
        public frmUrunOnayla()
        {
            InitializeComponent();
        }
        #region hazırlık
        //sık kullanılacak nesneler global olarak bildiriliyor.
        public Piyasa piyasa;
        PiyasaElle piyasaislem;
        DataTable dataTable;
        private void gridreadonly()
        {
            dg.Columns[0].ReadOnly = true;
            dg.Columns[1].ReadOnly = true;
            dg.Columns[2].ReadOnly = true;
            dg.Columns[3].ReadOnly = true;
            dg.Columns[4].ReadOnly = true;
            dg.Columns[5].ReadOnly = true;
            dg.Columns[6].ReadOnly = true;
            dg.Columns[8].ReadOnly = true;
        }
        #region guncelleme ve arama
        private void frmUrunOnayla_Load(object sender, EventArgs e)
        {
            gridGuncelle(); // data grid ürün verileriyle dolduruluyor.
            gridreadonly(); // data grid te onay durumu dışındaki alanlar salt okunur yapılıyor.
        }
        
        private void gridGuncelle() //data gridi günceller
        {
            dataTable = new DataTable();
            dataTable = PiyasaVTisle.PiyasaOnayOnizleme();//Entity katmanından gelen metot
            dg.DataSource = dataTable;
        }
        #endregion
        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            //kullanici adını yazdıkça veri tabanından ilgili kayıtlar getirilir.
            dataTable = new DataTable();
            //aşağıdaki metoto entity katmanından çağırılır
            dataTable = PiyasaVTisle.KullaniciAdinaGorePiyasaArama(txtAra.Text.Trim());
            dg.DataSource = dataTable;
        }
        #endregion
        #region urun onaylama
        //data grid teki urun onay durumu değişince veri tabanı ve data grid bilgileri güncellenir
        private void dg_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try // exception oluşabilecek kodlar bu kapsamda yazılmıştır.
            {
                piyasa = new Piyasa();
                piyasaislem = new PiyasaElle();
                //urun onaylayacak metoda gönderilecek veriler data girdden okunuyor.
                //data grid 0. sütun piyasa ID, 7. sütun ise onay durumu verisini barıdırır.
                piyasa.PiyasaID = Convert.ToInt32(dg.CurrentRow.Cells[0].Value.ToString());
                piyasa.Onaydurumu = Convert.ToInt32(dg.CurrentRow.Cells[7].Value.ToString());
                //eğer onay durumuna geçersiz bir değer girilmişse
                if (piyasa.Onaydurumu != 0 && piyasa.Onaydurumu != 1)
                {
                    MessageBox.Show("Onay Durumu olarak 0 veya 1 dışında değer girmeyiniz!");
                    return; // geçersiz onay durumu girişi onaylanmaz
                }

                if (piyasaislem.PiyasaOnayla(piyasa)) // Business katmanındaki piyasaonayla metodu başarılı olmuşsa
                {

                    MessageBox.Show("Seçilen ürünün piyasaya girişi onaylandı...!");
                    TalepElle talepkarsila = new TalepElle();
                    if(!talepkarsila.TalepKarsila(piyasa.PiyasaID))
                    {
                        MessageBox.Show("Ürünü almayı bekleyen talepler karşılandı..!\n"
                            +"Satınalma emir(ler)i yerine getirildi..!");
                    }
                    else
                    {
                        MessageBox.Show("Karşılanan bir alım emri olmadı..!");
                    }
                    gridGuncelle(); // data grid guncellenir ve onay mesajı gösterilir.
                }
            }
            catch (Exception exc)
            {
                // urun onayında bir sorun çıktıysa bilgilendirme mesajı görüntülenir.
                MessageBox.Show("Seçilen ürünün piyasaya girişi onaylanamadı!\n"
                    +exc.ToString());
            }
        }
        #endregion
        #region klavye kısayolları
        private void frmUrunOnayla_KeyDown(object sender, KeyEventArgs e)
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
