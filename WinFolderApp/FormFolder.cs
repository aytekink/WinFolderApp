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
            folderBrowserDialog1.SelectedPath = txtPath.Text;
            DialogResult drResult = folderBrowserDialog1.ShowDialog();
            if (drResult == System.Windows.Forms.DialogResult.OK)
                txtPath.Text = folderBrowserDialog1.SelectedPath;
        }

        public void LoadDirectory(string Dir)
        {
            DirectoryInfo di = new DirectoryInfo(Dir);
            //listBox1.Items.Add(di.FullName);
            LoadSubDirectories(Dir);
        }

        string drive, source, destination;
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

                id = listBox1.Items.IndexOf(drive);

                if (id > -1)
                    listBox1.Items.RemoveAt(id);

                if (listBox1.Items.Contains(di.FullName) == false)
                    listBox1.Items.Add(di.FullName);

                LoadSubDirectories(subdirectory);
            }
        }

        private void btnYukle_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (txtPath.Text != "" && Directory.Exists(txtPath.Text))
                LoadDirectory(txtPath.Text);
            else
                MessageBox.Show("Select Directory!!");
        }

        private void FormFolder_Load(object sender, EventArgs e)
        {
            this.Text = "ESC | Klasör Adı Değiştirme";
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            for (int k = 0; k < listBox1.Items.Count; k++)
            {
                source = listBox1.Items[k].ToString();

                string[] bilgi = listBox1.Items[k].ToString().Split('\\');

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
