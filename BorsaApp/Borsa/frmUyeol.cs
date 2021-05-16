using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Entity ve Business katmanları include ediliyor
using EntityLibrary;
using BusinessLibrary;

namespace Borsa
{
    public partial class frmUyeol : Form
    {
        public frmUyeol()
        {
            InitializeComponent();
        }
        //Sık kullanılacak nesneler global olarak bildiriliyor!
        public Kisi kisi;
        KisiElle uyeIslem;
        #region yeni üye kaydı işlemleri
        private void btnUyeol_Click(object sender, EventArgs e)
        {
            //uyelik işlemlerini gerçekleştirecek uyeIslem nesnesi oluşturuluyor.
            uyeIslem = new KisiElle();
            kisi = new Kisi(); //Üye bilgileri ile ilgili kişi nesnesi oluşturuluyor.
            //Hatalı veya boş veri girişleri kontrol ediliyor.
            if(
                txtTc.Text is null 
                || string.IsNullOrWhiteSpace(txtTc.Text) 
                || string.IsNullOrWhiteSpace(txtAdi.Text)
                || txtSoyadi.Text is null || txtSoyadi.Text.Trim().Length < 1
                || txtKullaniciAdi.Text is null || txtKullaniciAdi.Text.Trim().Length < 1
                || txtParola.Text is null || txtParola.Text.Trim().Length < 1
                || txtTelefon.Text is null || txtTelefon.Text.Trim().Length < 1 
                || txtEposta.Text is null || txtEposta.Text.Trim().Length < 1
                || txtAdres.Text is null || txtAdres.Text.Trim().Length < 1 
                )
            {
                //Hatalı veya boş veri girişi varsa kayıt yapılmıyor.
                MessageBox.Show("Lütfen tüm alanları doldurunuz...!");
                txtTc.Focus();
            }
            //Veri girişleri sorunsuz ise girilen veriler kişi nesnesine aktarılıyor.
            else
            {
                kisi.Tcno = txtTc.Text;
                kisi.Ad = txtAdi.Text;
                kisi.Soyad = txtSoyadi.Text;
                kisi.KullaniciAd = txtKullaniciAdi.Text;
                kisi.Parola = txtParola.Text;
                kisi.Telefon = txtTelefon.Text;
                kisi.Eposta = txtEposta.Text;
                kisi.Adres = txtAdres.Text;
                //kişi nesnesi KişiEkle metoduna parametre olarak geçiriliyor.
                if (uyeIslem.KisiEkle(kisi))//KisiEkle metodu kaydı yapacak ve başarılı ise true döndürecek.
                {
                    MessageBox.Show("Üyelik işlemi başarılı...!");                    
                }
                else//Kayıt başarılı değilse.
                    MessageBox.Show("Kayıt başarılı olamadı...!\n" +
                        "Telefon veya Adres alanı dışında hiç bir alanı boş bırakmayınız...!\n" +
                        "TCno veya KullanıcıAdı veya Eposta daha önceden kullanılmış...!");
            }
        }
        #endregion
        #region error provider
        //error provider ile metin kutularına girilen değerlerişn geçerliliği kontrol ediliyor.
        private void txtTc_Validating(object sender, CancelEventArgs e)
        {   
            if (txtTc.Text.Trim().Length<1)//tcno 1 karakterden az ise
            {
                // girişi iptal eder ve düzeltilmesi için girilen metni seçer.
                e.Cancel = true;
                txtTc.Select(0, txtTc.Text.Length);

                // ErrorProvider hatasında gösterilecek metin ayarlanıyor.
                errorProvider1.SetError(txtTc, "Tc alanı boş geçilemez...!");
            }
        }

        private void txtAdi_Validating(object sender, CancelEventArgs e)
        {
            if (txtAdi.Text.Trim().Length < 1)//isim bir karakterden az ise
            {
                // girişi iptal eder ve düzeltilmesi için girilen metni seçer.
                e.Cancel = true;
                txtAdi.Select(0, txtAdi.Text.Length);

                // ErrorProvider hatasında gösterilecek metin ayarlanıyor.
                errorProvider1.SetError(txtAdi, "Ad alanı boş geçilemez...!");
            }
        }

        private void txtSoyadi_Validating(object sender, CancelEventArgs e)
        {
            if (txtSoyadi.Text.Trim().Length < 1)//soyisi bir karakterden az ise
            {
                // girişi iptal eder ve düzeltilmesi için girilen metni seçer.
                e.Cancel = true;
                txtSoyadi.Select(0, txtSoyadi.Text.Length);

                // ErrorProvider hatasında gösterilecek metin ayarlanıyor.
                errorProvider1.SetError(txtSoyadi, "Soyad alanı boş geçilemez...!");
            }
        }

