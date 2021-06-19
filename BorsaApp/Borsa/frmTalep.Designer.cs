
namespace Borsa
{
    partial class frmTalep
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblKonuBaslik = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMevcutStok = new System.Windows.Forms.TextBox();
            this.txtMevcutpara = new System.Windows.Forms.TextBox();
            this.lblAltBaslik = new System.Windows.Forms.Label();
            this.btnAnaSayfa = new System.Windows.Forms.Button();
            this.cmbUrun = new System.Windows.Forms.ComboBox();
            this.cmbDoviz = new System.Windows.Forms.ComboBox();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.lblDoviz = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblUrun = new System.Windows.Forms.Label();
            this.lblMiktar = new System.Windows.Forms.Label();
            this.btnAl = new System.Windows.Forms.Button();
            this.txtFiyatTeklif = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblKonuBaslik
            // 
            this.lblKonuBaslik.AutoSize = true;
            this.lblKonuBaslik.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblKonuBaslik.Location = new System.Drawing.Point(283, 29);
            this.lblKonuBaslik.Name = "lblKonuBaslik";
            this.lblKonuBaslik.Size = new System.Drawing.Size(226, 36);
            this.lblKonuBaslik.TabIndex = 23;
            this.lblKonuBaslik.Text = "Borsa - Alım Emri";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(234, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(259, 15);
            this.label7.TabIndex = 36;
            this.label7.Text = "Ürün, döviz ve fiyat teklifine uygun toplam stok:";
            // 
            // txtMevcutStok
            // 
            this.txtMevcutStok.Location = new System.Drawing.Point(499, 186);
            this.txtMevcutStok.Name = "txtMevcutStok";
            this.txtMevcutStok.ReadOnly = true;
            this.txtMevcutStok.Size = new System.Drawing.Size(100, 23);
            this.txtMevcutStok.TabIndex = 28;
            this.txtMevcutStok.Text = "0";
            this.txtMevcutStok.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtMevcutpara
            // 
            this.txtMevcutpara.ForeColor = System.Drawing.Color.Red;
            this.txtMevcutpara.Location = new System.Drawing.Point(256, 157);
            this.txtMevcutpara.Name = "txtMevcutpara";
            this.txtMevcutpara.ReadOnly = true;
            this.txtMevcutpara.Size = new System.Drawing.Size(100, 23);
            this.txtMevcutpara.TabIndex = 24;
            // 
            // lblAltBaslik
            // 
            this.lblAltBaslik.AutoSize = true;
            this.lblAltBaslik.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAltBaslik.Location = new System.Drawing.Point(113, 65);
            this.lblAltBaslik.Name = "lblAltBaslik";
            this.lblAltBaslik.Size = new System.Drawing.Size(318, 21);
            this.lblAltBaslik.TabIndex = 35;
            this.lblAltBaslik.Text = "Almak İstediğiniz Ürün Bilgilerini Giriniz";
            // 
            // btnAnaSayfa
            // 
            this.btnAnaSayfa.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnaSayfa.Location = new System.Drawing.Point(355, 227);
            this.btnAnaSayfa.Name = "btnAnaSayfa";
            this.btnAnaSayfa.Size = new System.Drawing.Size(100, 23);
            this.btnAnaSayfa.TabIndex = 29;
            this.btnAnaSayfa.Text = "Ana &Sayfa (ESC)";
            this.btnAnaSayfa.UseVisualStyleBackColor = true;
            // 
            // cmbUrun
            // 
            this.cmbUrun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUrun.FormattingEnabled = true;
            this.cmbUrun.Location = new System.Drawing.Point(256, 99);
            this.cmbUrun.Name = "cmbUrun";
            this.cmbUrun.Size = new System.Drawing.Size(100, 23);
            this.cmbUrun.TabIndex = 25;
            this.cmbUrun.SelectedIndexChanged += new System.EventHandler(this.cmbUrun_SelectedIndexChanged);
            // 
            // cmbDoviz
            // 
            this.cmbDoviz.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDoviz.FormattingEnabled = true;
            this.cmbDoviz.Location = new System.Drawing.Point(499, 94);
            this.cmbDoviz.Name = "cmbDoviz";
            this.cmbDoviz.Size = new System.Drawing.Size(100, 23);
            this.cmbDoviz.TabIndex = 26;
            this.cmbDoviz.SelectedIndexChanged += new System.EventHandler(this.cmbDoviz_SelectedIndexChanged);
            // 
            // txtMiktar
            // 
            this.txtMiktar.Location = new System.Drawing.Point(256, 128);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(100, 23);
            this.txtMiktar.TabIndex = 27;
            this.txtMiktar.Text = "0";
            this.txtMiktar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblDoviz
            // 
            this.lblDoviz.AutoSize = true;
            this.lblDoviz.Location = new System.Drawing.Point(425, 102);
            this.lblDoviz.Name = "lblDoviz";
            this.lblDoviz.Size = new System.Drawing.Size(68, 15);
            this.lblDoviz.TabIndex = 31;
            this.lblDoviz.Text = "Döviz Cinsi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(111, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 15);
            this.label4.TabIndex = 32;
            this.label4.Text = "Mevcut Onaylı Bakiyeniz:";
            // 
            // lblUrun
            // 
            this.lblUrun.AutoSize = true;
            this.lblUrun.Location = new System.Drawing.Point(166, 102);
            this.lblUrun.Name = "lblUrun";
            this.lblUrun.Size = new System.Drawing.Size(84, 15);
            this.lblUrun.TabIndex = 33;
            this.lblUrun.Text = "Alınacak Ürün:";
            // 
            // lblMiktar
            // 
            this.lblMiktar.AutoSize = true;
            this.lblMiktar.Location = new System.Drawing.Point(137, 128);
            this.lblMiktar.Name = "lblMiktar";
            this.lblMiktar.Size = new System.Drawing.Size(113, 15);
            this.lblMiktar.TabIndex = 34;
            this.lblMiktar.Text = "Miktarı (sayı giriniz):";
            // 
            // btnAl
            // 
            this.btnAl.Location = new System.Drawing.Point(507, 227);
            this.btnAl.Name = "btnAl";
            this.btnAl.Size = new System.Drawing.Size(94, 23);
            this.btnAl.TabIndex = 30;
            this.btnAl.Text = "Alım &Yap (F2)";
            this.btnAl.UseVisualStyleBackColor = true;
            this.btnAl.Click += new System.EventHandler(this.btnAl_Click);
            // 
            // txtFiyatTeklif
            // 
            this.txtFiyatTeklif.Location = new System.Drawing.Point(499, 128);
            this.txtFiyatTeklif.Name = "txtFiyatTeklif";
            this.txtFiyatTeklif.Size = new System.Drawing.Size(100, 23);
            this.txtFiyatTeklif.TabIndex = 37;
            this.txtFiyatTeklif.Text = "0";
            this.txtFiyatTeklif.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtFiyatTeklif.TextChanged += new System.EventHandler(this.txtFiyatTeklif_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(379, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 15);
            this.label6.TabIndex = 38;
            this.label6.Text = "Birim Fiyat Teklifiniz:";
            // 
            // frmTalep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtFiyatTeklif);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMevcutStok);
            this.Controls.Add(this.txtMevcutpara);
            this.Controls.Add(this.lblAltBaslik);
            this.Controls.Add(this.btnAnaSayfa);
            this.Controls.Add(this.cmbUrun);
            this.Controls.Add(this.cmbDoviz);
            this.Controls.Add(this.txtMiktar);
            this.Controls.Add(this.lblDoviz);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblUrun);
            this.Controls.Add(this.lblMiktar);
            this.Controls.Add(this.btnAl);
            this.Controls.Add(this.lblKonuBaslik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "frmTalep";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BorsaAppv1.0 - Alım Emri";
            this.Load += new System.EventHandler(this.frmTalep_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmTalep_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKonuBaslik;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMevcutStok;
        private System.Windows.Forms.TextBox txtMevcutpara;
        private System.Windows.Forms.Label lblAltBaslik;
        private System.Windows.Forms.Button btnAnaSayfa;
        private System.Windows.Forms.ComboBox cmbUrun;
        private System.Windows.Forms.ComboBox cmbDoviz;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.Label lblDoviz;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblUrun;
        private System.Windows.Forms.Label lblMiktar;
        private System.Windows.Forms.Button btnAl;
        private System.Windows.Forms.TextBox txtFiyatTeklif;
        private System.Windows.Forms.Label label6;
    }
}