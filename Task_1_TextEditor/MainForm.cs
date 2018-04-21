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
        public MainForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO файл сохранить!?
            // файл не сохранен.

            this.Close();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO сохранить изменения в старом файле.

            // TODO очистить поле 
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO если открыт документ не сохраненный
            // то спросить "сохранить ли документ перед открытием другого".

            using (OpenFileDialog open = new OpenFileDialog())
            {
                open.Filter = "Text Files(*.txt)|*.txt||";
                open.FilterIndex = 0;
                open.InitialDirectory = Directory.GetCurrentDirectory();

                if (open.ShowDialog() == DialogResult.OK)
                {
                    this.Text = open.FileName;

                    using (StreamReader reader = File.OpenText(open.FileName))
                    {
                        this.textBoxTextFromFile.Text = reader.ReadToEnd();
                    }
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO если открыт документ
            // то сохранить.
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
                }
            }
        }
    }
}
