namespace Task_3_CreatingAMenu
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
            this.textBoxTopLevelMenu = new System.Windows.Forms.TextBox();
            this.labelTopLevelMenu = new System.Windows.Forms.Label();
            this.labelSubItem = new System.Windows.Forms.Label();
            this.textBoxSubItem = new System.Windows.Forms.TextBox();
            this.buttonAddTopLevelMenu = new System.Windows.Forms.Button();
            this.buttonAddSubItem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxTopLevelMenu
            // 
            this.textBoxTopLevelMenu.Location = new System.Drawing.Point(16, 76);
            this.textBoxTopLevelMenu.Name = "textBoxTopLevelMenu";
            this.textBoxTopLevelMenu.Size = new System.Drawing.Size(149, 21);
            this.textBoxTopLevelMenu.TabIndex = 0;
            // 
            // labelTopLevelMenu
            // 
            this.labelTopLevelMenu.AutoSize = true;
            this.labelTopLevelMenu.Location = new System.Drawing.Point(15, 50);
            this.labelTopLevelMenu.Name = "labelTopLevelMenu";
            this.labelTopLevelMenu.Size = new System.Drawing.Size(76, 13);
            this.labelTopLevelMenu.TabIndex = 1;
            this.labelTopLevelMenu.Text = "TopLevelMenu";
            // 
            // labelSubItem
            // 
            this.labelSubItem.AutoSize = true;
            this.labelSubItem.Location = new System.Drawing.Point(199, 52);
            this.labelSubItem.Name = "labelSubItem";
            this.labelSubItem.Size = new System.Drawing.Size(47, 13);
            this.labelSubItem.TabIndex = 2;
            this.labelSubItem.Text = "SubItem";
            // 
            // textBoxSubItem
            // 
            this.textBoxSubItem.Location = new System.Drawing.Point(199, 76);
            this.textBoxSubItem.Name = "textBoxSubItem";
            this.textBoxSubItem.Size = new System.Drawing.Size(145, 21);
            this.textBoxSubItem.TabIndex = 3;
            // 
            // buttonAddTopLevelMenu
            // 
            this.buttonAddTopLevelMenu.Location = new System.Drawing.Point(16, 115);
            this.buttonAddTopLevelMenu.Name = "buttonAddTopLevelMenu";
            this.buttonAddTopLevelMenu.Size = new System.Drawing.Size(149, 50);
            this.buttonAddTopLevelMenu.TabIndex = 4;
            this.buttonAddTopLevelMenu.Text = "Добавить пункт меню";
            this.buttonAddTopLevelMenu.UseVisualStyleBackColor = true;
            this.buttonAddTopLevelMenu.Click += new System.EventHandler(this.buttonAddTopLevelMenu_Click);
            // 
            // buttonAddSubItem
            // 
            this.buttonAddSubItem.Location = new System.Drawing.Point(199, 115);
            this.buttonAddSubItem.Name = "buttonAddSubItem";
            this.buttonAddSubItem.Size = new System.Drawing.Size(145, 50);
            this.buttonAddSubItem.TabIndex = 5;
            this.buttonAddSubItem.Text = "Добавить подменю";
            this.buttonAddSubItem.UseVisualStyleBackColor = true;
            this.buttonAddSubItem.Click += new System.EventHandler(this.buttonAddSubItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 184);
            this.Controls.Add(this.buttonAddSubItem);
            this.Controls.Add(this.buttonAddTopLevelMenu);
            this.Controls.Add(this.textBoxSubItem);
            this.Controls.Add(this.labelSubItem);
            this.Controls.Add(this.labelTopLevelMenu);
            this.Controls.Add(this.textBoxTopLevelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Создание меню";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTopLevelMenu;
        private System.Windows.Forms.Label labelTopLevelMenu;
        private System.Windows.Forms.Label labelSubItem;
        private System.Windows.Forms.TextBox textBoxSubItem;
        private System.Windows.Forms.Button buttonAddTopLevelMenu;
        private System.Windows.Forms.Button buttonAddSubItem;
    }
}

