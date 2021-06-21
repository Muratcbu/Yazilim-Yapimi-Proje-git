
namespace Borsa
{
    partial class frmRapor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblRaporBaslik = new System.Windows.Forms.Label();
            this.dgvRapor = new System.Windows.Forms.DataGridView();
            this.dtpBaslangic = new System.Windows.Forms.DateTimePicker();
            this.dtpBitis = new System.Windows.Forms.DateTimePicker();
            this.lblBitis = new System.Windows.Forms.Label();
            this.lblBaslangic = new System.Windows.Forms.Label();
            this.btnRaporGoster = new System.Windows.Forms.Button();
            this.btnAnaSayfa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRapor)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRaporBaslik
            // 
            this.lblRaporBaslik.AutoSize = true;
            this.lblRaporBaslik.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRaporBaslik.Location = new System.Drawing.Point(273, 10);
            this.lblRaporBaslik.Name = "lblRaporBaslik";
            this.lblRaporBaslik.Size = new System.Drawing.Size(251, 36);
            this.lblRaporBaslik.TabIndex = 6;
            this.lblRaporBaslik.Text = "Borsa - Rapor Alma";
            // 
            // dgvRapor
            // 
            this.dgvRapor.AllowUserToAddRows = false;
            this.dgvRapor.AllowUserToDeleteRows = false;
            this.dgvRapor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRapor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRapor.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvRapor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvRapor.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRapor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvRapor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRapor.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvRapor.EnableHeadersVisualStyles = false;
            this.dgvRapor.Location = new System.Drawing.Point(0, 222);
            this.dgvRapor.Name = "dgvRapor";
            this.dgvRapor.ReadOnly = true;
            this.dgvRapor.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvRapor.RowHeadersVisible = false;
            this.dgvRapor.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Green;
            this.dgvRapor.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvRapor.RowTemplate.Height = 25;
            this.dgvRapor.Size = new System.Drawing.Size(804, 323);
            this.dgvRapor.TabIndex = 3;
            // 
            // dtpBaslangic
            // 
            this.dtpBaslangic.Location = new System.Drawing.Point(57, 92);
            this.dtpBaslangic.Name = "dtpBaslangic";
            this.dtpBaslangic.Size = new System.Drawing.Size(175, 25);
            this.dtpBaslangic.TabIndex = 0;
            this.dtpBaslangic.Value = new System.DateTime(2021, 6, 20, 13, 2, 3, 0);
            // 
            // dtpBitis
            // 
            this.dtpBitis.Location = new System.Drawing.Point(276, 92);
            this.dtpBitis.Name = "dtpBitis";
            this.dtpBitis.Size = new System.Drawing.Size(175, 25);
            this.dtpBitis.TabIndex = 1;
            // 
            // lblBitis
            // 
            this.lblBitis.AutoSize = true;
            this.lblBitis.Location = new System.Drawing.Point(273, 68);
            this.lblBitis.Name = "lblBitis";
            this.lblBitis.Size = new System.Drawing.Size(112, 17);
            this.lblBitis.TabIndex = 16;
            this.lblBitis.Text = "Bitiş Tarihi Seçiniz:";
            // 
            // lblBaslangic
            // 
            this.lblBaslangic.AutoSize = true;
            this.lblBaslangic.Location = new System.Drawing.Point(57, 68);
            this.lblBaslangic.Name = "lblBaslangic";
            this.lblBaslangic.Size = new System.Drawing.Size(140, 17);
            this.lblBaslangic.TabIndex = 15;
            this.lblBaslangic.Text = "Başlangıç Tarihi Seçiniz";
            // 
            // btnRaporGoster
            // 
            this.btnRaporGoster.Location = new System.Drawing.Point(497, 93);
            this.btnRaporGoster.Name = "btnRaporGoster";
            this.btnRaporGoster.Size = new System.Drawing.Size(123, 26);
            this.btnRaporGoster.TabIndex = 2;
            this.btnRaporGoster.Text = "&Rapor Göster (R)";
            this.btnRaporGoster.UseVisualStyleBackColor = true;
            this.btnRaporGoster.Click += new System.EventHandler(this.btnRaporGoster_Click);
            // 
            // btnAnaSayfa
            // 
            this.btnAnaSayfa.Location = new System.Drawing.Point(640, 92);
            this.btnAnaSayfa.Name = "btnAnaSayfa";
            this.btnAnaSayfa.Size = new System.Drawing.Size(123, 27);
            this.btnAnaSayfa.TabIndex = 17;
            this.btnAnaSayfa.Text = "Ana sayfa (ESC)";
            this.btnAnaSayfa.UseVisualStyleBackColor = true;
            // 
            // frmRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 545);
            this.Controls.Add(this.btnAnaSayfa);
            this.Controls.Add(this.btnRaporGoster);
            this.Controls.Add(this.lblBaslangic);
            this.Controls.Add(this.lblBitis);
            this.Controls.Add(this.dtpBitis);
            this.Controls.Add(this.dtpBaslangic);
            this.Controls.Add(this.dgvRapor);
            this.Controls.Add(this.lblRaporBaslik);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "frmRapor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BorsaApp v1.0";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmRapor_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRapor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRaporBaslik;
        private System.Windows.Forms.DataGridView dgvRapor;
        private System.Windows.Forms.DateTimePicker dtpBaslangic;
        private System.Windows.Forms.DateTimePicker dtpBitis;
        private System.Windows.Forms.Label lblBitis;
        private System.Windows.Forms.Label lblBaslangic;
        private System.Windows.Forms.Button btnRaporGoster;
        private System.Windows.Forms.Button btnAnaSayfa;
    }
}