
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
            this.lblGirisBaslik = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMevcutStok = new System.Windows.Forms.TextBox();
            this.txtMevcutpara = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAnaSayfa = new System.Windows.Forms.Button();
            this.cmbUrun = new System.Windows.Forms.ComboBox();
            this.cmbDoviz = new System.Windows.Forms.ComboBox();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAl = new System.Windows.Forms.Button();
            this.txtFiyatTeklif = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblGirisBaslik
            // 
            this.lblGirisBaslik.AutoSize = true;
            this.lblGirisBaslik.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGirisBaslik.Location = new System.Drawing.Point(246, 29);
            this.lblGirisBaslik.Name = "lblGirisBaslik";
            this.lblGirisBaslik.Size = new System.Drawing.Size(226, 36);
            this.lblGirisBaslik.TabIndex = 23;
            this.lblGirisBaslik.Text = "Borsa - Alım Emri";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(337, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 30);
            this.label7.TabIndex = 36;
            this.label7.Text = "Ürün, döviz ve fiyat\r\nteklifine uygun toplam stok:";
            // 
            // txtMevcutStok
            // 
            this.txtMevcutStok.Location = new System.Drawing.Point(496, 175);
            this.txtMevcutStok.Name = "txtMevcutStok";
            this.txtMevcutStok.ReadOnly = true;
            this.txtMevcutStok.Size = new System.Drawing.Size(120, 23);
            this.txtMevcutStok.TabIndex = 28;
            this.txtMevcutStok.Text = "0";
            this.txtMevcutStok.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtMevcutpara
            // 
            this.txtMevcutpara.ForeColor = System.Drawing.Color.Red;
            this.txtMevcutpara.Location = new System.Drawing.Point(219, 175);
            this.txtMevcutpara.Name = "txtMevcutpara";
            this.txtMevcutpara.ReadOnly = true;
            this.txtMevcutpara.Size = new System.Drawing.Size(100, 23);
            this.txtMevcutpara.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(76, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(318, 21);
            this.label3.TabIndex = 35;
            this.label3.Text = "Almak İstediğiniz Ürün Bilgilerini Giriniz";
            // 
            // btnAnaSayfa
            // 
            this.btnAnaSayfa.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnaSayfa.Location = new System.Drawing.Point(370, 234);
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
            this.cmbUrun.Location = new System.Drawing.Point(198, 99);
            this.cmbUrun.Name = "cmbUrun";
            this.cmbUrun.Size = new System.Drawing.Size(121, 23);
            this.cmbUrun.TabIndex = 25;
            this.cmbUrun.SelectedIndexChanged += new System.EventHandler(this.cmbUrun_SelectedIndexChanged);
            // 
            // cmbDoviz
            // 
            this.cmbDoviz.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDoviz.FormattingEnabled = true;
            this.cmbDoviz.Location = new System.Drawing.Point(496, 99);
            this.cmbDoviz.Name = "cmbDoviz";
            this.cmbDoviz.Size = new System.Drawing.Size(121, 23);
            this.cmbDoviz.TabIndex = 26;
            this.cmbDoviz.SelectedIndexChanged += new System.EventHandler(this.cmbDoviz_SelectedIndexChanged);
            // 
            // txtMiktar
            // 
            this.txtMiktar.Location = new System.Drawing.Point(198, 128);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(121, 23);
            this.txtMiktar.TabIndex = 27;
            this.txtMiktar.Text = "0";
            this.txtMiktar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMiktar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMiktar_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(422, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 31;
            this.label2.Text = "Döviz Cinsi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 15);
            this.label4.TabIndex = 32;
            this.label4.Text = "Mevcut Onaylı Bakiyeniz:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 15);
            this.label5.TabIndex = 33;
            this.label5.Text = "Alınacak Ürün";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 15);
            this.label1.TabIndex = 34;
            this.label1.Text = "Miktarı (sayı giriniz)";
            // 
            // btnAl
            // 
            this.btnAl.Location = new System.Drawing.Point(522, 234);
            this.btnAl.Name = "btnAl";
            this.btnAl.Size = new System.Drawing.Size(94, 23);
            this.btnAl.TabIndex = 30;
            this.btnAl.Text = "Alım &Yap (F2)";
            this.btnAl.UseVisualStyleBackColor = true;
            this.btnAl.Click += new System.EventHandler(this.btnAl_Click);
            // 
            // txtFiyatTeklif
            // 
            this.txtFiyatTeklif.Location = new System.Drawing.Point(496, 128);
            this.txtFiyatTeklif.Name = "txtFiyatTeklif";
            this.txtFiyatTeklif.Size = new System.Drawing.Size(121, 23);
            this.txtFiyatTeklif.TabIndex = 37;
            this.txtFiyatTeklif.Text = "0";
            this.txtFiyatTeklif.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtFiyatTeklif.TextChanged += new System.EventHandler(this.txtFiyatTeklif_TextChanged);
            this.txtFiyatTeklif.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFiyatTeklif_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(376, 134);
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
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAnaSayfa);
            this.Controls.Add(this.cmbUrun);
            this.Controls.Add(this.cmbDoviz);
            this.Controls.Add(this.txtMiktar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAl);
            this.Controls.Add(this.lblGirisBaslik);
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

        private System.Windows.Forms.Label lblGirisBaslik;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMevcutStok;
        private System.Windows.Forms.TextBox txtMevcutpara;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAnaSayfa;
        private System.Windows.Forms.ComboBox cmbUrun;
        private System.Windows.Forms.ComboBox cmbDoviz;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAl;
        private System.Windows.Forms.TextBox txtFiyatTeklif;
        private System.Windows.Forms.Label label6;
    }
}