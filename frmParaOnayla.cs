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
    public partial class frmParaOnayla : Form
    {
        public frmParaOnayla()
        {
            InitializeComponent();
        }
        public Bakiye bakiye;
        BakiyeElle bakiyeislem;
        DataTable dataTable;
        private void frmParaOnayla_Load(object sender, EventArgs e)
        {
            gridGuncelle();
            dgv.Columns[0].ReadOnly = true;
            dgv.Columns[1].ReadOnly = true;
            dgv.Columns[2].ReadOnly = true; 
            dgv.Columns[3].ReadOnly = true;
            dgv.Columns[4].ReadOnly = true;
            dgv.Columns[6].ReadOnly = true;
        }

        private void dgv_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                bakiye = new Bakiye();
                bakiyeislem = new BakiyeElle();
                bakiye.BakiyeID = Convert.ToInt32(dgv.CurrentRow.Cells[0].Value.ToString());
                bakiye.OnayDurumu= Convert.ToInt32(dgv.CurrentRow.Cells[5].Value.ToString());
                if(bakiye.OnayDurumu!=0 && bakiye.OnayDurumu!=1)
                {
                    MessageBox.Show("Onay Durumu olarak 0 veya 1 dışında değer girmeyiniz!");
                    return;
                }

                if (bakiyeislem.BakiyeOnayla(bakiye))
                {
                    gridGuncelle();
                    MessageBox.Show("Seçilen bakiye onaylandı...!");
                }
            }
            catch
            {
                MessageBox.Show("Seçilen bakiye onaylanamadı!");
            }
        }

        private void gridGuncelle()
        {   
            dataTable = new DataTable();
            dataTable = BakiyeVTisle.BakiyeOnayOnizleme();
            dgv.DataSource = dataTable;
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            dataTable = new DataTable();
            dataTable = BakiyeVTisle.KullaniciAdinaGoreBakiyeArama(txtAra.Text.Trim());
            dgv.DataSource = dataTable;
        }
    }
}
