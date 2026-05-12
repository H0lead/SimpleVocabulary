namespace SimpleVocabulary
{
    partial class DeleteWord
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
            this.deleteWordGroupBox = new System.Windows.Forms.GroupBox();
            this.exportLabel = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.deleteWordTextBox = new System.Windows.Forms.TextBox();
            this.deleteWordGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // deleteWordGroupBox
            // 
            this.deleteWordGroupBox.Controls.Add(this.exportLabel);
            this.deleteWordGroupBox.Controls.Add(this.deleteButton);
            this.deleteWordGroupBox.Controls.Add(this.label1);
            this.deleteWordGroupBox.Controls.Add(this.deleteWordTextBox);
            this.deleteWordGroupBox.Location = new System.Drawing.Point(13, 13);
            this.deleteWordGroupBox.Name = "deleteWordGroupBox";
            this.deleteWordGroupBox.Size = new System.Drawing.Size(359, 136);
            this.deleteWordGroupBox.TabIndex = 0;
            this.deleteWordGroupBox.TabStop = false;
            this.deleteWordGroupBox.Text = "Видалити слово з словника";
            // 
            // exportLabel
            // 
            this.exportLabel.Location = new System.Drawing.Point(6, 59);
            this.exportLabel.Name = "exportLabel";
            this.exportLabel.Size = new System.Drawing.Size(265, 74);
            this.exportLabel.TabIndex = 5;
            this.exportLabel.Text = " ";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(277, 59);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "Видалити";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Слово:";
            // 
            // deleteWordTextBox
            // 
            this.deleteWordTextBox.Location = new System.Drawing.Point(6, 32);
            this.deleteWordTextBox.Name = "deleteWordTextBox";
            this.deleteWordTextBox.Size = new System.Drawing.Size(347, 20);
            this.deleteWordTextBox.TabIndex = 0;
            // 
            // DeleteWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.deleteWordGroupBox);
            this.Name = "DeleteWord";
            this.Text = "Видалити з словника";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DeleteWord_FormClosing);
            this.deleteWordGroupBox.ResumeLayout(false);
            this.deleteWordGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox deleteWordGroupBox;
        private System.Windows.Forms.TextBox deleteWordTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label exportLabel;
    }
}