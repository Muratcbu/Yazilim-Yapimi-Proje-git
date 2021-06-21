
namespace Borsa
{
    partial class frmAna
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.YoneticicontextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.UrunOnaylaMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ParaOnaylaMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.grpboxKullanici = new System.Windows.Forms.GroupBox();
            this.btnTalep = new System.Windows.Forms.Button();
            this.btnAlimYap = new System.Windows.Forms.Button();
            this.btnMalEkle = new System.Windows.Forms.Button();
            this.btnParaEkle = new System.Windows.Forms.Button();
            this.grpboxAdmin = new System.Windows.Forms.GroupBox();
            this.btnMalOnayla = new System.Windows.Forms.Button();
            this.btnParaOnayla = new System.Windows.Forms.Button();
            this.btnBitir = new System.Windows.Forms.Button();
            this.btnGiris = new System.Windows.Forms.Button();
            this.lblGirisBaslik = new System.Windows.Forms.Label();
            this.btnRapor = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.YoneticicontextMenuStrip1.SuspendLayout();
            this.grpboxKullanici.SuspendLayout();
            this.grpboxAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "Merhaba";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(56, 17);
            this.toolStripStatusLabel1.Text = "Merhaba";
            // 
            // YoneticicontextMenuStrip1
            // 
            this.YoneticicontextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UrunOnaylaMenu,
            this.ParaOnaylaMenu});
            this.YoneticicontextMenuStrip1.Name = "YoneticicontextMenuStrip1";
            this.YoneticicontextMenuStrip1.Size = new System.Drawing.Size(178, 48);
            // 
            // UrunOnaylaMenu
            // 
            this.UrunOnaylaMenu.Name = "UrunOnaylaMenu";
            this.UrunOnaylaMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.R)));
            this.UrunOnaylaMenu.Size = new System.Drawing.Size(177, 22);
            this.UrunOnaylaMenu.Text = "U&run Onayla";
            // 
            // ParaOnaylaMenu
            // 
            this.ParaOnaylaMenu.Name = "ParaOnaylaMenu";
            this.ParaOnaylaMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.N)));
            this.ParaOnaylaMenu.Size = new System.Drawing.Size(177, 22);
            this.ParaOnaylaMenu.Text = "Para O&nayla";
            // 
            // grpboxKullanici
            // 
            this.grpboxKullanici.Controls.Add(this.btnTalep);
            this.grpboxKullanici.Controls.Add(this.btnAlimYap);
            this.grpboxKullanici.Controls.Add(this.btnMalEkle);
            this.grpboxKullanici.Controls.Add(this.btnParaEkle);
            this.grpboxKullanici.Location = new System.Drawing.Point(149, 71);
            this.grpboxKullanici.Name = "grpboxKullanici";
            this.grpboxKullanici.Size = new System.Drawing.Size(508, 79);
            this.grpboxKullanici.TabIndex = 4;
            this.grpboxKullanici.TabStop = false;
            this.grpboxKullanici.Text = "Kullanıcı İşlemleri";
            // 
            // btnTalep
            // 
            this.btnTalep.Location = new System.Drawing.Point(384, 22);
            this.btnTalep.Name = "btnTalep";
            this.btnTalep.Size = new System.Drawing.Size(108, 32);
            this.btnTalep.TabIndex = 1;
            this.btnTalep.Text = "Alım &Emri Ver (E)";
            this.btnTalep.UseVisualStyleBackColor = true;
            this.btnTalep.Click += new System.EventHandler(this.btnTalep_Click);
            // 
            // btnAlimYap
            // 
            this.btnAlimYap.Location = new System.Drawing.Point(262, 22);
            this.btnAlimYap.Name = "btnAlimYap";
            this.btnAlimYap.Size = new System.Drawing.Size(108, 32);
            this.btnAlimYap.TabIndex = 1;
            this.btnAlimYap.Text = "&Alım Yap (A)";
            this.btnAlimYap.UseVisualStyleBackColor = true;
            this.btnAlimYap.Click += new System.EventHandler(this.btnAlimYap_Click);
            // 
            // btnMalEkle
            // 
            this.btnMalEkle.Location = new System.Drawing.Point(139, 23);
            this.btnMalEkle.Name = "btnMalEkle";
            this.btnMalEkle.Size = new System.Drawing.Size(108, 32);
            this.btnMalEkle.TabIndex = 1;
            this.btnMalEkle.Text = "&Mal Ekle (M)";
            this.btnMalEkle.UseVisualStyleBackColor = true;
            this.btnMalEkle.Click += new System.EventHandler(this.btnMalEkle_Click);
            // 
            // btnParaEkle
            // 
            this.btnParaEkle.Location = new System.Drawing.Point(18, 23);
            this.btnParaEkle.Name = "btnParaEkle";
            this.btnParaEkle.Size = new System.Drawing.Size(108, 32);
            this.btnParaEkle.TabIndex = 0;
            this.btnParaEkle.Text = "&Para Ekle (P)";
            this.btnParaEkle.UseVisualStyleBackColor = true;
            this.btnParaEkle.Click += new System.EventHandler(this.btnParaEkle_Click);
            // 
            // grpboxAdmin
            // 
            this.grpboxAdmin.Controls.Add(this.btnMalOnayla);
            this.grpboxAdmin.Controls.Add(this.btnParaOnayla);
            this.grpboxAdmin.Location = new System.Drawing.Point(149, 218);
            this.grpboxAdmin.Name = "grpboxAdmin";
            this.grpboxAdmin.Size = new System.Drawing.Size(508, 76);
            this.grpboxAdmin.TabIndex = 4;
            this.grpboxAdmin.TabStop = false;
            this.grpboxAdmin.Text = "Yönetici İşlemleri";
            // 
            // btnMalOnayla
            // 
            this.btnMalOnayla.Location = new System.Drawing.Point(225, 22);
            this.btnMalOnayla.Name = "btnMalOnayla";
            this.btnMalOnayla.Size = new System.Drawing.Size(108, 32);
            this.btnMalOnayla.TabIndex = 6;
            this.btnMalOnayla.Text = "Mal O&nayla (N)";
            this.btnMalOnayla.UseVisualStyleBackColor = true;
            this.btnMalOnayla.Click += new System.EventHandler(this.btnMalOnayla_Click);
            // 
            // btnParaOnayla
            // 
            this.btnParaOnayla.Location = new System.Drawing.Point(18, 23);
            this.btnParaOnayla.Name = "btnParaOnayla";
            this.btnParaOnayla.Size = new System.Drawing.Size(108, 32);
            this.btnParaOnayla.TabIndex = 5;
            this.btnParaOnayla.Text = "Para &Onayla (O)";
            this.btnParaOnayla.UseVisualStyleBackColor = true;
            this.btnParaOnayla.Click += new System.EventHandler(this.btnParaOnayla_Click);
            // 
            // btnBitir
            // 
            this.btnBitir.Location = new System.Drawing.Point(327, 166);
            this.btnBitir.Name = "btnBitir";
            this.btnBitir.Size = new System.Drawing.Size(155, 32);
            this.btnBitir.TabIndex = 4;
            this.btnBitir.Text = "Programdan &Çıkış (Ç)";
            this.btnBitir.UseVisualStyleBackColor = true;
            this.btnBitir.Click += new System.EventHandler(this.btnBitir_Click);
            // 
            // btnGiris
            // 
            this.btnGiris.Location = new System.Drawing.Point(167, 166);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(155, 32);
            this.btnGiris.TabIndex = 3;
            this.btnGiris.Text = "&Yeniden Oturum Açma (Y)";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // lblGirisBaslik
            // 
            this.lblGirisBaslik.AutoSize = true;
            this.lblGirisBaslik.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGirisBaslik.Location = new System.Drawing.Point(271, 9);
            this.lblGirisBaslik.Name = "lblGirisBaslik";
            this.lblGirisBaslik.Size = new System.Drawing.Size(239, 36);
            this.lblGirisBaslik.TabIndex = 5;
            this.lblGirisBaslik.Text = "Borsa - Ana Ekranı";
            // 
            // btnRapor
            // 
            this.btnRapor.Location = new System.Drawing.Point(486, 166);
            this.btnRapor.Name = "btnRapor";
            this.btnRapor.Size = new System.Drawing.Size(155, 32);
            this.btnRapor.TabIndex = 4;
            this.btnRapor.Text = "&Rapor Al (R)";
            this.btnRapor.UseVisualStyleBackColor = true;
            this.btnRapor.Click += new System.EventHandler(this.btnRapor_Click);
            // 
            // formAna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblGirisBaslik);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.btnRapor);
            this.Controls.Add(this.btnBitir);
            this.Controls.Add(this.grpboxAdmin);
            this.Controls.Add(this.grpboxKullanici);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "frmAna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BorsaApp v1.0";
            this.Load += new System.EventHandler(this.frmAna_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.YoneticicontextMenuStrip1.ResumeLayout(false);
            this.grpboxKullanici.ResumeLayout(false);
            this.grpboxAdmin.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripMenuItem YoneticitoolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip YoneticicontextMenuStrip1;
        public System.Windows.Forms.ToolStripMenuItem UrunOnaylaMenu;
        private System.Windows.Forms.ToolStripMenuItem ParaOnaylaMenu;
        private System.Windows.Forms.GroupBox grpboxKullanici;
        private System.Windows.Forms.Button btnMalEkle;
        private System.Windows.Forms.Button btnParaEkle;
        private System.Windows.Forms.GroupBox grpboxAdmin;
        private System.Windows.Forms.Button btnAlimYap;
        private System.Windows.Forms.Button btnMalOnayla;
        private System.Windows.Forms.Button btnParaOnayla;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button btnBitir;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Label lblGirisBaslik;
        private System.Windows.Forms.Button btnTalep;
        private System.Windows.Forms.Button btnRapor;
    }
}

