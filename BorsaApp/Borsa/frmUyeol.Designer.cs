
namespace Borsa
{
    partial class frmUyeol
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.RichTextBox();
            this.txtTc = new System.Windows.Forms.MaskedTextBox();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.txtSoyadi = new System.Windows.Forms.TextBox();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.txtEposta = new System.Windows.Forms.MaskedTextBox();
            this.btnUyeol = new System.Windows.Forms.Button();
            this.btniptal = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblGirisBaslik = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(200, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Soyad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(200, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Kullanıcı adı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(200, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Parola:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(200, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Telefon:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(200, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "E-posta:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(200, 271);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Adres:";
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(274, 268);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(185, 96);
            this.txtAdres.TabIndex = 7;
            this.txtAdres.Text = "Türkiye";
            this.txtAdres.Click += new System.EventHandler(this.txtAdres_Click);
            this.txtAdres.Validating += new System.ComponentModel.CancelEventHandler(this.txtAdres_Validating);
            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(274, 65);
            this.txtTc.Mask = "00000000000";
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(100, 23);
            this.txtTc.TabIndex = 0;
            this.txtTc.Text = "1";
            this.txtTc.ValidatingType = typeof(int);
            this.txtTc.Click += new System.EventHandler(this.txtTc_Click);
            this.txtTc.Validating += new System.ComponentModel.CancelEventHandler(this.txtTc_Validating);
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(274, 94);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(100, 23);
            this.txtAdi.TabIndex = 1;
            this.txtAdi.Text = "isim";
            this.txtAdi.Click += new System.EventHandler(this.txtAdi_Click);
            this.txtAdi.Validating += new System.ComponentModel.CancelEventHandler(this.txtAdi_Validating);
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.Location = new System.Drawing.Point(274, 123);
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.Size = new System.Drawing.Size(100, 23);
            this.txtSoyadi.TabIndex = 2;
            this.txtSoyadi.Text = "soyisim";
            this.txtSoyadi.Click += new System.EventHandler(this.txtSoyadi_Click);
            this.txtSoyadi.Validating += new System.ComponentModel.CancelEventHandler(this.txtSoyadi_Validating);
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(274, 152);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(100, 23);
            this.txtKullaniciAdi.TabIndex = 3;
            this.txtKullaniciAdi.Text = "kullanici";
            this.txtKullaniciAdi.Click += new System.EventHandler(this.txtKullaniciAdi_Click);
            this.txtKullaniciAdi.Validating += new System.ComponentModel.CancelEventHandler(this.txtKullaniciAdi_Validating);
            // 
            // txtParola
            // 
            this.txtParola.Location = new System.Drawing.Point(274, 181);
            this.txtParola.Name = "txtParola";
            this.txtParola.PasswordChar = '*';
            this.txtParola.Size = new System.Drawing.Size(100, 23);
            this.txtParola.TabIndex = 4;
            this.txtParola.Text = "parola";
            this.txtParola.Click += new System.EventHandler(this.txtParola_Click);
            this.txtParola.Validating += new System.ComponentModel.CancelEventHandler(this.txtParola_Validating);
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(274, 210);
            this.txtTelefon.Mask = "(999) 000-0000";
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(100, 23);
            this.txtTelefon.TabIndex = 5;
            this.txtTelefon.Text = "50";
            this.txtTelefon.Click += new System.EventHandler(this.txtTelefon_Click);
            this.txtTelefon.Validating += new System.ComponentModel.CancelEventHandler(this.txtTelefon_Validating);
            // 
            // txtEposta
            // 
            this.txtEposta.Location = new System.Drawing.Point(274, 239);
            this.txtEposta.Name = "txtEposta";
            this.txtEposta.Size = new System.Drawing.Size(100, 23);
            this.txtEposta.TabIndex = 6;
            this.txtEposta.Text = "x@y.com";
            this.txtEposta.Click += new System.EventHandler(this.txtEposta_Click);
            this.txtEposta.Validating += new System.ComponentModel.CancelEventHandler(this.txtEposta_Validating);
            // 
            // btnUyeol
            // 
            this.btnUyeol.Location = new System.Drawing.Point(508, 262);
            this.btnUyeol.Name = "btnUyeol";
            this.btnUyeol.Size = new System.Drawing.Size(95, 32);
            this.btnUyeol.TabIndex = 8;
            this.btnUyeol.Text = "Üye &Ol (F2)";
            this.btnUyeol.UseVisualStyleBackColor = true;
            this.btnUyeol.Click += new System.EventHandler(this.btnUyeol_Click);
            // 
            // btniptal
            // 
            this.btniptal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btniptal.Location = new System.Drawing.Point(508, 332);
            this.btniptal.Name = "btniptal";
            this.btniptal.Size = new System.Drawing.Size(95, 32);
            this.btniptal.TabIndex = 9;
            this.btniptal.Text = "İp&tal (ESC)";
            this.btniptal.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblGirisBaslik
            // 
            this.lblGirisBaslik.AutoSize = true;
            this.lblGirisBaslik.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGirisBaslik.Location = new System.Drawing.Point(245, 9);
            this.lblGirisBaslik.Name = "lblGirisBaslik";
            this.lblGirisBaslik.Size = new System.Drawing.Size(288, 36);
            this.lblGirisBaslik.TabIndex = 10;
            this.lblGirisBaslik.Text = "Borsa - Yeni Üye Kaydı";
            // 
            // frmUyeol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btniptal;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblGirisBaslik);
            this.Controls.Add(this.btniptal);
            this.Controls.Add(this.btnUyeol);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.txtSoyadi);
            this.Controls.Add(this.txtAdi);
            this.Controls.Add(this.txtEposta);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtTc);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "frmUyeol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BorsaApp v1.0 - Yeni Üyelik";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmUyeol_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox txtAdres;
        private System.Windows.Forms.MaskedTextBox txtTc;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.TextBox txtSoyadi;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.TextBox txtParola;
        private System.Windows.Forms.MaskedTextBox txtTelefon;
        private System.Windows.Forms.MaskedTextBox txtEposta;
        //private System.Windows.Forms.TextBox txtAd;
        //private System.Windows.Forms.TextBox txtSoyad;
        //private System.Windows.Forms.TextBox l;
        private System.Windows.Forms.Button btnUyeol;
        private System.Windows.Forms.Button btniptal;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblGirisBaslik;
    }
}