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

        private string bufferStr;
        private string bufferTextBoxText;

        private Font defaultFont;
        private Color defaultForeColor;
        private Color defaultBackColor;

        public MainForm()
        {
            InitializeComponent();

            this.Load += MainForm_Load;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.defaultFont = this.textBoxTextFromFile.Font;
            this.defaultForeColor = this.textBoxTextFromFile.ForeColor;
            this.defaultBackColor = this.textBoxTextFromFile.BackColor;
        }

        private void TextBoxTextFromFile_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.bufferTextBoxText = this.textBoxTextFromFile.Text;
        }
        private void textBoxTextFromFile_MouseDown(object sender, MouseEventArgs e)
        {
            this.bufferTextBoxText = this.textBoxTextFromFile.Text;
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
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

                if (this.Text[0] == '*')
                {
                    this.Text = this.Text.Substring(1);
                }
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
                this.bufferStr = this.textBoxTextFromFile.SelectedText;
                this.textBoxTextFromFile.SelectedText = "";
            }
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.bufferStr != "")
            {
                this.textBoxTextFromFile.SelectedText = this.bufferStr;
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.bufferStr = this.textBoxTextFromFile.SelectedText;
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBoxTextFromFile.Text = this.bufferTextBoxText;
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FontDialog font = new FontDialog())
            {
                if (font.ShowDialog() == DialogResult.OK)
                {
                    // TODO проверка на семейство шрифта (формат)
                    // при смене шрифта ошибка 
                    // "поддерживаются только шрифты TrueType".

                    this.textBoxTextFromFile.Font = font.Font;
                }

                this.textBoxTextFromFile.DeselectAll();
            }
        }

        private void defaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBoxTextFromFile.Font = this.defaultFont;
            this.textBoxTextFromFile.ForeColor = this.defaultForeColor;
            this.textBoxTextFromFile.BackColor = this.defaultBackColor;
        }

        private void backColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ColorDialog backColor = new ColorDialog())
            {
                if (backColor.ShowDialog() == DialogResult.OK)
                {
                    this.textBoxTextFromFile.BackColor = backColor.Color;
                }

                this.textBoxTextFromFile.DeselectAll();
            }
        }

        private void fontColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ColorDialog foreColor = new ColorDialog())
            {
                if (foreColor.ShowDialog() == DialogResult.OK)
                {
                    this.textBoxTextFromFile.ForeColor = foreColor.Color;
                }

                this.textBoxTextFromFile.DeselectAll();
            }
        }

        
    }
}
