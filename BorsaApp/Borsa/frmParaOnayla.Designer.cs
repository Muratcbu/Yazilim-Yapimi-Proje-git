
namespace Borsa
{
    partial class frmParaOnayla
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.lblAra = new System.Windows.Forms.Label();
            this.btnAnasayfa = new System.Windows.Forms.Button();
            this.lblGirisBaslik = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Green;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv.EnableHeadersVisualStyles = false;
            this.dgv.Location = new System.Drawing.Point(0, 158);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowTemplate.Height = 25;
            this.dgv.Size = new System.Drawing.Size(800, 294);
            this.dgv.TabIndex = 2;
            this.dgv.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 90);
            this.label1.TabIndex = 1;
            this.label1.Text = "Aşağıdaki alanda işlem yapmak istediğiniz bakiye hücresine tıklayın.\r\n\r\nONAYLAMAK" +
    " için 1\r\nONAY İPTALİ için  0\r\n\r\nyazın ve ENTER tuşlayın.";
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
            this.lblAra.TabIndex = 1;
            this.lblAra.Text = "Kullanıcı adı ile arama yapabilirsiniz: -->";
            // 
            // btnAnasayfa
            // 
            this.btnAnasayfa.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnasayfa.Location = new System.Drawing.Point(449, 98);
            this.btnAnasayfa.Name = "btnAnasayfa";
            this.btnAnasayfa.Size = new System.Drawing.Size(139, 30);
            this.btnAnasayfa.TabIndex = 1;
            this.btnAnasayfa.Text = "Ana &sayfaya dön (ESC)";
            this.btnAnasayfa.UseVisualStyleBackColor = true;
            // 
            // lblGirisBaslik
            // 
            this.lblGirisBaslik.AutoSize = true;
            this.lblGirisBaslik.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGirisBaslik.Location = new System.Drawing.Point(412, 6);
            this.lblGirisBaslik.Name = "lblGirisBaslik";
            this.lblGirisBaslik.Size = new System.Drawing.Size(334, 36);
            this.lblGirisBaslik.TabIndex = 3;
            this.lblGirisBaslik.Text = "Borsa - Para Ekleme Onayı";
            // 
            // frmParaOnayla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 452);
            this.Controls.Add(this.lblGirisBaslik);
            this.Controls.Add(this.btnAnasayfa);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.lblAra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "frmParaOnayla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BorsaApp v1.0 - Para Onaylama";
            this.Load += new System.EventHandler(this.frmParaOnayla_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmParaOnayla_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Label lblAra;
        private System.Windows.Forms.Button btnAnasayfa;
        private System.Windows.Forms.Label lblGirisBaslik;
    }
}