        private void txtKullaniciAdi_Validating(object sender, CancelEventArgs e)
        {
            if (txtKullaniciAdi.Text.Trim().Length < 1) // kullanıcı adı bir karakterden az ise
            {
                // girişi iptal eder ve düzeltilmesi için girilen metni seçer.
                e.Cancel = true;
                txtKullaniciAdi.Select(0, txtKullaniciAdi.Text.Length);

                // ErrorProvider hatasında gösterilecek metin ayarlanıyor.
                errorProvider1.SetError(txtKullaniciAdi, "Kullanıcı Adı alanı boş geçilemez...!");
            }
        }

        private void txtParola_Validating(object sender, CancelEventArgs e)
        {
            if (txtParola.Text.Trim().Length < 1) //parola bir karakterden az ise
            {
                // girişi iptal eder ve düzeltilmesi için girilen metni seçer.
                e.Cancel = true;
                txtParola.Select(0, txtParola.Text.Length);

                // ErrorProvider hatasında gösterilecek metin ayarlanıyor.
                errorProvider1.SetError(txtParola, "Parola alanı boş geçilemez...!");
            }
        }

        private void txtTelefon_Validating(object sender, CancelEventArgs e)
        {
            if (txtTelefon.Text.Trim().Length < 1) //telefon bir karakterden az ise
            {
                // girişi iptal eder ve düzeltilmesi için girilen metni seçer.
                e.Cancel = true;
                txtTelefon.Select(0, txtTelefon.Text.Length);

                // ErrorProvider hatasında gösterilecek metin ayarlanıyor.
                errorProvider1.SetError(txtTelefon, "Telefon alanı boş geçilemez...!");
            }
        }

        private void txtEposta_Validating(object sender, CancelEventArgs e)
        {
            if (txtEposta.Text.Trim().Length < 1) // eposta bir karakterden az ise
            {
                // girişi iptal eder ve düzeltilmesi için girilen metni seçer.
                e.Cancel = true;
                txtEposta.Select(0, txtEposta.Text.Length);

                // ErrorProvider hatasında gösterilecek metin ayarlanıyor.
                errorProvider1.SetError(txtEposta, "Eposta alanı boş geçilemez...!");
            }
        }

        private void txtAdres_Validating(object sender, CancelEventArgs e)
        {
            if (txtAdres.Text.Trim().Length < 1)
            {
                // girişi iptal eder ve düzeltilmesi için girilen metni seçer.
                e.Cancel = true;
                txtAdres.Select(0, txtAdres.Text.Length);

                // ErrorProvider hatasında gösterilecek metin ayarlanıyor.
                errorProvider1.SetError(txtAdres, "Adres alanı boş geçilemez...!");
            }
        }
        #endregion
        #region içine girilen metin kutuları
        //Metin kutusu içine tıklandığında mevcut metnin tamamı seçiliyor.
        //böylece yazmaya başlandığında silmek için zaman harcanmıyor.
        private void txtTc_Click(object sender, EventArgs e)//metin kutusu içine tıklandığında
        {
            txtTc.SelectAll();//mevcut metnin tamamını seçer
        }

        private void txtAdi_Click(object sender, EventArgs e)
        {
            txtAdi.SelectAll();
        }

        private void txtSoyadi_Click(object sender, EventArgs e)
        {
            txtSoyadi.SelectAll();
        }

        private void txtKullaniciAdi_Click(object sender, EventArgs e)
        {
            txtKullaniciAdi.SelectAll();
        }

        private void txtParola_Click(object sender, EventArgs e)
        {
            txtParola.SelectAll();
        }

        private void txtTelefon_Click(object sender, EventArgs e)
        {
            txtTelefon.SelectAll();
        }

        private void txtEposta_Click(object sender, EventArgs e)
        {
            txtEposta.SelectAll();
        }

        private void txtAdres_Click(object sender, EventArgs e)
        {
            txtAdres.SelectAll();
        }

        #endregion
        #region klavye kısayolları
        private void frmUyeol_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                btnUyeol.PerformClick();
            }
            if (e.Control && e.KeyCode == Keys.O)
            {
                btnUyeol.PerformClick();
            }
            if (e.KeyCode == Keys.Escape)
            {
                btniptal.PerformClick();
            }
            if (e.Control && e.KeyCode == Keys.L)
            {
                btniptal.PerformClick();
            }
        }
    }
    #endregion
}
