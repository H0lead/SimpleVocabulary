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
    public partial class DeleteWord : Form
    {
        private Form1 mainForm;

        private Vocabulary vocabulary;

        private bool wordDeleted = false;

        public DeleteWord(Form1 mainForm, Vocabulary vocabulary)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.vocabulary = vocabulary;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (vocabulary != null)
            {
                if (deleteWordTextBox.Text != "")
                {
                    try
                    {
                        vocabulary.deleteWord(deleteWordTextBox.Text);
                        exportLabel.Text = $"Слово (слова) '{deleteWordTextBox.Text}' успішно видалено. ";
                        vocabulary.isSaved = false;
                        wordDeleted = true;
                        mainForm.saveToolStripMenuItem.Enabled = true;
                        mainForm.findTextBox.AutoCompleteCustomSource.Remove(deleteWordTextBox.Text);
                        mainForm.findTextBox.AutoCompleteCustomSource.Remove(deleteWordTextBox.Text.ToLower());

                    }
                    catch (WordNotFoundException ex)
                    {
                        exportLabel.Text = ex.Message;
                    }
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

        private void DeleteWord_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (vocabulary != null)
            {
                if (wordDeleted)
                {
                    mainForm.updateExportList();
                }
            }
        }
    }
}
