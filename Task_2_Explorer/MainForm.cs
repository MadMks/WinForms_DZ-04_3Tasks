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

namespace Task_2_Explorer
{
    public partial class MainForm : Form
    {
        private string currentPath;
        private List<string> jumpList;

        public MainForm()
        {
            InitializeComponent();

            currentPath = null;
            jumpList = new List<string>();

            this.Load += MainForm_Load;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.AddNamesOfAvailableDrives();

            //this.textBoxAdressLine.Text = Directory.GetDirectoryRoot("/");
            this.textBoxAdressLine.Text = "";
        }

        private void AddNamesOfAvailableDrives()
        {
            foreach (DriveInfo item in DriveInfo.GetDrives())
            {
                if (item.IsReady == true)
                {
                    this.listBoxOfDisks.Items.Add(item);
                }
            }

            // Запомним текущую позицию.
            //this.jumpList.Add("\\");
        }

        private void listBoxOfDisks_DoubleClick(object sender, EventArgs e)
        {

            if (this.listBoxOfDisks.SelectedIndex > -1)
            {
                this.textBoxAdressLine.Text = this.listBoxOfDisks.SelectedItem.ToString();

                this.listBoxOfDisks.Items.Clear();
                this.listBoxFolderContents.Items.Clear();


                this.listBoxOfDisks.Items.AddRange(
                    Directory.GetDirectories(this.currentPath));

                foreach (string item in Directory.EnumerateFileSystemEntries(this.currentPath))
                {
                    //this.listBoxFolderContents.Items.Add(item);
                    this.listBoxFolderContents.Items.Add(Path.GetFileName(item));
                }


                if (this.IsTheretheFollowingEntry() == true)
                {
                    this.DeleteTheFollowUpEntryes();
                }
                // Запомним текущую позицию.
                this.jumpList.Add(this.currentPath);
            }
        }

        private void DeleteTheFollowUpEntryes()
        {
            this.jumpList.RemoveRange((this.jumpList.IndexOf(this.currentPath) + 1), this.jumpList.Count);
        }

        //private void DeleteTheFollowingEntry()
        //{
        //    this.jumpList.RemoveAt(this.jumpList.IndexOf(this.currentPath) + 1);
        //}

        private bool IsTheretheFollowingEntry()
        {
            if ((this.jumpList.IndexOf(this.currentPath) + 1) > 0)
            {
                return true;
            }

            return false;
        }

        private void textBoxAdressLine_TextChanged(object sender, EventArgs e)
        {
            this.currentPath = this.textBoxAdressLine.Text;
        }

        private void BackToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (this.textBoxAdressLine.Text != "")
            {
                foreach (string item in Directory.GetLogicalDrives())
                {
                    if (this.currentPath == item)
                    {
                        this.textBoxAdressLine.Text = "";

                        this.listBoxOfDisks.Items.Clear();
                        this.listBoxFolderContents.Items.Clear();

                        //this.jumpList.Clear();

                        AddNamesOfAvailableDrives();
                        return;
                    }
                }


                this.textBoxAdressLine.Text = this.jumpList[this.jumpList.IndexOf(this.currentPath) - 1];

                this.GoToFolder();
            }

            
        }


        private void GoToFolder()
        {
            this.listBoxOfDisks.Items.Clear();
            this.listBoxFolderContents.Items.Clear();


            this.listBoxOfDisks.Items.AddRange(
                Directory.GetDirectories(this.currentPath));
        }

        private void forwardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((this.jumpList.IndexOf(this.currentPath) + 1) < this.jumpList.Count)
            {
                this.textBoxAdressLine.Text = this.jumpList[this.jumpList.IndexOf(this.currentPath) + 1];

                this.GoToFolder();
            }
        }



    }
}
