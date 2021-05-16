
namespace Borsa
{
    partial class frmGiris
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
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.lblParola = new System.Windows.Forms.Label();
            this.txtKullaniciAd = new System.Windows.Forms.TextBox();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.btnUyeol = new System.Windows.Forms.Button();
            this.btnGiris = new System.Windows.Forms.Button();
            this.btniptal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblGirisBaslik
            // 
            this.lblGirisBaslik.AutoSize = true;
            this.lblGirisBaslik.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGirisBaslik.Location = new System.Drawing.Point(130, 29);
            this.lblGirisBaslik.Name = "lblGirisBaslik";
            this.lblGirisBaslik.Size = new System.Drawing.Size(244, 36);
            this.lblGirisBaslik.TabIndex = 0;
            this.lblGirisBaslik.Text = "Borsa - Giriş Ekranı";
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblKullaniciAdi.Location = new System.Drawing.Point(119, 109);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(96, 21);
            this.lblKullaniciAdi.TabIndex = 1;
            this.lblKullaniciAdi.Text = "Kullanıcı adı:";
            // 
            // lblParola
            // 
            this.lblParola.AutoSize = true;
            this.lblParola.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblParola.Location = new System.Drawing.Point(119, 151);
            this.lblParola.Name = "lblParola";
            this.lblParola.Size = new System.Drawing.Size(56, 21);
            this.lblParola.TabIndex = 1;
            this.lblParola.Text = "Parola:";
            // 
            // txtKullaniciAd
            // 
            this.txtKullaniciAd.Location = new System.Drawing.Point(260, 107);
            this.txtKullaniciAd.Name = "txtKullaniciAd";
            this.txtKullaniciAd.Size = new System.Drawing.Size(124, 23);
            this.txtKullaniciAd.TabIndex = 0;
            // 
            // txtParola
            // 
            this.txtParola.Location = new System.Drawing.Point(260, 149);
            this.txtParola.Name = "txtParola";
            this.txtParola.PasswordChar = '*';
            this.txtParola.Size = new System.Drawing.Size(124, 23);
            this.txtParola.TabIndex = 1;
            // 
            // btnUyeol
            // 
            this.btnUyeol.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUyeol.Location = new System.Drawing.Point(119, 296);
            this.btnUyeol.Name = "btnUyeol";
            this.btnUyeol.Size = new System.Drawing.Size(81, 35);
            this.btnUyeol.TabIndex = 2;
            this.btnUyeol.Text = "Üye &Ol";
            this.btnUyeol.UseVisualStyleBackColor = true;
            this.btnUyeol.Click += new System.EventHandler(this.btnUyeol_Click);
            // 
            // btnGiris
            // 
            this.btnGiris.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGiris.Location = new System.Drawing.Point(219, 296);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(81, 35);
            this.btnGiris.TabIndex = 3;
            this.btnGiris.Text = "Giriş &Yap";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // btniptal
            // 
            this.btniptal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btniptal.Location = new System.Drawing.Point(316, 296);
            this.btniptal.Name = "btniptal";
            this.btniptal.Size = new System.Drawing.Size(81, 35);
            this.btniptal.TabIndex = 4;
            this.btniptal.Text = "İ&ptal";
            this.btniptal.UseVisualStyleBackColor = true;
            this.btniptal.Click += new System.EventHandler(this.btniptal_Click);
            // 
            // frmGiris
            // 
            this.AcceptButton = this.btnGiris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 450);
            this.Controls.Add(this.btniptal);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.btnUyeol);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.txtKullaniciAd);
            this.Controls.Add(this.lblParola);
            this.Controls.Add(this.lblKullaniciAdi);
            this.Controls.Add(this.lblGirisBaslik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BorsaApp v1.0 - Giriş";
            this.Load += new System.EventHandler(this.frmGiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGirisBaslik;
        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.Label lblParola;
        private System.Windows.Forms.TextBox txtKullaniciAd;
        private System.Windows.Forms.TextBox txtParola;
        private System.Windows.Forms.Button btnUyeol;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Button btniptal;
    }
}