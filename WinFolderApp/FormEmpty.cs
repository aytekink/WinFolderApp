using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFolderApp
{
    public partial class FormEmpty : Form
    {
        public FormEmpty()
        {
            InitializeComponent();
        }

        private void FormEmpty_Load(object sender, EventArgs e)
        {
            this.Text = "ESC | Boş Klasör Listeleme";
        }

        private void btnSecim_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = txtPath.Text;
            DialogResult drResult = folderBrowserDialog1.ShowDialog();
            if (drResult == System.Windows.Forms.DialogResult.OK)
                txtPath.Text = folderBrowserDialog1.SelectedPath;
        }

        private void btnYukle_Click(object sender, EventArgs e)
        {
            lbDirectory.Items.Clear();
            if (txtPath.Text != "" && Directory.Exists(txtPath.Text))
                LoadDirectory(txtPath.Text);
            else
                MessageBox.Show("Klasörü Seçiniz!");
        }

        public void LoadDirectory(string Dir)
        {
            DirectoryInfo di = new DirectoryInfo(Dir);
            //listBox1.Items.Add(di.FullName);
            LoadSubDirectories(Dir);
        }

        string drive;

        private void btnKontrol_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lbDirectory.Items.Count; i++)
            {
                if (Directory.GetFiles(lbDirectory.Items[i].ToString()).Length == 0)
                    lbSonuc.Items.Add(lbDirectory.Items[i].ToString());

            }
        }

        private void btnDosyaAktar_Click(object sender, EventArgs e)
        {
            if (lbSonuc.Items.Count > 0)
            {
                string path = Application.StartupPath + "\\Sonuc_" + DateTime.Now.ToString().Replace(":", "_") + ".txt";
                System.IO.StreamWriter SaveFile = new System.IO.StreamWriter(path);
                foreach (var item in lbSonuc.Items)
                {
                    SaveFile.WriteLine(item);
                }

                SaveFile.Close();

                MessageBox.Show("Dosyaya Kaydedildi!");
            }
        }

        int id;
        private void LoadSubDirectories(string dir)
        {

            // Get all subdirectories  
            string[] subdirectoryEntries = Directory.GetDirectories(dir);
            // Loop through them to see if they have any other subdirectories  
            foreach (string subdirectory in subdirectoryEntries)
            {
                DirectoryInfo di = new DirectoryInfo(subdirectory);

                string[] bilgi = di.FullName.ToString().Split('\\');

                for (int i = 0; i < bilgi.Length - 1; i++)
                {
                    if (i == 0)
                        drive = bilgi[0].ToString();
                    else
                        drive += "\\" + bilgi[i].ToString();
                }

                id = lbDirectory.Items.IndexOf(drive);

                if (id > -1)
                    lbDirectory.Items.RemoveAt(id);

                if (lbDirectory.Items.Contains(di.FullName) == false)
                    lbDirectory.Items.Add(di.FullName);

                LoadSubDirectories(subdirectory);
            }
        }
    }
}
