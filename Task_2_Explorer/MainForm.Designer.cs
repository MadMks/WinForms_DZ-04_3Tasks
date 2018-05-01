namespace Task_2_Explorer
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.listBoxOfDisks = new System.Windows.Forms.ListBox();
            this.listBoxFolderContents = new System.Windows.Forms.ListBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.navToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BackMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forwardMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.toRootDirMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonBack = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonForward = new System.Windows.Forms.ToolStripButton();
            this.textBoxAdressLine = new System.Windows.Forms.TextBox();
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxOfDisks
            // 
            this.listBoxOfDisks.FormattingEnabled = true;
            this.listBoxOfDisks.Location = new System.Drawing.Point(11, 79);
            this.listBoxOfDisks.Name = "listBoxOfDisks";
            this.listBoxOfDisks.Size = new System.Drawing.Size(228, 264);
            this.listBoxOfDisks.TabIndex = 0;
            this.listBoxOfDisks.DoubleClick += new System.EventHandler(this.listBoxOfDisks_DoubleClick);
            // 
            // listBoxFolderContents
            // 
            this.listBoxFolderContents.FormattingEnabled = true;
            this.listBoxFolderContents.Location = new System.Drawing.Point(245, 79);
            this.listBoxFolderContents.Name = "listBoxFolderContents";
            this.listBoxFolderContents.Size = new System.Drawing.Size(257, 264);
            this.listBoxFolderContents.TabIndex = 1;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.navToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(515, 24);
            this.menuStrip.TabIndex = 3;
            this.menuStrip.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.menuToolStripMenuItem.Text = "Меню";
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(107, 22);
            this.exitMenuItem.Text = "Выход";
            // 
            // navToolStripMenuItem
            // 
            this.navToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BackMenuItem,
            this.forwardMenuItem,
            this.toolStripMenuItem1,
            this.toRootDirMenuItem});
            this.navToolStripMenuItem.Name = "navToolStripMenuItem";
            this.navToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.navToolStripMenuItem.Text = "Навигация";
            // 
            // BackMenuItem
            // 
            this.BackMenuItem.Name = "BackMenuItem";
            this.BackMenuItem.Size = new System.Drawing.Size(221, 22);
            this.BackMenuItem.Text = "Назад";
            this.BackMenuItem.Click += new System.EventHandler(this.BackToolStripMenuItem_Click);
            // 
            // forwardMenuItem
            // 
            this.forwardMenuItem.Name = "forwardMenuItem";
            this.forwardMenuItem.Size = new System.Drawing.Size(221, 22);
            this.forwardMenuItem.Text = "Вперед";
            this.forwardMenuItem.Click += new System.EventHandler(this.forwardToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(218, 6);
            // 
            // toRootDirMenuItem
            // 
            this.toRootDirMenuItem.Name = "toRootDirMenuItem";
            this.toRootDirMenuItem.Size = new System.Drawing.Size(221, 22);
            this.toRootDirMenuItem.Text = "Перейти в корневой каталог";
            this.toRootDirMenuItem.Click += new System.EventHandler(this.toRootDirToolStripMenuItem_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonBack,
            this.toolStripButtonForward});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(515, 25);
            this.toolStrip.TabIndex = 4;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolStripButtonBack
            // 
            this.toolStripButtonBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonBack.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonBack.Image")));
            this.toolStripButtonBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonBack.Name = "toolStripButtonBack";
            this.toolStripButtonBack.Size = new System.Drawing.Size(42, 22);
            this.toolStripButtonBack.Text = "Назад";
            this.toolStripButtonBack.Click += new System.EventHandler(this.BackToolStripMenuItem_Click);
            // 
            // toolStripButtonForward
            // 
            this.toolStripButtonForward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonForward.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonForward.Image")));
            this.toolStripButtonForward.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonForward.Name = "toolStripButtonForward";
            this.toolStripButtonForward.Size = new System.Drawing.Size(48, 22);
            this.toolStripButtonForward.Text = "Вперед";
            this.toolStripButtonForward.Click += new System.EventHandler(this.forwardToolStripMenuItem_Click);
            // 
            // textBoxAdressLine
            // 
            this.textBoxAdressLine.Location = new System.Drawing.Point(12, 52);
            this.textBoxAdressLine.Name = "textBoxAdressLine";
            this.textBoxAdressLine.Size = new System.Drawing.Size(490, 21);
            this.textBoxAdressLine.TabIndex = 2;
            this.textBoxAdressLine.TextChanged += new System.EventHandler(this.textBoxAdressLine_TextChanged);
            this.textBoxAdressLine.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAdressLine_KeyPress);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 354);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.textBoxAdressLine);
            this.Controls.Add(this.listBoxFolderContents);
            this.Controls.Add(this.listBoxOfDisks);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Проводник";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxOfDisks;
        private System.Windows.Forms.ListBox listBoxFolderContents;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripMenuItem navToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BackMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forwardMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toRootDirMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButtonBack;
        private System.Windows.Forms.ToolStripButton toolStripButtonForward;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.TextBox textBoxAdressLine;
    }
}

