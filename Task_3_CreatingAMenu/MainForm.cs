using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_3_CreatingAMenu
{
    public partial class MainForm : Form
    {
        private MenuStrip menu;
        private ToolStripMenuItem menuItem;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            menu = new MenuStrip();
            //menuItem = new ToolStripMenuItem();
            this.Controls.Add(menu);
        }

        private void buttonAddTopLevelMenu_Click(object sender, EventArgs e)
        {
            if (this.textBoxTopLevelMenu.Text != "")
            {
                menuItem = (ToolStripMenuItem)menu.Items.Add(this.textBoxTopLevelMenu.Text);
            }
        }

        private void buttonAddSubItem_Click(object sender, EventArgs e)
        {
            if (menuItem != null)
            {
                if (this.textBoxSubItem.Text != "")
                {
                    menuItem.DropDownItems.Add(this.textBoxSubItem.Text);
                }
            }
        }
    }
}
