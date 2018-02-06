using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CIT265_Lilly_L_A7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnBrowser_Click(object sender, EventArgs e)
        {
            txtBoxDirectory.Text = "";
            txtBoxStats.Text = "";
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtBoxDirectory.Text = fbd.SelectedPath;
                Task<string[]> task = new Task<string[]>(FileFolderCounter);
                task.Start();
                txtBoxStats.Text = "Processing Statistics. Please wait...";
                string[] statistics = new string[3];
                statistics = await task;
                txtBoxStats.Text = "";
                foreach (string line in statistics)
                {
                    txtBoxStats.AppendText(line);
                }
            }
        }

        private async void txtBoxDirectory_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string path = txtBoxDirectory.Text;
                txtBoxStats.Text = "";
                if (Directory.Exists(path))
                {
                    Task<string[]> task = new Task<string[]>(FileFolderCounter);
                    task.Start();
                    txtBoxStats.Text = "Processing Statistics. Please wait...";
                    string[] statistics = new string[3];
                    statistics = await task;
                    txtBoxStats.Text = "";
                    foreach (string line in statistics)
                    {
                        txtBoxStats.AppendText(line);
                    }
                }
            }
        }

        private string[] FileFolderCounter()
        {
            int fileCount = 0;
            int folderCount = 0;
            string path = txtBoxDirectory.Text;
            string[] statistics = new string [3];
            statistics[0] = "";
            statistics[1] = "";
            statistics[2] = "";

            // searches the current directory based on which checkbox option user chooses
            if (chkBoxDirectory.Checked == true)
            {
                try
                {
                    fileCount = Directory.GetFiles(path, "*", SearchOption.AllDirectories).Length;
                    folderCount = Directory.GetDirectories(path, "*", SearchOption.AllDirectories).Length;
                }
                catch (UnauthorizedAccessException e)
                {
                    statistics[0] = "The following path has denied access to the files: " + e.ToString().Substring(54, e.ToString().Substring(57).IndexOf(@"'")+4);
                    return statistics;
                }
            }
            else
            {
                try
                {
                    fileCount = Directory.GetFiles(path, "*", SearchOption.TopDirectoryOnly).Length;
                    folderCount = Directory.GetDirectories(path, "*", SearchOption.TopDirectoryOnly).Length;
                }
                catch(UnauthorizedAccessException e)
                {
                    statistics[0] = "The following path has denied access to the files: " + e.ToString().Substring(54, e.ToString().Substring(57).IndexOf(@"'")+4);
                    return statistics;
                }
            }


            statistics[0] = "Path: " + path + "\n";
            statistics[1] = "Number of Files: " + fileCount + "\n";
            statistics[2] = "Number of Folders: " + folderCount + "\n";

            return statistics;
        }
    }
}
