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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnDegistir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnYukle
            // 
            this.btnYukle.Location = new System.Drawing.Point(535, 5);
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
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Klasör Yolu";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(95, 14);
            this.txtPath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(352, 22);
            this.txtPath.TabIndex = 7;
            // 
            // btnSecim
            // 
            this.btnSecim.Location = new System.Drawing.Point(453, 5);
            this.btnSecim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSecim.Name = "btnSecim";
            this.btnSecim.Size = new System.Drawing.Size(76, 38);
            this.btnSecim.TabIndex = 6;
            this.btnSecim.Text = "Seç";
            this.btnSecim.UseVisualStyleBackColor = true;
            this.btnSecim.Click += new System.EventHandler(this.btnSecim_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(17, 52);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(772, 804);
            this.listBox1.TabIndex = 11;
            // 
            // btnDegistir
            // 
            this.btnDegistir.Location = new System.Drawing.Point(665, 5);
            this.btnDegistir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(124, 38);
            this.btnDegistir.TabIndex = 12;
            this.btnDegistir.Text = "Klasörü Değiştir";
            this.btnDegistir.UseVisualStyleBackColor = true;
            this.btnDegistir.Click += new System.EventHandler(this.btnDegistir_Click);
            // 
            // FormFolder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 866);
            this.Controls.Add(this.btnDegistir);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnYukle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.btnSecim);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormFolder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormFolder";
            this.Load += new System.EventHandler(this.FormFolder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnYukle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnSecim;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnDegistir;
    }
}