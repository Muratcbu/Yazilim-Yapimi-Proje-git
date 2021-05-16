
namespace Borsa
{
    partial class frmUrunSat
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
            this.btnMalekle = new System.Windows.Forms.Button();
            this.cmbDoviz = new System.Windows.Forms.ComboBox();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbUrun = new System.Windows.Forms.ComboBox();
            this.btnAnaSayfa = new System.Windows.Forms.Button();
            this.lblGirisBaslik = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMalekle
            // 
            this.btnMalekle.Location = new System.Drawing.Point(401, 248);
            this.btnMalekle.Name = "btnMalekle";
            this.btnMalekle.Size = new System.Drawing.Size(103, 23);
            this.btnMalekle.TabIndex = 5;
            this.btnMalekle.Text = "Mal &Ekle (F2)";
            this.btnMalekle.UseVisualStyleBackColor = true;
            this.btnMalekle.Click += new System.EventHandler(this.btnMalekle_Click);
            // 
            // cmbDoviz
            // 
            this.cmbDoviz.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDoviz.FormattingEnabled = true;
            this.cmbDoviz.Location = new System.Drawing.Point(383, 188);
            this.cmbDoviz.Name = "cmbDoviz";
            this.cmbDoviz.Size = new System.Drawing.Size(121, 23);
            this.cmbDoviz.TabIndex = 3;
            // 
            // txtMiktar
            // 
            this.txtMiktar.Location = new System.Drawing.Point(383, 121);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(121, 23);
            this.txtMiktar.TabIndex = 1;
            this.txtMiktar.Text = "0";
            this.txtMiktar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(309, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Döviz Cinsi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(249, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Eklenecek Ürün Miktarı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(227, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Eklenecek Ürün Birim Fiyatı:";
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(383, 154);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(121, 23);
            this.txtFiyat.TabIndex = 2;
            this.txtFiyat.Text = "0";
            this.txtFiyat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(240, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Eklenecek Ürünü Seçiniz :";
            // 
            // cmbUrun
            // 
            this.cmbUrun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUrun.FormattingEnabled = true;
            this.cmbUrun.Location = new System.Drawing.Point(383, 87);
            this.cmbUrun.Name = "cmbUrun";
            this.cmbUrun.Size = new System.Drawing.Size(121, 23);
            this.cmbUrun.TabIndex = 0;
            // 
            // btnAnaSayfa
            // 
            this.btnAnaSayfa.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnaSayfa.Location = new System.Drawing.Point(267, 248);
            this.btnAnaSayfa.Name = "btnAnaSayfa";
            this.btnAnaSayfa.Size = new System.Drawing.Size(110, 23);
            this.btnAnaSayfa.TabIndex = 4;
            this.btnAnaSayfa.Text = "Ana &Sayfa (ESC)";
            this.btnAnaSayfa.UseVisualStyleBackColor = true;
            // 
            // lblGirisBaslik
            // 
            this.lblGirisBaslik.AutoSize = true;
            this.lblGirisBaslik.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGirisBaslik.Location = new System.Drawing.Point(205, 9);
            this.lblGirisBaslik.Name = "lblGirisBaslik";
            this.lblGirisBaslik.Size = new System.Drawing.Size(346, 36);
            this.lblGirisBaslik.TabIndex = 7;
            this.lblGirisBaslik.Text = "Borsa - Satılık Ürün Ekleme";
            // 
            // frmUrunSat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblGirisBaslik);
            this.Controls.Add(this.btnAnaSayfa);
            this.Controls.Add(this.cmbUrun);
            this.Controls.Add(this.cmbDoviz);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.txtMiktar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMalekle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "frmUrunSat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BorsaApp v1.0 - Sisteme Mal Ekleme";
            this.Load += new System.EventHandler(this.frmUrunSat_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmUrunSat_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMalekle;
        private System.Windows.Forms.ComboBox cmbDoviz;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbUrun;
        private System.Windows.Forms.Button btnAnaSayfa;
        private System.Windows.Forms.Label lblGirisBaslik;
    }
}