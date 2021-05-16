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
        public Kisi kisi;
        KisiElle uyeIslem;

        private void frmGiris_Load(object sender, EventArgs e)
        {
            
        }

        private void btnUyeol_Click(object sender, EventArgs e)
        {
            // Üye ol formu çağırılıyor
            frmUyeol uyeolfrm = new frmUyeol();
            uyeolfrm.ShowDialog();

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            // Giriş Yap
            uyeIslem = new KisiElle();
            kisi = uyeIslem.KisiAl(txtKullaniciAd.Text, txtParola.Text);
            if (kisi == null || kisi.Aktif != 0)
            {
                MessageBox.Show("Kullanıcı adı veya parola yanlış girildi..!\n" +
                "veya hesap AKTİF DEĞİL!");

                //lgForm.Refresh();
             //   goto giris;
            }
            else
            {
                this.Close();
            }
        }

        private void btniptal_Click(object sender, EventArgs e)
        {
            //İptal
            MessageBox.Show("Program bitti...\nHoşça kalın...");
            Environment.Exit(0);
        }

        private void frmGiris_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.Exit();
        }
    }
}
