namespace WinFolderApp
{
    partial class FormEmpty
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
            this.lbDirectory = new System.Windows.Forms.ListBox();
            this.btnYukle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnSecim = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnKontrol = new System.Windows.Forms.Button();
            this.lbSonuc = new System.Windows.Forms.ListBox();
            this.btnDosyaAktar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbDirectory
            // 
            this.lbDirectory.FormattingEnabled = true;
            this.lbDirectory.ItemHeight = 16;
            this.lbDirectory.Location = new System.Drawing.Point(14, 88);
            this.lbDirectory.Margin = new System.Windows.Forms.Padding(4);
            this.lbDirectory.Name = "lbDirectory";
            this.lbDirectory.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbDirectory.Size = new System.Drawing.Size(987, 772);
            this.lbDirectory.TabIndex = 17;
            // 
            // btnYukle
            // 
            this.btnYukle.Location = new System.Drawing.Point(533, 11);
            this.btnYukle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnYukle.Name = "btnYukle";
            this.btnYukle.Size = new System.Drawing.Size(124, 38);
            this.btnYukle.TabIndex = 16;
            this.btnYukle.Text = "Klasörü Yükle";
            this.btnYukle.UseVisualStyleBackColor = true;
            this.btnYukle.Click += new System.EventHandler(this.btnYukle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Klasör Yolu";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(93, 20);
            this.txtPath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(352, 22);
            this.txtPath.TabIndex = 14;
            // 
            // btnSecim
            // 
            this.btnSecim.Location = new System.Drawing.Point(451, 11);
            this.btnSecim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSecim.Name = "btnSecim";
            this.btnSecim.Size = new System.Drawing.Size(76, 38);
            this.btnSecim.TabIndex = 13;
            this.btnSecim.Text = "Seç";
            this.btnSecim.UseVisualStyleBackColor = true;
            this.btnSecim.Click += new System.EventHandler(this.btnSecim_Click);
            // 
            // btnKontrol
            // 
            this.btnKontrol.Location = new System.Drawing.Point(663, 11);
            this.btnKontrol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKontrol.Name = "btnKontrol";
            this.btnKontrol.Size = new System.Drawing.Size(159, 38);
            this.btnKontrol.TabIndex = 18;
            this.btnKontrol.Text = "Boş Klasör Kontrolü";
            this.btnKontrol.UseVisualStyleBackColor = true;
            this.btnKontrol.Click += new System.EventHandler(this.btnKontrol_Click);
            // 
            // lbSonuc
            // 
            this.lbSonuc.FormattingEnabled = true;
            this.lbSonuc.ItemHeight = 16;
            this.lbSonuc.Location = new System.Drawing.Point(1009, 88);
            this.lbSonuc.Margin = new System.Windows.Forms.Padding(4);
            this.lbSonuc.Name = "lbSonuc";
            this.lbSonuc.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbSonuc.Size = new System.Drawing.Size(864, 772);
            this.lbSonuc.TabIndex = 19;
            // 
            // btnDosyaAktar
            // 
            this.btnDosyaAktar.Location = new System.Drawing.Point(828, 11);
            this.btnDosyaAktar.Name = "btnDosyaAktar";
            this.btnDosyaAktar.Size = new System.Drawing.Size(173, 38);
            this.btnDosyaAktar.TabIndex = 20;
            this.btnDosyaAktar.Text = "Dosyaya Aktar";
            this.btnDosyaAktar.UseVisualStyleBackColor = true;
            this.btnDosyaAktar.Click += new System.EventHandler(this.btnDosyaAktar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(1008, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Boş Klasörler";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(12, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Tüm Klasörler";
            // 
            // FormEmpty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1886, 873);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDosyaAktar);
            this.Controls.Add(this.lbSonuc);
            this.Controls.Add(this.lbDirectory);
            this.Controls.Add(this.btnYukle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.btnSecim);
            this.Controls.Add(this.btnKontrol);
            this.Name = "FormEmpty";
            this.Text = "FormEmpty";
            this.Load += new System.EventHandler(this.FormEmpty_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbDirectory;
        private System.Windows.Forms.Button btnYukle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnSecim;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnKontrol;
        private System.Windows.Forms.ListBox lbSonuc;
        private System.Windows.Forms.Button btnDosyaAktar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}