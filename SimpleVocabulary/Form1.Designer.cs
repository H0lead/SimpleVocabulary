namespace SimpleVocabulary
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findGroupBox = new System.Windows.Forms.GroupBox();
            this.cancelSearchButton = new System.Windows.Forms.Button();
            this.findButton = new System.Windows.Forms.Button();
            this.findTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addDeleteGroupBox = new System.Windows.Forms.GroupBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.showGroupBox = new System.Windows.Forms.GroupBox();
            this.exportListBox = new System.Windows.Forms.ListBox();
            this.openVocabularyFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveVocabularyFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.findGroupBox.SuspendLayout();
            this.addDeleteGroupBox.SuspendLayout();
            this.showGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(230, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.removeToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.addToolStripMenuItem.Text = "&Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.removeToolStripMenuItem.Text = "&Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutPToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(30, 24);
            this.toolStripMenuItem1.Text = "?";
            // 
            // aboutPToolStripMenuItem
            // 
            this.aboutPToolStripMenuItem.Name = "aboutPToolStripMenuItem";
            this.aboutPToolStripMenuItem.Size = new System.Drawing.Size(256, 26);
            this.aboutPToolStripMenuItem.Text = "&About SimpleVocabulary";
            this.aboutPToolStripMenuItem.Click += new System.EventHandler(this.aboutPToolStripMenuItem_Click);
            // 
            // findGroupBox
            // 
            this.findGroupBox.Controls.Add(this.cancelSearchButton);
            this.findGroupBox.Controls.Add(this.findButton);
            this.findGroupBox.Controls.Add(this.findTextBox);
            this.findGroupBox.Controls.Add(this.label1);
            this.findGroupBox.Location = new System.Drawing.Point(17, 34);
            this.findGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.findGroupBox.Name = "findGroupBox";
            this.findGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.findGroupBox.Size = new System.Drawing.Size(1033, 86);
            this.findGroupBox.TabIndex = 1;
            this.findGroupBox.TabStop = false;
            this.findGroupBox.Text = "Пошук терміна";
            // 
            // cancelSearchButton
            // 
            this.cancelSearchButton.Font = new System.Drawing.Font("Segoe MDL2 Assets", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelSearchButton.Location = new System.Drawing.Point(989, 16);
            this.cancelSearchButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cancelSearchButton.Name = "cancelSearchButton";
            this.cancelSearchButton.Size = new System.Drawing.Size(36, 25);
            this.cancelSearchButton.TabIndex = 3;
            this.cancelSearchButton.Text = "";
            this.cancelSearchButton.UseVisualStyleBackColor = true;
            this.cancelSearchButton.Click += new System.EventHandler(this.cancelSearchButton_Click);
            // 
            // findButton
            // 
            this.findButton.Location = new System.Drawing.Point(12, 48);
            this.findButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(1013, 28);
            this.findButton.TabIndex = 2;
            this.findButton.Text = "Знайти";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // findTextBox
            // 
            this.findTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.findTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.findTextBox.Location = new System.Drawing.Point(125, 16);
            this.findTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.findTextBox.Name = "findTextBox";
            this.findTextBox.Size = new System.Drawing.Size(855, 22);
            this.findTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Знайти термін:";
            // 
            // addDeleteGroupBox
            // 
            this.addDeleteGroupBox.Controls.Add(this.deleteButton);
            this.addDeleteGroupBox.Controls.Add(this.addButton);
            this.addDeleteGroupBox.Location = new System.Drawing.Point(17, 128);
            this.addDeleteGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addDeleteGroupBox.Name = "addDeleteGroupBox";
            this.addDeleteGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addDeleteGroupBox.Size = new System.Drawing.Size(1033, 78);
            this.addDeleteGroupBox.TabIndex = 2;
            this.addDeleteGroupBox.TabStop = false;
            this.addDeleteGroupBox.Text = "Дії з термінами";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(532, 25);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(493, 46);
            this.deleteButton.TabIndex = 1;
            this.deleteButton.Text = "Видалити термін";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(9, 25);
            this.addButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(493, 46);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Додати термін";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // showGroupBox
            // 
            this.showGroupBox.Controls.Add(this.exportListBox);
            this.showGroupBox.Location = new System.Drawing.Point(17, 213);
            this.showGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.showGroupBox.Name = "showGroupBox";
            this.showGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.showGroupBox.Size = new System.Drawing.Size(1033, 326);
            this.showGroupBox.TabIndex = 3;
            this.showGroupBox.TabStop = false;
            this.showGroupBox.Text = "Виведення термінів";
            // 
            // exportListBox
            // 
            this.exportListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.exportListBox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exportListBox.FormattingEnabled = true;
            this.exportListBox.HorizontalScrollbar = true;
            this.exportListBox.ItemHeight = 19;
            this.exportListBox.Location = new System.Drawing.Point(4, 19);
            this.exportListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exportListBox.Name = "exportListBox";
            this.exportListBox.Size = new System.Drawing.Size(1025, 303);
            this.exportListBox.TabIndex = 0;
            // 
            // openVocabularyFileDialog
            // 
            this.openVocabularyFileDialog.FileName = "openFileDialog1";
            this.openVocabularyFileDialog.Filter = "Текстові файли (*.txt)|*.txt|Усі файли (*.*)|*.*";
            // 
            // saveVocabularyFileDialog
            // 
            this.saveVocabularyFileDialog.Filter = "Текстові файли (*.txt)|*.txt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.showGroupBox);
            this.Controls.Add(this.addDeleteGroupBox);
            this.Controls.Add(this.findGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1082, 591);
            this.Name = "Form1";
            this.Text = "SimpleVocabulary";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.findGroupBox.ResumeLayout(false);
            this.findGroupBox.PerformLayout();
            this.addDeleteGroupBox.ResumeLayout(false);
            this.showGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutPToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.GroupBox findGroupBox;
        private System.Windows.Forms.GroupBox addDeleteGroupBox;
        private System.Windows.Forms.GroupBox showGroupBox;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.OpenFileDialog openVocabularyFileDialog;
        private System.Windows.Forms.ListBox exportListBox;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveVocabularyFileDialog;
        private System.Windows.Forms.Button cancelSearchButton;
        internal System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        internal System.Windows.Forms.TextBox findTextBox;
    }
}

