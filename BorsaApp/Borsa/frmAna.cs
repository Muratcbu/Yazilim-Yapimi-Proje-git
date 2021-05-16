using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLibrary;
using EntityLibrary;

namespace Borsa
{
    public partial class frmAna : Form
    {
        public frmAna()
        {
            InitializeComponent();
        }

        public Kisi kisi; //Kişi nesnesi global olarak bildiriliyor
        #region Oturum açma ekranı ve kişi bilgilerinin alınması ve yetki denetimi
        private void Form1_Load(object sender, EventArgs e)
        {
            // Kullanıcı giriş ekranını çağırır.
            frmGiris lgForm = new frmGiris();
            lgForm.ShowDialog();
            kisi = lgForm.kisi;//login ekranından elde edilen kişi bu forma alınıyor!
            lgForm.Dispose(); //login formu siliniyor
            
            // yetki 0 ise kullanıcı (alıcı veya satıcı olabilir) oturum açmış demektir
            if (kisi.Yetki == 0)
            {
                //Kullanıcı oturum açmış ise Admin işlemleri pasifize ediliyor ve gizleniyor.
                grpboxAdmin.Enabled = false;
                grpboxAdmin.Visible = false;                
            }
            //Oturum açan kişinin adı formun altındaki durum çubuğunda gösterilecek.
            toolStripStatusLabel1.Text= "Hoşgeldin " + kisi.Ad;
        }
        #endregion
        #region yönetici ve standart kullanıcı ortak denetimleri
        private void btnParaEkle_Click(object sender, EventArgs e)
        {
            //sisteme para ekleme formu açılıyor.
            frmParaEkle frmParaEkle = new frmParaEkle(kisi.KisiID);
            frmParaEkle.ShowDialog();
        }
        private void btnMalEkle_Click(object sender, EventArgs e)
        {
            // Sisteme satılık ürün ekleme formu açılıyor.
            frmUrunSat frmUrunSat = new frmUrunSat(kisi.KisiID);
            frmUrunSat.ShowDialog();
        }
        private void btnAlimYap_Click(object sender, EventArgs e)
        {
            // Aktif kullanıcının ürün alacağı form açılıyor!
            frmUrunAl frmUrunAl = new frmUrunAl(kisi.KisiID);
            frmUrunAl.ShowDialog();
        }
        private void btnBitir_Click(object sender, EventArgs e)
        {
            // Program kapatılıyor.
            Environment.Exit(0);
        }
        private void btnGiris_Click(object sender, EventArgs e)
        {
            Form1_Load(null, null);
        }
        #endregion
        #region yönetici denetimleri 
        private void btnMalOnayla_Click(object sender, EventArgs e)
        {
            // Sisteme girilen ürünün yönetici tarafından onaylanma formu açılıyor.
            frmUrunOnayla frmUrunOnayla = new frmUrunOnayla();
            frmUrunOnayla.ShowDialog();
        }
        private void btnParaOnayla_Click(object sender, EventArgs e)
        {
            // Sistem yöneticisinin para onaylama formu açılıyor.
            frmParaOnayla frmParaOnayla = new frmParaOnayla();
            frmParaOnayla.ShowDialog();
        }
        #endregion
    }
}
