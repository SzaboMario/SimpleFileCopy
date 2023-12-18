using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleFileCopy
{
    public partial class Form1 : Form
    {
        string sourceFolder, targetFolder;
        static int timeInterval = 5;
        bool start = false;
        static StreamWriter writer;
        string reportName = "";
        static int fileCounter = 0;
        public Form1()
        {
            InitializeComponent();
            timeIntervalText.Text = timeInterval.ToString();           
        }
        

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(timeIntervalText.Text)==0)
                {
                    timeInterval = 5;
                    timeIntervalText.Text = timeInterval.ToString();
                }
                if (System.Text.RegularExpressions.Regex.IsMatch(timeIntervalText.Text, "[^0-9]"))
                {
                    MessageBox.Show("Please enter only numbers.");
                    timeIntervalText.Text = timeIntervalText.Text.Remove(timeIntervalText.Text.Length - 1);
                }
                else if (timeIntervalText.Text.Length>0)
                {
                    timeInterval = Convert.ToInt32(timeIntervalText.Text);
                }
                else
                {
                    timeInterval = 5;
                    timeIntervalText.Text = timeInterval.ToString();
                }
            }
            catch (Exception)
            {
                    MessageBox.Show("Not correct format!");
                    timeInterval = 5;
                    timeIntervalText.Text = timeInterval.ToString();                          
            }                  
        }

        private void targetOpenBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                targetFolder = dlg.SelectedPath;
                targetFolderText.Text = targetFolder;
            }
        }

        

        private void sourceOpenBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                sourceFolder = dlg.SelectedPath;
                sourceFolderText.Text = sourceFolder;
            }
        }



        private void Stop()
        {         
            start = false;
            if (startBtn.InvokeRequired)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    startBtn.Text = "Start";
                    startBtn.ForeColor = Color.Green;
                    runIndicatorPic.BackColor = Color.Tomato;
                    timeIntervalText.Enabled = true;
                    sourceFolderText.Enabled = true;
                    targetFolderText.Enabled = true;
                });
            }
            if (fileCounter>0)
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;
                result = MessageBox.Show("Finished!\nReport completed during the program!\nDo you want to open it?", "Result", buttons);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    var p = new Process();
                    p.StartInfo.FileName = reportName;  // just for example, you can use yours.
                    p.Start();
                }
            }
           
        }
        private void startBtn_Click(object sender, EventArgs e)
        {
            if (sourceFolderText.Text.Length>0&&targetFolderText.Text.Length>0)
            {
                if (start == false)
                {
                    reportName = $"report_{DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss")}.txt";
                    writer = new StreamWriter(reportName);
                    start = true;
                    Thread t1 = new Thread(new ThreadStart(th_1));
                    t1.IsBackground = true;
                    t1.Start();
                    startBtn.Text = "Stop";
                    startBtn.ForeColor = Color.Red;
                    runIndicatorPic.BackColor = Color.Green;
                    timeIntervalText.Enabled = false;
                    sourceFolderText.Enabled = false;
                    targetFolderText.Enabled = false;
                }
                else
                {
                    timeIntervalText.Enabled = true;
                    sourceFolderText.Enabled = true;
                    targetFolderText.Enabled = true;
                    string message = "Do you want to stop the process?";
                    string caption = "stop";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result;
                    result = MessageBox.Show(message, caption, buttons);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        start = false;
                        startBtn.Text = "Start";
                        startBtn.ForeColor = Color.Green;
                        runIndicatorPic.BackColor = Color.Tomato;
                    }
                }
            }
            else
            {
                MessageBox.Show("Empty path! Please fill it.");
            }                    
        }

        private void th_1()
        {
            while (start)
            {
                try
                {
                    string[] files = Directory.GetFiles(sourceFolder);
                    DirectoryCopy(sourceFolder, targetFolder, true);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }                           
                Stop();              
            }
            writer.Flush();
            writer.Close();
        }

        private void sourceFolderText_TextChanged(object sender, EventArgs e)
        {
             sourceFolder= sourceFolderText.Text;
        }

        private void targetFolderText_TextChanged(object sender, EventArgs e)
        {
            targetFolder = targetFolderText.Text;
        }

        private static void DirectoryCopy(string sourceDirName, string destDirName,
                                      bool copySubDirs)
        {
            // Get the subdirectories for the specified directory.
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);

            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Source directory does not exist or could not be found: "
                    + sourceDirName);
            }

            DirectoryInfo[] dirs = dir.GetDirectories();
            // If the destination directory doesn't exist, create it.
            if (!Directory.Exists(destDirName))
            {
                Directory.CreateDirectory(destDirName);
            }

            // Get the files in the directory and copy them to the new location.
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {            
                try
                {
                    string temppath = Path.Combine(destDirName, file.Name);
                    file.CopyTo(temppath, false);
                    fileCounter++;
                    writer.WriteLine(fileCounter+$". Time: {DateTime.Now.ToString()} Copy OK: "+ temppath);
                }
                catch (Exception ex)
                {
                   // MessageBox.Show(ex.Message);
                }               
                Thread.Sleep(timeInterval);
            }

            // If copying subdirectories, copy them and their contents to new location.
            if (copySubDirs)
            {
                foreach (DirectoryInfo subdir in dirs)
                {
                    //string temppath = Path.Combine(destDirName, subdir.Name);
                    DirectoryCopy(subdir.FullName, destDirName, copySubDirs);                  
                }
            }
        }
    }
}
