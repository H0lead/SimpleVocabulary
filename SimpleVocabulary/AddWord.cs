using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleVocabulary
{
    public partial class AddWord : Form
    {

        private Form1 mainForm;

        private Vocabulary vocabulary;

        private bool wordAdded = false;

        public AddWord(Form1 form, Vocabulary value)
        {
            InitializeComponent();
            mainForm = form;
            vocabulary = value;
        }

        private void wordtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '=') 
            {
                e.Handled = true;
            }
        }

        private void valueTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '=')
            {
                e.Handled = true;
            }
        }

        private void addWordButton_Click(object sender, EventArgs e)
        {
            if (vocabulary != null)
            {
                if (wordtextBox.Text != "" && valueTextBox.Text != "")
                {
                    vocabulary.addWord(wordtextBox.Text, valueTextBox.Text);
                    exportLabel.Text = "Слово успішно додано!";
                    vocabulary.isSaved = false;
                    wordAdded = true;
                    mainForm.saveToolStripMenuItem.Enabled = true;
                    mainForm.findTextBox.AutoCompleteCustomSource.Add(wordtextBox.Text);
                }
                else
                {
                    exportLabel.Text = "Одне з полів порожнє!";
                }
            }
            else
            {
                MessageBox.Show("Спочатку відкрийте словник!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddWord_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (vocabulary != null)
            {
                if (wordAdded)
                {
                    mainForm.updateExportList();
                }
            }
        }
    }
}
