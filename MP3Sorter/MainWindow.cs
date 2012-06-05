using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Media;
using System.IO;
using System.Security.Cryptography;
using System.Windows;
using System.Windows.Forms;

namespace MP3Sorter
{
    public partial class MainWindow : Form
    {
        private string[] lstFiles;
        private List<CFile> cFileList;
        private string[] lstDestFiles;
        private static MD5 md5 = MD5.Create();

 
        public MainWindow()
        {
            InitializeComponent();
            fldrDlg.ShowNewFolderButton = false;
            fldrDestDlg.ShowNewFolderButton = true;
            cFileList = new List<CFile>();
            
        }

        private void btnSelSrcDir_Click(object sender, EventArgs e)
        {            
            fldrDlg.ShowDialog();
            lblSrcDirPath.Text = fldrDlg.SelectedPath;
        }

        private void btnSelDestDir_Click(object sender, EventArgs e)
        {
            fldrDestDlg.ShowDialog();
            lblDestDirPath.Text = fldrDestDlg.SelectedPath;
        }

        private void btnListFiles_Click(object sender, EventArgs e)
        {
            lstFiles = Directory.GetFileSystemEntries(lblSrcDirPath.Text, txtBxSrchString.Text, SearchOption.AllDirectories);
            foreach (string sFullFileName in lstFiles)
            {
                CFile currFile = new CFile(sFullFileName);
                cFileList.Add(currFile);
                lstBxSrcFiles.Items.Add(currFile.fileName);
            }
            lblMP3count.Text = lstFiles.Count().ToString();
        }

        private void btnMv2Dst_Click(object sender, EventArgs e)
        {
            if (!bgWrkrFileMover.IsBusy)
            {
                bgWrkrFileMover.RunWorkerAsync();
                btnMv2Dst.Enabled = false;
            }
        }

        private void bgWrkrFileMover_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            if (worker.CancellationPending == true)
            {
                e.Cancel = true;
            }
            else
            {
                // Perform a time consuming operation and report progress.                    
                int count = 0;
                int percentage = 0;
                int total = lstFiles.Count();                
                foreach (string sFileName in lstFiles)
                {
                    count++;
                    percentage = count / total;
                    int idxStart = sFileName.LastIndexOf("\\");
                    string destFileName = sFileName.Substring(idxStart);
                    destFileName = lblDestDirPath.Text + destFileName;
                    if (!File.Exists(destFileName))
                        File.Copy(sFileName, destFileName);
                    
                   // worker.ReportProgress(percentage);
                }
            }            
        }

        private void bgWrkrFileMover_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //lblProgPct.Text = (e.ProgressPercentage.ToString() + "%"); 
        }

        private void bgWrkrFileMover_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Finished Moving Files");
            string[] lstDestFiles = Directory.GetFileSystemEntries(lblDestDirPath.Text, txtBxSrchString.Text, SearchOption.AllDirectories);
            lstBxProcFiles.Items.Clear();
            foreach (string sFullFileName in lstDestFiles)
            {
                int idxStart = sFullFileName.LastIndexOf("\\");
                string sFileName = sFullFileName.Substring(idxStart);
                lstBxProcFiles.Items.Add(sFileName);
            }
            lblDestCount.Text = lstDestFiles.Count().ToString();
            btnMv2Dst.Enabled = true;            
        }

        private void btnLstFileTypes_Click(object sender, EventArgs e)
        {
            string[] lstAllFiles = Directory.GetFileSystemEntries(lblSrcDirPath.Text,"*.*", SearchOption.AllDirectories);
            lstBxProcFiles.Items.Clear();

            foreach (string sFullFileName in lstAllFiles)
            {
                string sFileName;
                int idxStart = sFullFileName.LastIndexOf(".");
                if (idxStart > 0)
                {
                    idxStart++;
                    sFileName = sFullFileName.Substring(idxStart);
                }
                else
                {
                    sFileName = "Unknown";                    
                }
                if (!lstBxProcFiles.Items.Contains(sFileName))
                    lstBxProcFiles.Items.Add(sFileName);
            }
        }

        private void btnFindDup_Click(object sender, EventArgs e)
        {
            ArrayList cksumArr = new ArrayList();
            ArrayList dupeArr = new ArrayList();
            ArrayList origArr = new ArrayList();
            
            foreach (string fName in lstFiles)
            {
                FileStream file = new FileStream(fName, FileMode.Open);
                MD5 md5 = new MD5CryptoServiceProvider();
                byte[] retVal = md5.ComputeHash(file);
                file.Close();
                
                ASCIIEncoding enc = new ASCIIEncoding();
                string cksum = enc.GetString(retVal);
                if (cksumArr.Contains(cksum))
                {
                    ListViewItem row = new ListViewItem();
                    row.SubItems.Add(origArr[cksum.IndexOf(cksum)].ToString());
                    row.SubItems.Add(fName);
                    row.SubItems.Add("MD5");
                    dupeArr.Add(fName);
                }
                else
                {
                    cksumArr.Add(cksum);
                    origArr.Add(fName);
                }
            }
            lstBxProcFiles.Items.Clear();
            lstBxProcFiles.Items.AddRange(cksumArr.ToArray());

        }
    }
}
