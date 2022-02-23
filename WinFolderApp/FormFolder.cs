using System;
using System.IO;
using System.Windows.Forms;

namespace WinFolderApp
{
    public partial class FormFolder : Form
    {
        public FormFolder()
        {
            InitializeComponent();
        }

        private void btnSecim_Click(object sender, EventArgs e)
        {
            folderBrowserDialogKlasorAdiDegistir.SelectedPath = txtPath.Text;
            DialogResult drResult = folderBrowserDialogKlasorAdiDegistir.ShowDialog();
            if (drResult == System.Windows.Forms.DialogResult.OK)
                txtPath.Text = folderBrowserDialogKlasorAdiDegistir.SelectedPath;
        }

        public void LoadDirectoryKlasorAdiDegistir(string Dir)
        {
            DirectoryInfo di = new DirectoryInfo(Dir);
            LoadSubDirectoriesKlasorAdiDegistir(Dir);
        }

        public void LoadDirectoryDosyaKopyalama(string Dir)
        {
            DirectoryInfo di = new DirectoryInfo(Dir);
            LoadSubDirectoriesDosyaKopyalama(Dir);
        }

        string drive, source, destination;
        int id;
        private void LoadSubDirectoriesKlasorAdiDegistir(string dir)
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

                id = listBoxKlasorAdiDegistir.Items.IndexOf(drive);

                if (id > -1)
                    listBoxKlasorAdiDegistir.Items.RemoveAt(id);

                if (listBoxKlasorAdiDegistir.Items.Contains(di.FullName) == false)
                    listBoxKlasorAdiDegistir.Items.Add(di.FullName);

                LoadSubDirectoriesKlasorAdiDegistir(subdirectory);
            }
        }

        private void LoadSubDirectoriesDosyaKopyalama(string dir)
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

                id = listBoxDosyaKopyalama.Items.IndexOf(drive);

                if (id > -1)
                    listBoxDosyaKopyalama.Items.RemoveAt(id);

                if (listBoxDosyaKopyalama.Items.Contains(di.FullName) == false)
                    listBoxDosyaKopyalama.Items.Add(di.FullName);

                LoadSubDirectoriesDosyaKopyalama(subdirectory);
            }
        }

        private void btnYukle_Click(object sender, EventArgs e)
        {
            listBoxKlasorAdiDegistir.Items.Clear();
            if (txtPath.Text != "" && Directory.Exists(txtPath.Text))
                LoadDirectoryKlasorAdiDegistir(txtPath.Text);
            else
                MessageBox.Show("Klasörü Seçiniz!");
        }

        private void btnDosyaSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.RestoreDirectory = true;
            file.CheckFileExists = true;
            file.Title = "Kopyalanacak Dosyayı Seçiniz..";
            if (file.ShowDialog() == DialogResult.OK)
            {
                txtDosyaAdi.Text = file.FileName;
            }
        }

        private void btnKlasorSec_Click(object sender, EventArgs e)
        {
            listBoxDosyaKopyalama.Items.Clear();
            folderBrowserDialogHedefKlasor.SelectedPath = txtHedefKlasor.Text;
            DialogResult drResult = folderBrowserDialogHedefKlasor.ShowDialog();
            if (drResult == System.Windows.Forms.DialogResult.OK)
            {
                txtHedefKlasor.Text = folderBrowserDialogHedefKlasor.SelectedPath;
                LoadDirectoryDosyaKopyalama(txtHedefKlasor.Text);
            }
        }

        private void btnDosyaKopyala_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            string targetFolder = "";
            string sourcePath = txtDosyaAdi.Text;
            try
            {
                for (int i = 0; i < listBoxDosyaKopyalama.Items.Count; i++)
                {
                    targetFolder = listBoxDosyaKopyalama.Items[i].ToString();
                    string sourceFile = System.IO.Path.GetFileName(sourcePath);
                    string targetPath = targetFolder + "\\" + sourceFile;
                    System.IO.File.Copy(sourcePath, targetPath, true);                    
                }
                MessageBox.Show("Kopyalama İşlemi Tamamlandı");
            }
            catch { MessageBox.Show("Dosya Kopyalama İşleminde Hata Var"); }
            Cursor.Current = Cursors.Default;
        }

        private void FormFolder_Load(object sender, EventArgs e)
        {
            this.Text = "ESC | Klasör İşlemleri";
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            for (int k = 0; k < listBoxKlasorAdiDegistir.Items.Count; k++)
            {
                source = listBoxKlasorAdiDegistir.Items[k].ToString();

                string[] bilgi = listBoxKlasorAdiDegistir.Items[k].ToString().Split('\\');

                //Directory Name
                for (int i = 1; i < bilgi.Length; i++)
                {
                    if (i == 1)
                        drive = bilgi[i].ToString();
                    else
                        drive += "-" + bilgi[i].ToString();
                }

                //Destination
                for (int j = 0; j < bilgi.Length - 1; j++)
                {
                    if (j == 0)
                        destination = bilgi[j].ToString();
                    else
                        destination += "\\" + bilgi[j].ToString();
                }

                destination += "\\" + drive;

                Directory.Move(source, destination);
            }
            MessageBox.Show("Bitti");
        }
    }
}
