namespace SimpleVocabulary
{
    partial class OpenProgressbar
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
            this.openProgressBarUI = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // openProgressBarUI
            // 
            this.openProgressBarUI.Location = new System.Drawing.Point(12, 12);
            this.openProgressBarUI.Name = "openProgressBarUI";
            this.openProgressBarUI.Size = new System.Drawing.Size(260, 23);
            this.openProgressBarUI.Step = 1;
            this.openProgressBarUI.TabIndex = 0;
            // 
            // OpenProgressbar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 51);
            this.ControlBox = false;
            this.Controls.Add(this.openProgressBarUI);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "OpenProgressbar";
            this.Text = "Зачекайте";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ProgressBar openProgressBarUI;
    }
}