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
{   public partial class frmTalep : Form
    {
        #region hazırlık
        int _kisiID; // ana formdan gelen oturum açma kimlik bilgisi bu değişkende.
        //parametreli form yapıcı metodu
        public frmTalep(int kisiID) //ana formdan oturum açma kimlik bilgisi ile form açılıyor.
        {
            InitializeComponent();
            _kisiID = kisiID;//oturum açma bilgisi alınıyor.
        }
        //sık kullanılacak nesneler global olarak bildiriliyor.
        DataTable dataTable = new();
        DataTable dataTableUrun = new();
        Bakiye bakiye;
        Piyasa piyasa;
        PiyasaHareketElle piyasahareketislem;//piyasa hareketlerini işleyecek nesne
        Talep talep;
        TalepElle talepElle;
        private void frmTalep_Load(object sender, EventArgs e)
        {
            //combo box lar form yüklenirken doldurularak hazır hale getiriliyor.
            cmbUrunDoldur();
            cmbDovizDoldur();
            txtMevcutpara.Text = mevcutbakiye().ToString();//oturum açan kullanıcının mevcut toplam bakiyesi.
            txtMevcutStok.Text = mevcutstok().ToString();//seçilen ürün ve döviz cinsine göre ne kadar stok mevcut?
            txtMiktar.Text = "0";
            txtFiyatTeklif.Text = "0";
        }
        //ürün seçildikten sonra döviz combo box ı da de doldurulur ve seçilen ürün seçilen 
        //döviz cinsinden toplam stok bilgisi formdaki txtmevcutStok kutusuna yazılır.
        private void cmbUrun_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDovizDoldur();
            txtMevcutStok.Text = mevcutstok().ToString();
        }
        //doviz cinsi seçimi değişirse ilgili ürünün ilgili döviz cinsinden toplam stok durum
        //bilgisi formdaki txtmevcutStok kutusuna yazılır.
        private void cmbDoviz_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMevcutStok.Text = mevcutstok().ToString();
        }
        //seçilen ürün ve doviz cinsi bilgilerine göre toplam stok bilgisini hesaplayan metot.
        private double mevcutstok()
        {
            piyasa = new();
            piyasa.UrunID = (int)cmbUrun.SelectedValue;
            piyasa.DovizID = (int)cmbDoviz.SelectedValue;
            return PiyasaVTisle.ToplamStokGoster(piyasa,txtFiyatTeklif.Text);//Entity sınıfındaki metoda piyasa nesnesi gönderiyor.
                                                         //ve seçilen ürün ve döviz cinsine göre
                                                         //ilgili ürünün toplam stok bilgisi döndürülüyor.
        }
        #endregion
        #region denetimleri doldurma
        //combo box ta gösterilecek ürünleri dolduran metot
        private void cmbUrunDoldur()
        {
            dataTableUrun = UrunVTisle.UrunAl();//Entity katmanındaki UrunAl metodu ürün bilgilerini data table a dolduruyor.
            //data table da 0. sütunda ürün ID, 1. sütunda ürün adı var.
            cmbUrun.ValueMember = dataTableUrun.Columns[0].ToString();//Urun IID combo box değeri olacak.
            cmbUrun.DisplayMember = dataTableUrun.Columns[1].ToString();//combo box ta ürün adı gösterilecek.
            cmbUrun.DataSource = dataTableUrun;//ürün combox ının veri kaynağı data table.
        }
        //combo box ta gösterilecek dövizleri dolduran metot
        private void cmbDovizDoldur()
        {
            dataTable = DovizVTisle.DovizAl();//Entity katmanındaki DovizAl metodu döviz bilgilerini data table a dolduruyor.
            //data table da 0. sütunda döviz ID, 1. sütunda döviz kısaltması var.
            cmbDoviz.ValueMember = dataTable.Columns[0].ToString();//combo box değeri döviz ID olacak.
            cmbDoviz.DisplayMember = dataTable.Columns[1].ToString();//combo box ta döviz kısaltması gösterilecek.
            cmbDoviz.DataSource = dataTable;//döviz combo box ının veri kaynağı data table.
        }
        private decimal mevcutbakiye() //oturum açan kullanıcının mevcut toplam bakiyesi hesaplanır.
        {
            bakiye = new Bakiye
            {
                KisiID = _kisiID,
                Dovizcinsi = Convert.ToInt32(cmbDoviz.SelectedValue)
            };
            return BakiyeVTisle.ToplamBakiyeGoster(bakiye);//Entity katmanındaki metot toplam bakiyeyi döndürüyor.
        }
        //talep oluşturan metot
        private void talepOlustur(double teklifEdilenFiyat, float miktartakip)
        {
            talep = new Talep
            {
                KisiID = _kisiID,
                UrunID = (int)cmbUrun.SelectedValue,
                Fiyat = teklifEdilenFiyat,
                Miktar = miktartakip
            };

            talepElle = new TalepElle();
            if (talepElle.TalepEkle(talep)) // oluşturulan talep veri tabanına başarılı bir şekilde kaydedildiyse
                MessageBox.Show("Alım emri başarı ile verildi!\n" +
                    "İstediğiniz ürün yazdığınız fiyattan satışa sunulduğunda\n" +
                    "Yeterli bakiyeniz varsa otomatik olarak alım yapılacak!");
        }
        #endregion
        #region Ürün alım satım işlemleri
        private void btnAl_Click(object sender, EventArgs e)
        {
            PiyasaHareket hareket = new();//piyasa hareket bilgilerini tutacak nesne.
            piyasahareketislem = new();//piyasa hareketini işleyecek olan nesne.

            try
            {
                double butce = Convert.ToDouble(txtMevcutpara.Text);//oturum açan kullanıcını mevcut toplam bakiyesi bütçedir. 
                /* butcetakip döngü içinde sürekli azaltılacak, ama baslangıç bütçesi aynı kalacak.
                 * %1 komisyon odeneceginden butcenin en fazla %99'u kullanilabilecek */
                double butcetakip = butce * 0.99;
                float istenenmiktar = float.Parse(txtMiktar.Text);//kullanıcının satın almak istediği miktar.
                float miktartakip = istenenmiktar;//miktar takip değişkeni satın alınmak istenen miktar ile başlayıp her döngü çevriminde azaltılacak.
                float adaymiktar = 0;//döngü çevriminde mevcut bütçe ile ilgili kayıttaki üründen en fazla kaç tane alınabileceği.
                DataTable adayurunler = new DataTable();//Satın alınmaya uygun, onaylı ürün listesi bu data table da tutulacak.
                                                        //UygunStoklar metodundan dönen satın alınmak istenen ürünün onaylanmış kayıtları adayurunler tablosuna yerleştiriliyor.
                adayurunler = PiyasaVTisle.UygunStoklar((int)cmbUrun.SelectedValue, (int)cmbDoviz.SelectedValue, Convert.ToDouble(txtFiyatTeklif.Text));
                
                // Verilen birim fiyat ve altında satılık ürün yoksa...
                if(Convert.ToSingle(txtMevcutStok.Text)==0)
                {
                    DialogResult dialog = new DialogResult();
                    dialog = MessageBox.Show("Teklif ettiğiniz birim fiyat mevcut değil!\n" +
                        txtFiyatTeklif.Text+" ve altında bir fiyat oluşursa otomatik satın alma "+
                        "emri vermek istiyor musunuz?", "Talep Oluşturma", MessageBoxButtons.YesNo);
                    if (dialog == DialogResult.Yes) // Talep oluşturuluyor.
                    {
                        talepOlustur(Convert.ToDouble(txtFiyatTeklif.Text), miktartakip);                        
                        return;
                    }
                    else
                    {   // Talep oluştururken bir hata ortaya çıktıysa
                        MessageBox.Show("Ürün alımı veya alım emri gerçekleşmedi!");
                        return;
                    }
                }

                //Alıcı istediği üründen en az bir tane alacak bütçeye sahip değilse!
                else if (Convert.ToDouble(adayurunler.Rows[0][3]) * 1.01 > butce) // %1 komisyon dahil edildi.
                {
                    MessageBox.Show("Bütçe Yetersiz...!");
                    return;
                }

                foreach (DataRow dr in adayurunler.Rows)//uygun ürünlerden fiyatı en düşük olana göre satın alma gerçekleşecek.
                {
                    //istenen miktar ve bütçe sıfırlandıysa veya eksi olmuşsa satın alma sonlanır.
                    if (miktartakip <= 0 || butcetakip <= 0)
                        break;

                    // aday ürünün birim fiyatı data table ın 3 numaralı sütunundadır.
                    if (butcetakip >= Convert.ToDouble(dr[3]))//bütçe aday üründen en az bir birim almaya müsaitse
                    {
                        //aday üründen en fazla kaç birim alınabilir hesaplanıyor.
                        adaymiktar = (float)Math.Floor(butcetakip / Convert.ToDouble(dr[3]));

                        //data table ın 5 numaralı sütununda aday ürünün stok miktar bilgisi yer almaktadır.
                        //istenen miktar en fazla bütçe ile alınabilecek miktardan azsa ve aday ürünün stoğu bunu karşılıyorsa.
                        if (miktartakip <= adaymiktar && adaymiktar <= Convert.ToSingle(dr[5]))
                        {
                            hareket.Miktar = miktartakip;//satış hareketinin satış miktarı miktartakip değişkeni olarak kaydediliyor.
                                                         //talep edilen miktarın tamamı bu aday üründen karşılandı.
                        }

                        //istenen miktar en fazla bütçe ile alınabilecek miktardan azsa ve fakat aday ürünün stoğu buna yetmiyorsa 
                        else if (miktartakip <= adaymiktar && adaymiktar > Convert.ToSingle(dr[5]))
                        {
                            hareket.Miktar = Convert.ToSingle(dr[5]);//mevcut satış hareketinin satış miktarı mevcut aday ürün stoğunun tamamı oldu.
                                                                     //aday ürünün tüm stoğu satın alındı. Ama talep karşılanamadı. İstenen ürünün geri kalan miktarı için
                                                                     //data table ın bir sonraki satırındaki aday ürüne bakılacak.
                        }
                        else
                        {
                            hareket.Miktar = adaymiktar;// mevcut aday ürün stoğu diğer durumlardan farklı ise
                        }
                        hareket.PiyasaID = (int)dr[0];// data table 0. sütun değeri piyasa ID dir.
                        hareket.AliciID = _kisiID;// alıcı kimliği ana etkin oturum açmış kullanıcıdır.
                        hareket.SaticiID = (int)dr[1];// satıcı kimliği data table da en son işlenen satırın 1. sütunundadır.
                        miktartakip -= hareket.Miktar;//eğer tek bir stoktan talep karşılanamadıysa istenen miktar, 
                                                      //bir önceki satın alma miktarı kadar azaltılacak.
                        butcetakip -= Convert.ToDouble(dr[3]) * hareket.Miktar;//ne kadar bütçe kaldıysa butcetakip değişkeninde
                        piyasahareketislem.PiyasaHareketEkle(hareket);//yapılan satış hareketi PiyasaHareketEkle metodu ile veri  tabanına işleniyor.
                    }
                    else //kalan bütçe sıradaki aday üründen bir tane bile almaya yetmiyorsa satın alma bitsin.
                        break;
                }
                if(miktartakip>0) // fiyat teklifine uygun olan stoklardan talep karşılanamadıysa
                {
                    DialogResult dialog = new DialogResult();
                    dialog = MessageBox.Show("Stok/bütçe yetersizliği nedeniyle talep ettiğiniz miktar kadar alım yapamadınız.\n" +
                        txtFiyatTeklif.Text + " ve altında bir fiyat oluşursa "+miktartakip+" miktarında ürünü " +
                        "\ndaha sonra otomatik satın alma emri vermek istiyor musunuz?", "Talep Oluşturma", MessageBoxButtons.YesNo);
                    if (dialog == DialogResult.Yes) // Talep oluşturuluyor.
                    {
                        talepOlustur(Convert.ToDouble(txtFiyatTeklif.Text), miktartakip);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Satın alma geçekleşti..!");
                }

            }
            catch (Exception exc)
            {
                string hata = "\nSeçtiğiniz döviz türünde stok yok!\nveya\n" +
                    "Talep miktarını hatalı girdiniz!";
                MessageBox.Show(hata+Environment.NewLine+ exc.ToString());

            }
            finally
            {
                frmTalep_Load(null, null);
            }
        }
        #endregion
        #region klavye kısayolları
        private void frmTalep_KeyDown(object sender, KeyEventArgs e)
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
                btnAl.PerformClick();
            }
            if (e.Control && e.KeyCode == Keys.Y)
            {
                btnAl.PerformClick();
            }
        }
        #endregion

        private void txtFiyatTeklif_TextChanged(object sender, EventArgs e)
        {
            txtMevcutStok.Text = mevcutstok().ToString();
        }
    }
}
