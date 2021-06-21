
namespace Borsa
{
    partial class frmUrunOnayla
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.lblAra = new System.Windows.Forms.Label();
            this.btnAnasayfa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dg = new System.Windows.Forms.DataGridView();
            this.lblGirisBaslik = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(240, 6);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(100, 23);
            this.txtAra.TabIndex = 0;
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
            // lblAra
            // 
            this.lblAra.AutoSize = true;
            this.lblAra.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAra.Location = new System.Drawing.Point(12, 9);
            this.lblAra.Name = "lblAra";
            this.lblAra.Size = new System.Drawing.Size(222, 15);
            this.lblAra.TabIndex = 3;
            this.lblAra.Text = "Kullanıcı adı ile arama yapabilirsiniz: -->";
            // 
            // btnAnasayfa
            // 
            this.btnAnasayfa.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnasayfa.Location = new System.Drawing.Point(384, 102);
            this.btnAnasayfa.Name = "btnAnasayfa";
            this.btnAnasayfa.Size = new System.Drawing.Size(143, 30);
            this.btnAnasayfa.TabIndex = 1;
            this.btnAnasayfa.Text = "Ana &sayfaya dön (ESC)";
            this.btnAnasayfa.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 90);
            this.label1.TabIndex = 5;
            this.label1.Text = "Aşağıdaki alanda işlem yapmak istediğiniz ürün hücresine tıklayın.\r\n\r\nONAYLAMAK i" +
    "çin 1\r\nONAY İPTALİ için  0\r\n\r\nyazın ve ENTER tuşlayın.";
            // 
            // dg
            // 
            this.dg.AllowUserToAddRows = false;
            this.dg.AllowUserToDeleteRows = false;
            this.dg.AllowUserToOrderColumns = true;
            this.dg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dg.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Green;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dg.DefaultCellStyle = dataGridViewCellStyle2;
            this.dg.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dg.EnableHeadersVisualStyles = false;
            this.dg.Location = new System.Drawing.Point(0, 161);
            this.dg.Name = "dg";
            this.dg.RowHeadersVisible = false;
            this.dg.RowTemplate.Height = 25;
            this.dg.Size = new System.Drawing.Size(981, 322);
            this.dg.TabIndex = 2;
            this.dg.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_CellValueChanged);
            // 
            // lblGirisBaslik
            // 
            this.lblGirisBaslik.AutoSize = true;
            this.lblGirisBaslik.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGirisBaslik.Location = new System.Drawing.Point(563, 6);
            this.lblGirisBaslik.Name = "lblGirisBaslik";
            this.lblGirisBaslik.Size = new System.Drawing.Size(305, 36);
            this.lblGirisBaslik.TabIndex = 6;
            this.lblGirisBaslik.Text = "Borsa - Yeni Ürün Onayı";
            // 
            // frmUrunOnayla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 483);
            this.Controls.Add(this.lblGirisBaslik);
            this.Controls.Add(this.dg);
            this.Controls.Add(this.btnAnasayfa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.lblAra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "frmUrunOnayla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BorsaApp v1.0 - Ürün Onaylama";
            this.Load += new System.EventHandler(this.frmUrunOnayla_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmUrunOnayla_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Label lblAra;
        private System.Windows.Forms.Button btnAnasayfa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.Label lblGirisBaslik;
    }
}