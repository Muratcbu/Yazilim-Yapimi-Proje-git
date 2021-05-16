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
    public partial class frmParaEkle : Form
    {
        int _kisiID;
        public frmParaEkle(int kisiID)
        {
            InitializeComponent();
            _kisiID = kisiID;
        }

        public Bakiye bakiye;
        BakiyeElle bakiyeislem;
        private void frmParaEkle_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Aktif kullanıcı ID= " +_kisiID.ToString());
            DataTable dataTable = new DataTable();
            dataTable = DovizVTisle.DovizAl();
            cmbDoviz.ValueMember = dataTable.Columns[0].ToString();
            cmbDoviz.DisplayMember = dataTable.Columns[1].ToString();
            cmbDoviz.DataSource = dataTable;
            bakiye = new Bakiye();
            bakiye.KisiID = _kisiID;
            bakiye.Dovizcinsi = Convert.ToInt32(cmbDoviz.SelectedValue);
            txtMevcutpara.Text = BakiyeVTisle.ToplamBakiyeGoster(bakiye).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                bakiye = new Bakiye();
                bakiyeislem = new BakiyeElle();
                bakiye.KisiID = _kisiID;
                bakiye.Bakiyepara = Convert.ToDecimal(txtParamiktar.Text);
                bakiye.Dovizcinsi = Convert.ToInt32(cmbDoviz.SelectedValue);
                if (bakiyeislem.BakiyeEkle(bakiye))
                {
                    MessageBox.Show("Yeni para eklendi! Onay bekliyor...!");
                }
            }
            catch 
            {
                MessageBox.Show("Yeni para eklenemedi!\n" +
                    "Para miktarını girerken sadece rakam kullanınız!");
            }
        }
    }
}
