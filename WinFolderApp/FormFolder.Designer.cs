namespace WinFolderApp
{
    partial class FormFolder
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
            this.btnYukle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnSecim = new System.Windows.Forms.Button();
            this.listBoxKlasorAdiDegistir = new System.Windows.Forms.ListBox();
            this.folderBrowserDialogKlasorAdiDegistir = new System.Windows.Forms.FolderBrowserDialog();
            this.btnDegistir = new System.Windows.Forms.Button();
            this.tabControlForm = new System.Windows.Forms.TabControl();
            this.tabKlasorAdiDegistir = new System.Windows.Forms.TabPage();
            this.tabDosyaKopyalama = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxDosyaKopyalama = new System.Windows.Forms.ListBox();
            this.btnDosyaSec = new System.Windows.Forms.Button();
            this.txtDosyaAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHedefKlasor = new System.Windows.Forms.TextBox();
            this.btnKlasorSec = new System.Windows.Forms.Button();
            this.btnDosyaKopyala = new System.Windows.Forms.Button();
            this.folderBrowserDialogHedefKlasor = new System.Windows.Forms.FolderBrowserDialog();
            this.tabControlForm.SuspendLayout();
            this.tabKlasorAdiDegistir.SuspendLayout();
            this.tabDosyaKopyalama.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnYukle
            // 
            this.btnYukle.Location = new System.Drawing.Point(528, 11);
            this.btnYukle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnYukle.Name = "btnYukle";
            this.btnYukle.Size = new System.Drawing.Size(124, 38);
            this.btnYukle.TabIndex = 10;
            this.btnYukle.Text = "Klasörü Yükle";
            this.btnYukle.UseVisualStyleBackColor = true;
            this.btnYukle.Click += new System.EventHandler(this.btnYukle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Klasör Yolu";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(88, 20);
            this.txtPath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(352, 22);
            this.txtPath.TabIndex = 7;
            // 
            // btnSecim
            // 
            this.btnSecim.Location = new System.Drawing.Point(446, 11);
            this.btnSecim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSecim.Name = "btnSecim";
            this.btnSecim.Size = new System.Drawing.Size(76, 38);
            this.btnSecim.TabIndex = 6;
            this.btnSecim.Text = "Seç";
            this.btnSecim.UseVisualStyleBackColor = true;
            this.btnSecim.Click += new System.EventHandler(this.btnSecim_Click);
            // 
            // listBoxKlasorAdiDegistir
            // 
            this.listBoxKlasorAdiDegistir.FormattingEnabled = true;
            this.listBoxKlasorAdiDegistir.ItemHeight = 16;
            this.listBoxKlasorAdiDegistir.Location = new System.Drawing.Point(9, 55);
            this.listBoxKlasorAdiDegistir.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxKlasorAdiDegistir.Name = "listBoxKlasorAdiDegistir";
            this.listBoxKlasorAdiDegistir.Size = new System.Drawing.Size(773, 740);
            this.listBoxKlasorAdiDegistir.TabIndex = 11;
            // 
            // btnDegistir
            // 
            this.btnDegistir.Location = new System.Drawing.Point(658, 11);
            this.btnDegistir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(124, 38);
            this.btnDegistir.TabIndex = 12;
            this.btnDegistir.Text = "Klasörü Değiştir";
            this.btnDegistir.UseVisualStyleBackColor = true;
            this.btnDegistir.Click += new System.EventHandler(this.btnDegistir_Click);
            // 
            // tabControlForm
            // 
            this.tabControlForm.Controls.Add(this.tabKlasorAdiDegistir);
            this.tabControlForm.Controls.Add(this.tabDosyaKopyalama);
            this.tabControlForm.Location = new System.Drawing.Point(10, 12);
            this.tabControlForm.Name = "tabControlForm";
            this.tabControlForm.SelectedIndex = 0;
            this.tabControlForm.Size = new System.Drawing.Size(802, 834);
            this.tabControlForm.TabIndex = 13;
            // 
            // tabKlasorAdiDegistir
            // 
            this.tabKlasorAdiDegistir.Controls.Add(this.label1);
            this.tabKlasorAdiDegistir.Controls.Add(this.listBoxKlasorAdiDegistir);
            this.tabKlasorAdiDegistir.Controls.Add(this.btnDegistir);
            this.tabKlasorAdiDegistir.Controls.Add(this.btnSecim);
            this.tabKlasorAdiDegistir.Controls.Add(this.txtPath);
            this.tabKlasorAdiDegistir.Controls.Add(this.btnYukle);
            this.tabKlasorAdiDegistir.Location = new System.Drawing.Point(4, 25);
            this.tabKlasorAdiDegistir.Name = "tabKlasorAdiDegistir";
            this.tabKlasorAdiDegistir.Padding = new System.Windows.Forms.Padding(3);
            this.tabKlasorAdiDegistir.Size = new System.Drawing.Size(794, 805);
            this.tabKlasorAdiDegistir.TabIndex = 0;
            this.tabKlasorAdiDegistir.Text = "Klasör Adı Değiştirme";
            this.tabKlasorAdiDegistir.UseVisualStyleBackColor = true;
            // 
            // tabDosyaKopyalama
            // 
            this.tabDosyaKopyalama.Controls.Add(this.btnDosyaKopyala);
            this.tabDosyaKopyalama.Controls.Add(this.btnKlasorSec);
            this.tabDosyaKopyalama.Controls.Add(this.label3);
            this.tabDosyaKopyalama.Controls.Add(this.txtHedefKlasor);
            this.tabDosyaKopyalama.Controls.Add(this.label2);
            this.tabDosyaKopyalama.Controls.Add(this.listBoxDosyaKopyalama);
            this.tabDosyaKopyalama.Controls.Add(this.btnDosyaSec);
            this.tabDosyaKopyalama.Controls.Add(this.txtDosyaAdi);
            this.tabDosyaKopyalama.Location = new System.Drawing.Point(4, 25);
            this.tabDosyaKopyalama.Name = "tabDosyaKopyalama";
            this.tabDosyaKopyalama.Padding = new System.Windows.Forms.Padding(3);
            this.tabDosyaKopyalama.Size = new System.Drawing.Size(794, 805);
            this.tabDosyaKopyalama.TabIndex = 1;
            this.tabDosyaKopyalama.Text = "Dosya Kopyalama";
            this.tabDosyaKopyalama.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Kopyalanacak Dosya";
            // 
            // listBoxDosyaKopyalama
            // 
            this.listBoxDosyaKopyalama.FormattingEnabled = true;
            this.listBoxDosyaKopyalama.ItemHeight = 16;
            this.listBoxDosyaKopyalama.Location = new System.Drawing.Point(12, 95);
            this.listBoxDosyaKopyalama.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxDosyaKopyalama.Name = "listBoxDosyaKopyalama";
            this.listBoxDosyaKopyalama.Size = new System.Drawing.Size(773, 692);
            this.listBoxDosyaKopyalama.TabIndex = 15;
            // 
            // btnDosyaSec
            // 
            this.btnDosyaSec.Location = new System.Drawing.Point(516, 14);
            this.btnDosyaSec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDosyaSec.Name = "btnDosyaSec";
            this.btnDosyaSec.Size = new System.Drawing.Size(76, 29);
            this.btnDosyaSec.TabIndex = 12;
            this.btnDosyaSec.Text = "Seç";
            this.btnDosyaSec.UseVisualStyleBackColor = true;
            this.btnDosyaSec.Click += new System.EventHandler(this.btnDosyaSec_Click);
            // 
            // txtDosyaAdi
            // 
            this.txtDosyaAdi.Location = new System.Drawing.Point(158, 18);
            this.txtDosyaAdi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDosyaAdi.Name = "txtDosyaAdi";
            this.txtDosyaAdi.ReadOnly = true;
            this.txtDosyaAdi.Size = new System.Drawing.Size(352, 22);
            this.txtDosyaAdi.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Hedef Klasör";
            // 
            // txtHedefKlasor
            // 
            this.txtHedefKlasor.Location = new System.Drawing.Point(158, 59);
            this.txtHedefKlasor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHedefKlasor.Name = "txtHedefKlasor";
            this.txtHedefKlasor.ReadOnly = true;
            this.txtHedefKlasor.Size = new System.Drawing.Size(352, 22);
            this.txtHedefKlasor.TabIndex = 16;
            // 
            // btnKlasorSec
            // 
            this.btnKlasorSec.Location = new System.Drawing.Point(516, 56);
            this.btnKlasorSec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKlasorSec.Name = "btnKlasorSec";
            this.btnKlasorSec.Size = new System.Drawing.Size(76, 29);
            this.btnKlasorSec.TabIndex = 18;
            this.btnKlasorSec.Text = "Seç";
            this.btnKlasorSec.UseVisualStyleBackColor = true;
            this.btnKlasorSec.Click += new System.EventHandler(this.btnKlasorSec_Click);
            // 
            // btnDosyaKopyala
            // 
            this.btnDosyaKopyala.BackColor = System.Drawing.Color.LightBlue;
            this.btnDosyaKopyala.Location = new System.Drawing.Point(598, 15);
            this.btnDosyaKopyala.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDosyaKopyala.Name = "btnDosyaKopyala";
            this.btnDosyaKopyala.Size = new System.Drawing.Size(187, 70);
            this.btnDosyaKopyala.TabIndex = 19;
            this.btnDosyaKopyala.Text = "Dosyaları Kopyala";
            this.btnDosyaKopyala.UseVisualStyleBackColor = false;
            this.btnDosyaKopyala.Click += new System.EventHandler(this.btnDosyaKopyala_Click);
            // 
            // FormFolder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(822, 855);
            this.Controls.Add(this.tabControlForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormFolder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormFolder";
            this.Load += new System.EventHandler(this.FormFolder_Load);
            this.tabControlForm.ResumeLayout(false);
            this.tabKlasorAdiDegistir.ResumeLayout(false);
            this.tabKlasorAdiDegistir.PerformLayout();
            this.tabDosyaKopyalama.ResumeLayout(false);
            this.tabDosyaKopyalama.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnYukle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnSecim;
        private System.Windows.Forms.ListBox listBoxKlasorAdiDegistir;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogKlasorAdiDegistir;
        private System.Windows.Forms.Button btnDegistir;
        private System.Windows.Forms.TabControl tabControlForm;
        private System.Windows.Forms.TabPage tabKlasorAdiDegistir;
        private System.Windows.Forms.TabPage tabDosyaKopyalama;
        private System.Windows.Forms.Button btnKlasorSec;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHedefKlasor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxDosyaKopyalama;
        private System.Windows.Forms.Button btnDosyaSec;
        private System.Windows.Forms.TextBox txtDosyaAdi;
        private System.Windows.Forms.Button btnDosyaKopyala;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogHedefKlasor;
    }
}