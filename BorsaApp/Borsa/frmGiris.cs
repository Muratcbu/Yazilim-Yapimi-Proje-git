using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLibrary;
using BusinessLibrary;

namespace Borsa
{
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }
        // sık kullanılacak nesneler global olarak bildiriliyor.
        public Kisi kisi=new Kisi();//kişi nesnesi bilgileri diğer formlara gönderileceği için public.
        KisiElle uyeIslem=new KisiElle();
        #region yeni üye kaydı
        //yeni üye kaydı metodu çağırılıyor
        private void btnUyeol_Click(object sender, EventArgs e)
        {
            // Üye ol formu çağırılıyor
            frmUyeol uyeolfrm = new frmUyeol();
            uyeolfrm.ShowDialog();
        }
        #endregion
        #region mevcut üye girişi
        private void btnGiris_Click(object sender, EventArgs e)
        {
            // Kullanıcı adı ve parola veri tabanından kontrol ediliyor. 
            //Eğer veri tabanı bağlantısı hatalıysa veya kullanıcı yok ise hata döndürecek olan 
            //try-catch yazılıyor.
            try { //bu kapsamda hata çıkma olasılığı olan satırlar yazılıyor..
                uyeIslem = new KisiElle();
                kisi = uyeIslem.KisiAl(txtKullaniciAd.Text, txtParola.Text);
                if (kisi == null || kisi.Aktif != 0)// bilgileri girilen kişi aktif değilse veya böyle bir kişi yoksa
                {
                    MessageBox.Show("Kullanıcı adı veya parola yanlış girildi..!\n" +
                    "veya hesap AKTİF DEĞİL!\n" +
                    "veya veri tabanı bağlantısı yapılamadı!");
                }
                else //girilen bilgilere göre kişi mevcut ve aktif ise form kapatılıyor ve ana ekrana dönülüyor.
                {
                    this.Close();
                }
            }
            catch {//try kapsamı içinde çıkması muhtemel sorun veri tabanı bağlantısı ile ilgili olabilir.
                MessageBox.Show("Veri tabanı bağlantısı yapılamadı...!");
            }
        }
        #endregion
        #region çıkış
        private void btniptal_Click(object sender, EventArgs e)
        {
            // Programdan çıkış
            MessageBox.Show("Program bitti...\nHoşça kalın...");
            Environment.Exit(0);
        }
        #endregion
        #region klavye kısayolları
        private void frmGiris_KeyDown(object sender, KeyEventArgs e)
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
            if (e.KeyCode == Keys.F3)
            {
                btnGiris.PerformClick();
            }
            if (e.Control && e.KeyCode == Keys.Y)
            {
                btnGiris.PerformClick();
            }
        }
        #endregion
    }
   
}
