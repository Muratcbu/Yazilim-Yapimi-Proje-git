
namespace Borsa
{
    partial class frmParaEkle
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtParamiktar = new System.Windows.Forms.TextBox();
            this.cmbDoviz = new System.Windows.Forms.ComboBox();
            this.btnParaekleme = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMevcutpara = new System.Windows.Forms.TextBox();
            this.btnAnaSayfa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(252, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Eklenecek Para Miktarı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(312, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Döviz Cinsi:";
            // 
            // txtParamiktar
            // 
            this.txtParamiktar.Location = new System.Drawing.Point(386, 187);
            this.txtParamiktar.Name = "txtParamiktar";
            this.txtParamiktar.Size = new System.Drawing.Size(121, 23);
            this.txtParamiktar.TabIndex = 1;
            this.txtParamiktar.Text = "0";
            this.txtParamiktar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cmbDoviz
            // 
            this.cmbDoviz.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDoviz.FormattingEnabled = true;
            this.cmbDoviz.Location = new System.Drawing.Point(386, 107);
            this.cmbDoviz.Name = "cmbDoviz";
            this.cmbDoviz.Size = new System.Drawing.Size(121, 23);
            this.cmbDoviz.TabIndex = 2;
            // 
            // btnParaekleme
            // 
            this.btnParaekleme.Location = new System.Drawing.Point(432, 263);
            this.btnParaekleme.Name = "btnParaekleme";
            this.btnParaekleme.Size = new System.Drawing.Size(75, 23);
            this.btnParaekleme.TabIndex = 3;
            this.btnParaekleme.Text = "Para &Ekle";
            this.btnParaekleme.UseVisualStyleBackColor = true;
            this.btnParaekleme.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(192, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 30);
            this.label3.TabIndex = 0;
            this.label3.Text = "Seçilen Döviz Cinsinden\r\nKasadaki Mevcut Onaylı Bakiyeniz:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMevcutpara
            // 
            this.txtMevcutpara.Location = new System.Drawing.Point(386, 145);
            this.txtMevcutpara.Name = "txtMevcutpara";
            this.txtMevcutpara.ReadOnly = true;
            this.txtMevcutpara.Size = new System.Drawing.Size(121, 23);
            this.txtMevcutpara.TabIndex = 1;
            this.txtMevcutpara.Text = "0";
            this.txtMevcutpara.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnAnaSayfa
            // 
            this.btnAnaSayfa.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnaSayfa.Location = new System.Drawing.Point(324, 262);
            this.btnAnaSayfa.Name = "btnAnaSayfa";
            this.btnAnaSayfa.Size = new System.Drawing.Size(75, 23);
            this.btnAnaSayfa.TabIndex = 4;
            this.btnAnaSayfa.Text = "Ana &Sayfa";
            this.btnAnaSayfa.UseVisualStyleBackColor = true;
            // 
            // frmParaEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAnaSayfa);
            this.Controls.Add(this.btnParaekleme);
            this.Controls.Add(this.cmbDoviz);
            this.Controls.Add(this.txtMevcutpara);
            this.Controls.Add(this.txtParamiktar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmParaEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BorsaApp v1.0 - Para Ekleme";
            this.Load += new System.EventHandler(this.frmParaEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtParamiktar;
        private System.Windows.Forms.ComboBox cmbDoviz;
        private System.Windows.Forms.Button btnParaekleme;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMevcutpara;
        private System.Windows.Forms.Button btnAnaSayfa;
    }
}