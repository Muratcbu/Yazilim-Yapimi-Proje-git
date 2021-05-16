
namespace Borsa
{
    partial class frmUrunAl
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
            this.btnAnaSayfa = new System.Windows.Forms.Button();
            this.cmbUrun = new System.Windows.Forms.ComboBox();
            this.cmbDoviz = new System.Windows.Forms.ComboBox();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAl = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMevcutpara = new System.Windows.Forms.TextBox();
            this.txtMevcutStok = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblGirisBaslik = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAnaSayfa
            // 
            this.btnAnaSayfa.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnaSayfa.Location = new System.Drawing.Point(336, 291);
            this.btnAnaSayfa.Name = "btnAnaSayfa";
            this.btnAnaSayfa.Size = new System.Drawing.Size(100, 23);
            this.btnAnaSayfa.TabIndex = 5;
            this.btnAnaSayfa.Text = "Ana &Sayfa (ESC)";
            this.btnAnaSayfa.UseVisualStyleBackColor = true;
            // 
            // cmbUrun
            // 
            this.cmbUrun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUrun.FormattingEnabled = true;
            this.cmbUrun.Location = new System.Drawing.Point(131, 208);
            this.cmbUrun.Name = "cmbUrun";
            this.cmbUrun.Size = new System.Drawing.Size(121, 23);
            this.cmbUrun.TabIndex = 1;
            this.cmbUrun.SelectedIndexChanged += new System.EventHandler(this.cmbUrun_SelectedIndexChanged);
            // 
            // cmbDoviz
            // 
            this.cmbDoviz.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDoviz.FormattingEnabled = true;
            this.cmbDoviz.Location = new System.Drawing.Point(301, 208);
            this.cmbDoviz.Name = "cmbDoviz";
            this.cmbDoviz.Size = new System.Drawing.Size(121, 23);
            this.cmbDoviz.TabIndex = 2;
            this.cmbDoviz.SelectedIndexChanged += new System.EventHandler(this.cmbDoviz_SelectedIndexChanged);
            // 
            // txtMiktar
            // 
            this.txtMiktar.Location = new System.Drawing.Point(461, 208);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(121, 23);
            this.txtMiktar.TabIndex = 3;
            this.txtMiktar.Text = "0";
            this.txtMiktar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(301, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Döviz Cinsi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(154, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Alınacak Ürün";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(471, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Miktarı (sayı giriniz)";
            // 
            // btnAl
            // 
            this.btnAl.Location = new System.Drawing.Point(488, 291);
            this.btnAl.Name = "btnAl";
            this.btnAl.Size = new System.Drawing.Size(94, 23);
            this.btnAl.TabIndex = 6;
            this.btnAl.Text = "Alım &Yap (F2)";
            this.btnAl.UseVisualStyleBackColor = true;
            this.btnAl.Click += new System.EventHandler(this.btnAl_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(217, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(318, 21);
            this.label3.TabIndex = 17;
            this.label3.Text = "Almak İstediğiniz Ürün Bilgilerini Giriniz";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(337, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Mevcut Onaylı Bakiyeniz:";
            // 
            // txtMevcutpara
            // 
            this.txtMevcutpara.ForeColor = System.Drawing.Color.Red;
            this.txtMevcutpara.Location = new System.Drawing.Point(482, 92);
            this.txtMevcutpara.Name = "txtMevcutpara";
            this.txtMevcutpara.ReadOnly = true;
            this.txtMevcutpara.Size = new System.Drawing.Size(100, 23);
            this.txtMevcutpara.TabIndex = 0;
            // 
            // txtMevcutStok
            // 
            this.txtMevcutStok.Location = new System.Drawing.Point(461, 246);
            this.txtMevcutStok.Name = "txtMevcutStok";
            this.txtMevcutStok.Size = new System.Drawing.Size(120, 23);
            this.txtMevcutStok.TabIndex = 4;
            this.txtMevcutStok.Text = "0";
            this.txtMevcutStok.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(188, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(267, 15);
            this.label7.TabIndex = 21;
            this.label7.Text = "Seçtiğiniz ürün ve döviz cinsine göre toplam stok:";
            // 
            // lblGirisBaslik
            // 
            this.lblGirisBaslik.AutoSize = true;
            this.lblGirisBaslik.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGirisBaslik.Location = new System.Drawing.Point(245, 9);
            this.lblGirisBaslik.Name = "lblGirisBaslik";
            this.lblGirisBaslik.Size = new System.Drawing.Size(308, 36);
            this.lblGirisBaslik.TabIndex = 22;
            this.lblGirisBaslik.Text = "Borsa - Ürün Satın Alma";
            // 
            // frmUrunAl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblGirisBaslik);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "frmUrunAl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BorsApp v1.0 - Ürün Alımı";
            this.Load += new System.EventHandler(this.frmUrunAl_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmUrunAl_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAnaSayfa;
        private System.Windows.Forms.ComboBox cmbUrun;
        private System.Windows.Forms.ComboBox cmbDoviz;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMevcutpara;
        private System.Windows.Forms.TextBox txtMevcutStok;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblGirisBaslik;
    }
}