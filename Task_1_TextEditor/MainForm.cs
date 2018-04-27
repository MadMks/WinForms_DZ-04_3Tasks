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

namespace Task_1_TextEditor
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Путь открытого файла.
        /// </summary>
        private string openFilePath;

        private DialogResult dialogResult;

        private string tempStr;

        public MainForm()
        {
            InitializeComponent();

            this.Load += MainForm_Load;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO если открыт документ не сохраненный
            // то спросить "сохранить ли документ перед выходом".
            //if (this.Text[0] == '*')
            //{
            //    MessageBox.Show("Сохранить изменения в файле "
            //        + this.openFilePath + "?", "Сохранить файл",
            //        MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            //}

            this.dialogResult = this.AskWhetherToSaveTheChanges();

            if (dialogResult == DialogResult.Yes)
            {
                this.saveToolStripMenuItem_Click(sender, e);

                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                this.Close();
            }

            
        }

        private DialogResult AskWhetherToSaveTheChanges()
        {
            if (this.Text[0] == '*')
            {
                dialogResult = MessageBox.Show("Сохранить изменения в файле "
                    + this.openFilePath + "?", "Сохранить файл",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            }

            return dialogResult;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Если открыт документ не сохраненный
            // то спросить "сохранить ли документ перед открытием другого".
            //if (this.Text[0] == '*')
            //{
            //    //DialogResult dialogResult;

            //    dialogResult = MessageBox.Show("Сохранить изменения в файле "
            //        + this.openFilePath + "?", "Сохранить файл",
            //        MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            //    if (dialogResult == DialogResult.Yes)
            //    {
            //        this.saveToolStripMenuItem_Click(sender, e);

            //        this.CreateNewFile();
            //    }
            //    else if (dialogResult == DialogResult.No)
            //    {
            //        this.CreateNewFile();
            //    }

            //}

            this.dialogResult = this.AskWhetherToSaveTheChanges();

            if (dialogResult == DialogResult.Yes)
            {
                this.saveToolStripMenuItem_Click(sender, e);
            }
            else if (dialogResult == DialogResult.Cancel)
            {
                return;
            }

            this.CreateNewFile();
        }

        private void CreateNewFile()
        {
            // Очистить поле 
            this.textBoxTextFromFile.Text = "";

            // Изменить название тайтла 
            this.Text = "Новый файл";
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Если открыт документ не сохраненный
            // то спросить "сохранить ли документ перед открытием другого".
            this.dialogResult = this.AskWhetherToSaveTheChanges();

            if (dialogResult == DialogResult.Yes)
            {
                this.saveToolStripMenuItem_Click(sender, e);
            }
            else if (dialogResult == DialogResult.Cancel)
            {
                return;
            }

            using (OpenFileDialog open = new OpenFileDialog())
            {
                open.Filter = "Text Files(*.txt)|*.txt||";
                open.FilterIndex = 0;
                open.InitialDirectory = Directory.GetCurrentDirectory();

                if (open.ShowDialog() == DialogResult.OK)
                {
                    this.Text = open.FileName;

                    this.openFilePath = open.FileName;

                    using (StreamReader reader = File.OpenText(open.FileName))
                    {
                        this.textBoxTextFromFile.Text = reader.ReadToEnd();
                    }

                    if (this.Text[0] == '*')
                    {
                        this.Text = this.Text.Substring(1);
                    }
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.Text == "Новый файл" || this.Text == "*Новый файл")
            {
                this.saveAsToolStripMenuItem_Click(sender, e);
            }
            else
            {
                using (StreamWriter writer = new StreamWriter(this.openFilePath))
                {
                    writer.Write(this.textBoxTextFromFile.Text);
                }

                this.Text = this.Text.Substring(1);
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog save = new SaveFileDialog())
            {
                save.Filter = "Text Files(*.txt)|*.txt||";
                save.FilterIndex = 0;

                if (save.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter writer = new StreamWriter(save.FileName))
                    {
                        writer.Write(this.textBoxTextFromFile.Text);
                    }

                    this.Text = save.FileName;

                    this.openFilePath = save.FileName;
                }
            }
        }


        private void textBoxTextFromFile_TextChanged(object sender, EventArgs e)
        {
            if (this.Text == "Текстовый редактор")
            {
                this.Text = "*Новый файл";

            }
            else if (this.Text[0] != '*')
            {
                this.Text = "*" + this.Text;
            }
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBoxTextFromFile.SelectAll();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.textBoxTextFromFile.SelectedText != "")
            {
                //MessageBox.Show(this.textBoxTextFromFile.SelectedText);
                this.tempStr = this.textBoxTextFromFile.SelectedText;
                this.textBoxTextFromFile.SelectedText = "";
            }
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.tempStr != "")
            {
                //this.textBoxTextFromFile.Text.Insert(
                //    this.textBoxTextFromFile., this.tempStr);
                this.textBoxTextFromFile.SelectedText = this.tempStr;
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.tempStr = this.textBoxTextFromFile.SelectedText;
        }
    }
}
