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

        public Kisi kisi;
        
        private void Form1_Load(object sender, EventArgs e)
        {
            // Kullanıcı giriş ekranını çağırır.
            frmGiris lgForm = new frmGiris();
            lgForm.ShowDialog();
            kisi = lgForm.kisi;//login ekranından elde edilen kişi bu forma alınıyor!
            lgForm.Dispose(); //login formu siliniyor
            
            //yetki 0 ise kullanıcı (alıcı veya satıcı olabilir) oturum açmış demektir
            if (kisi.Yetki == 0)
            {
                //Kullanıcı oturum açmış ise Admin işlemleri pasifize ediliyor ve gizleniyor.
                grpboxAdmin.Enabled = false;
                grpboxAdmin.Visible = false;                
            }
            toolStripStatusLabel1.Text= "Hoşgeldin " + kisi.Ad;
        }

        private void KullanicicontextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnParaEkle_Click(object sender, EventArgs e)
        {
            frmParaEkle frmParaEkle = new frmParaEkle(kisi.KisiID);
            frmParaEkle.ShowDialog();

        }

        private void btnParaOnayla_Click(object sender, EventArgs e)
        {
            frmParaOnayla frmParaOnayla = new frmParaOnayla();
            frmParaOnayla.ShowDialog();
        }

        private void btnBitir_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnMalEkle_Click(object sender, EventArgs e)
        {
            frmUrunSat frmUrunSat = new frmUrunSat(kisi.KisiID);
            frmUrunSat.ShowDialog();
        }

        private void btnMalOnayla_Click(object sender, EventArgs e)
        {
            frmUrunOnayla frmUrunOnayla = new frmUrunOnayla();
            frmUrunOnayla.ShowDialog();
        }
    }
}
