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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.listBoxOfDisks = new System.Windows.Forms.ListBox();
            this.listBoxFolderContents = new System.Windows.Forms.ListBox();
            this.textBoxAdressLine = new System.Windows.Forms.TextBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createFileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.createFolderToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.navToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forwardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.toRootDirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonBack = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonForward = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCreateFile = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCreateFolder = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRename = new System.Windows.Forms.ToolStripButton();
            this.contextMenuListBoxOfDisks = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.backToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.forwardToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.переименоватьToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.openFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuListBoxFolderContents = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.createFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.contextMenuListBoxOfDisks.SuspendLayout();
            this.contextMenuListBoxFolderContents.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxOfDisks
            // 
            this.listBoxOfDisks.FormattingEnabled = true;
            this.listBoxOfDisks.Location = new System.Drawing.Point(12, 98);
            this.listBoxOfDisks.Name = "listBoxOfDisks";
            this.listBoxOfDisks.Size = new System.Drawing.Size(251, 264);
            this.listBoxOfDisks.TabIndex = 0;
            this.listBoxOfDisks.DoubleClick += new System.EventHandler(this.listBoxOfDisks_DoubleClick);
            // 
            // listBoxFolderContents
            // 
            this.listBoxFolderContents.FormattingEnabled = true;
            this.listBoxFolderContents.Location = new System.Drawing.Point(270, 98);
            this.listBoxFolderContents.Name = "listBoxFolderContents";
            this.listBoxFolderContents.Size = new System.Drawing.Size(233, 264);
            this.listBoxFolderContents.TabIndex = 1;
            // 
            // textBoxAdressLine
            // 
            this.textBoxAdressLine.Location = new System.Drawing.Point(13, 55);
            this.textBoxAdressLine.Name = "textBoxAdressLine";
            this.textBoxAdressLine.Size = new System.Drawing.Size(490, 21);
            this.textBoxAdressLine.TabIndex = 2;
            this.textBoxAdressLine.TextChanged += new System.EventHandler(this.textBoxAdressLine_TextChanged);
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
            this.createFileToolStripMenuItem1,
            this.createFolderToolStripMenuItem1,
            this.toolStripMenuItem4,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.menuToolStripMenuItem.Text = "Меню";
            // 
            // createFileToolStripMenuItem1
            // 
            this.createFileToolStripMenuItem1.Name = "createFileToolStripMenuItem1";
            this.createFileToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.createFileToolStripMenuItem1.Text = "Создать файл";
            // 
            // createFolderToolStripMenuItem1
            // 
            this.createFolderToolStripMenuItem1.Name = "createFolderToolStripMenuItem1";
            this.createFolderToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.createFolderToolStripMenuItem1.Text = "Создать папку";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(149, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Выход";
            // 
            // navToolStripMenuItem
            // 
            this.navToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BackToolStripMenuItem,
            this.forwardToolStripMenuItem,
            this.toolStripMenuItem1,
            this.toRootDirToolStripMenuItem});
            this.navToolStripMenuItem.Name = "navToolStripMenuItem";
            this.navToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.navToolStripMenuItem.Text = "Навигация";
            // 
            // BackToolStripMenuItem
            // 
            this.BackToolStripMenuItem.Name = "BackToolStripMenuItem";
            this.BackToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.BackToolStripMenuItem.Text = "Назад";
            this.BackToolStripMenuItem.Click += new System.EventHandler(this.BackToolStripMenuItem_Click);
            // 
            // forwardToolStripMenuItem
            // 
            this.forwardToolStripMenuItem.Name = "forwardToolStripMenuItem";
            this.forwardToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.forwardToolStripMenuItem.Text = "Вперед";
            this.forwardToolStripMenuItem.Click += new System.EventHandler(this.forwardToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(218, 6);
            // 
            // toRootDirToolStripMenuItem
            // 
            this.toRootDirToolStripMenuItem.Name = "toRootDirToolStripMenuItem";
            this.toRootDirToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.toRootDirToolStripMenuItem.Text = "Перейти в корневой каталог";
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonBack,
            this.toolStripButtonForward,
            this.toolStripButtonCreateFile,
            this.toolStripButtonCreateFolder,
            this.toolStripButtonRename});
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
            // toolStripButtonCreateFile
            // 
            this.toolStripButtonCreateFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonCreateFile.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCreateFile.Image")));
            this.toolStripButtonCreateFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCreateFile.Name = "toolStripButtonCreateFile";
            this.toolStripButtonCreateFile.Size = new System.Drawing.Size(83, 22);
            this.toolStripButtonCreateFile.Text = "Создать файл";
            // 
            // toolStripButtonCreateFolder
            // 
            this.toolStripButtonCreateFolder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonCreateFolder.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCreateFolder.Image")));
            this.toolStripButtonCreateFolder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCreateFolder.Name = "toolStripButtonCreateFolder";
            this.toolStripButtonCreateFolder.Size = new System.Drawing.Size(87, 22);
            this.toolStripButtonCreateFolder.Text = "Создать папку";
            // 
            // toolStripButtonRename
            // 
            this.toolStripButtonRename.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonRename.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRename.Image")));
            this.toolStripButtonRename.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRename.Name = "toolStripButtonRename";
            this.toolStripButtonRename.Size = new System.Drawing.Size(90, 22);
            this.toolStripButtonRename.Text = "Переименовать";
            // 
            // contextMenuListBoxOfDisks
            // 
            this.contextMenuListBoxOfDisks.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem1,
            this.forwardToolStripMenuItem1,
            this.переименоватьToolStripMenuItem,
            this.openFolderToolStripMenuItem});
            this.contextMenuListBoxOfDisks.Name = "contextMenuStrip1";
            this.contextMenuListBoxOfDisks.Size = new System.Drawing.Size(154, 76);
            // 
            // backToolStripMenuItem1
            // 
            this.backToolStripMenuItem1.Name = "backToolStripMenuItem1";
            this.backToolStripMenuItem1.Size = new System.Drawing.Size(153, 22);
            this.backToolStripMenuItem1.Text = "Назад";
            // 
            // forwardToolStripMenuItem1
            // 
            this.forwardToolStripMenuItem1.Name = "forwardToolStripMenuItem1";
            this.forwardToolStripMenuItem1.Size = new System.Drawing.Size(153, 22);
            this.forwardToolStripMenuItem1.Text = "Вперед";
            // 
            // переименоватьToolStripMenuItem
            // 
            this.переименоватьToolStripMenuItem.Name = "переименоватьToolStripMenuItem";
            this.переименоватьToolStripMenuItem.Size = new System.Drawing.Size(150, 6);
            // 
            // openFolderToolStripMenuItem
            // 
            this.openFolderToolStripMenuItem.Name = "openFolderToolStripMenuItem";
            this.openFolderToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.openFolderToolStripMenuItem.Text = "Открыть папку";
            // 
            // contextMenuListBoxFolderContents
            // 
            this.contextMenuListBoxFolderContents.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createFileToolStripMenuItem,
            this.createFolderToolStripMenuItem,
            this.toolStripMenuItem2,
            this.renameToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripMenuItem3});
            this.contextMenuListBoxFolderContents.Name = "contextMenuStrip2";
            this.contextMenuListBoxFolderContents.Size = new System.Drawing.Size(154, 104);
            // 
            // createFileToolStripMenuItem
            // 
            this.createFileToolStripMenuItem.Name = "createFileToolStripMenuItem";
            this.createFileToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.createFileToolStripMenuItem.Text = "Создать файл";
            // 
            // createFolderToolStripMenuItem
            // 
            this.createFolderToolStripMenuItem.Name = "createFolderToolStripMenuItem";
            this.createFolderToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.createFolderToolStripMenuItem.Text = "Создать папку";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(150, 6);
            // 
            // renameToolStripMenuItem
            // 
            this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
            this.renameToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.renameToolStripMenuItem.Text = "Переименовать";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.deleteToolStripMenuItem.Text = "Удалить";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(150, 6);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 394);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 416);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(270, 369);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(208, 134);
            this.listBox1.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 531);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.textBoxAdressLine);
            this.Controls.Add(this.listBoxFolderContents);
            this.Controls.Add(this.listBoxOfDisks);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "Проводник";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.contextMenuListBoxOfDisks.ResumeLayout(false);
            this.contextMenuListBoxFolderContents.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxOfDisks;
        private System.Windows.Forms.ListBox listBoxFolderContents;
        private System.Windows.Forms.TextBox textBoxAdressLine;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripMenuItem navToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forwardToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toRootDirToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButtonBack;
        private System.Windows.Forms.ToolStripButton toolStripButtonForward;
        private System.Windows.Forms.ContextMenuStrip contextMenuListBoxOfDisks;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem forwardToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator переименоватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFolderToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuListBoxFolderContents;
        private System.Windows.Forms.ToolStripMenuItem createFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripButton toolStripButtonCreateFile;
        private System.Windows.Forms.ToolStripButton toolStripButtonCreateFolder;
        private System.Windows.Forms.ToolStripButton toolStripButtonRename;
        private System.Windows.Forms.ToolStripMenuItem createFileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem createFolderToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
    }
}

