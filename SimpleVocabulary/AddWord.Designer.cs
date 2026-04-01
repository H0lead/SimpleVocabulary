namespace SimpleVocabulary
{
    partial class AddWord
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
            this.addWordGroupBox = new System.Windows.Forms.GroupBox();
            this.wordtextBox = new System.Windows.Forms.TextBox();
            this.valueTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addWordButton = new System.Windows.Forms.Button();
            this.exportLabel = new System.Windows.Forms.Label();
            this.addWordGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // addWordGroupBox
            // 
            this.addWordGroupBox.Controls.Add(this.exportLabel);
            this.addWordGroupBox.Controls.Add(this.addWordButton);
            this.addWordGroupBox.Controls.Add(this.label2);
            this.addWordGroupBox.Controls.Add(this.label1);
            this.addWordGroupBox.Controls.Add(this.valueTextBox);
            this.addWordGroupBox.Controls.Add(this.wordtextBox);
            this.addWordGroupBox.Location = new System.Drawing.Point(12, 12);
            this.addWordGroupBox.Name = "addWordGroupBox";
            this.addWordGroupBox.Size = new System.Drawing.Size(360, 137);
            this.addWordGroupBox.TabIndex = 0;
            this.addWordGroupBox.TabStop = false;
            this.addWordGroupBox.Text = "Додати слово до словника";
            // 
            // wordtextBox
            // 
            this.wordtextBox.Location = new System.Drawing.Point(6, 32);
            this.wordtextBox.Name = "wordtextBox";
            this.wordtextBox.Size = new System.Drawing.Size(347, 20);
            this.wordtextBox.TabIndex = 0;
            this.wordtextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.wordtextBox_KeyPress);
            // 
            // valueTextBox
            // 
            this.valueTextBox.Location = new System.Drawing.Point(6, 71);
            this.valueTextBox.Name = "valueTextBox";
            this.valueTextBox.Size = new System.Drawing.Size(347, 20);
            this.valueTextBox.TabIndex = 1;
            this.valueTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.valueTextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Слово:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Значення:";
            // 
            // addWordButton
            // 
            this.addWordButton.Location = new System.Drawing.Point(279, 98);
            this.addWordButton.Name = "addWordButton";
            this.addWordButton.Size = new System.Drawing.Size(75, 23);
            this.addWordButton.TabIndex = 4;
            this.addWordButton.Text = "Додати";
            this.addWordButton.UseVisualStyleBackColor = true;
            this.addWordButton.Click += new System.EventHandler(this.addWordButton_Click);
            // 
            // exportLabel
            // 
            this.exportLabel.AutoSize = true;
            this.exportLabel.Location = new System.Drawing.Point(6, 103);
            this.exportLabel.Name = "exportLabel";
            this.exportLabel.Size = new System.Drawing.Size(10, 13);
            this.exportLabel.TabIndex = 5;
            this.exportLabel.Text = " ";
            // 
            // AddWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.addWordGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddWord";
            this.Text = "Додати до словника";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddWord_FormClosing);
            this.addWordGroupBox.ResumeLayout(false);
            this.addWordGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox addWordGroupBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox valueTextBox;
        private System.Windows.Forms.TextBox wordtextBox;
        private System.Windows.Forms.Label exportLabel;
        private System.Windows.Forms.Button addWordButton;
    }
}